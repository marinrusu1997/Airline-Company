using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proiect_PAW
{
    public partial class ConfigurareDiscounts : Form
    {
        CompanieAeriana companie;
        Stack<IDiscount> discounts = new Stack<IDiscount>();
        Stack<DiscountManager> managers = new Stack<DiscountManager>();
        Dictionary<RutaAeriana, DiscountManager> DicDisc = new Dictionary<RutaAeriana, DiscountManager>();
        public ConfigurareDiscounts(CompanieAeriana companieAeriana)
        {
            InitializeComponent();
            this.companie = companieAeriana;
            InitDiscountTree();
        }

        private void InitDiscountTree()
        {
            try
            {
                foreach (var item in companie.Discounts)
                {
                    TreeNode root = new TreeNode(item.Key.ToString());
                    root.Tag = item.Key;
                    InitDiscountSubTree(root, item.Value);
                    root.BackColor = Color.SkyBlue;
                    tvDiscounts.Nodes.Add(root);
                }
            }
            catch { }
            tvDiscounts.ExpandAll();
        }

        private void InitDiscountSubTree(TreeNode root, IDiscount Idiscount)
        {
            TreeNode localRoot = new TreeNode(Idiscount.ToString());
            localRoot.Tag = Idiscount;
            root.Nodes.Add(localRoot);
            if (Idiscount.GetType() == typeof(DiscountManager))
            {
                localRoot.ForeColor = Color.Red;
                foreach (var discount in ((DiscountManager)Idiscount).Discounts)
                {
                    InitDiscountSubTree(localRoot, discount);
                }
            }
        }

        private RutaAeriana GetRutaOfSelectedDiscount()
        {
            TreeNode selectedNode = tvDiscounts.SelectedNode;
            if (selectedNode == null)
                return null;
            while (tvDiscounts.SelectedNode.Parent != null)
                tvDiscounts.SelectedNode = tvDiscounts.SelectedNode.Parent;
            var ruta = (RutaAeriana)tvDiscounts.SelectedNode.Tag;
            tvDiscounts.SelectedNode = selectedNode;
            return ruta;
        }

        private void InitModifiedDiscountSubTree(TreeNode root, IList<IDiscount> discounts)
        {
            foreach (var discount in discounts)
            {
                TreeNode node = new TreeNode(discount.ToString());
                node.Tag = discount;
                root.Nodes.Add(node);
                if (discount is DiscountManager)
                {
                    node.BackColor = Color.Red;
                    InitModifiedDiscountSubTree(node, (discount as DiscountManager).Discounts);
                }
            }
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeteazaDiscounts adaugaDiscounts = new SeteazaDiscounts(companie.Rute.Keys.ToList());
            adaugaDiscounts.StartPosition = FormStartPosition.CenterParent;
            var listaRute = new List<RutaAeriana>();
            var ruta = GetRutaOfSelectedDiscount();
            if (ruta == null)
                return;
            listaRute.Add(GetRutaOfSelectedDiscount());
            adaugaDiscounts.RuteAeriene.DataSource = listaRute;
            adaugaDiscounts.RuteAeriene.Enabled = false;
            adaugaDiscounts.AdaugaDiscountsButton.Text = "Modifică";
            if (tvDiscounts.SelectedNode.Tag is IDiscount && !(tvDiscounts.SelectedNode.Tag is DiscountManager))
            {
                adaugaDiscounts.SetDiscount(tvDiscounts.SelectedNode.Tag as IDiscount);
            }
            else if (tvDiscounts.SelectedNode.Tag is DiscountManager)
            {
                var dManager = tvDiscounts.SelectedNode.Tag as DiscountManager;
                ModificaDiscountManager modificaDiscountManager = new ModificaDiscountManager();
                modificaDiscountManager.ProcentDiscountMaxim = dManager.ProcentDiscountMaxim * 100;
                modificaDiscountManager.StartPosition = FormStartPosition.CenterParent;
                modificaDiscountManager.ShowDialog(this);
                dManager.ProcentDiscountMaxim = modificaDiscountManager.ProcentDiscountMaxim;

                tvDiscounts.Nodes.Clear();
                InitDiscountTree();

                return;
            }
                
            if (adaugaDiscounts.ShowDialog(this) == DialogResult.OK)
            {
                if (adaugaDiscounts.Discount != null)
                {
                    (tvDiscounts.SelectedNode.Tag as DiscountGeneric).CopyDiscount(adaugaDiscounts.Discount);
                    var parent = tvDiscounts.SelectedNode.Parent;
                    parent.Nodes.Clear();
                    InitModifiedDiscountSubTree(parent, (parent.Tag as DiscountManager).Discounts);
                    parent.ExpandAll();
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RutaAeriana ruta = null;
            TreeNode selectedNode = tvDiscounts.SelectedNode;
            if (selectedNode == null)
                return;
            while (tvDiscounts.SelectedNode.Parent != null)
                tvDiscounts.SelectedNode = tvDiscounts.SelectedNode.Parent;
            ruta = (RutaAeriana)tvDiscounts.SelectedNode.Tag;
            if (selectedNode.Tag is IDiscount)
            {
                if (companie.StergeDiscount(ruta, (IDiscount)selectedNode.Tag))
                {
                    tvDiscounts.Nodes.Clear();
                    InitDiscountTree();
                }
            }
            else if (selectedNode.Tag is RutaAeriana)
            {
                if (companie.StergeDiscounturi(ruta))
                {
                    tvDiscounts.Nodes.Clear();
                    InitDiscountTree();
                }
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeteazaDiscounts adaugaDiscounts = new SeteazaDiscounts(companie.Rute.Keys.ToList());
            adaugaDiscounts.StartPosition = FormStartPosition.CenterParent;
            var listaRute = new List<RutaAeriana>();
            var ruta = GetRutaOfSelectedDiscount();
            if (ruta == null)
                return;
            listaRute.Add(GetRutaOfSelectedDiscount());
            adaugaDiscounts.RuteAeriene.DataSource = listaRute;
            adaugaDiscounts.RuteAeriene.Enabled = false;
            if (adaugaDiscounts.ShowDialog(this) == DialogResult.OK)
            {
                if (adaugaDiscounts.Discount != null)
                {
                    companie.AdaugaDiscount(adaugaDiscounts.Ruta, adaugaDiscounts.Discount);
                    tvDiscounts.Nodes.Clear();
                    InitDiscountTree();
                }
            }
        }

        private void tvDiscounts_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void tvDiscounts_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void tvDiscounts_DragDrop(object sender, DragEventArgs e)
        {
            // Retrieve the client coordinates of the drop location.
            Point targetPoint = tvDiscounts.PointToClient(new Point(e.X, e.Y));

            // Retrieve the node at the drop location.
            TreeNode targetNode = tvDiscounts.GetNodeAt(targetPoint);

            if (targetNode.Tag is RutaAeriana || !(targetNode.Tag is DiscountManager))
                return;


            // Retrieve the node that was dragged.
            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

            // Sanity check
            if (draggedNode == null || draggedNode.Tag is RutaAeriana)
            {
                return;
            }
            foreach (TreeNode node in tvDiscounts.Nodes)
                if (node.FirstNode.Equals(draggedNode))
                    return;
            // Did the user drop on a valid target node?
            if (targetNode == null)
            {
                // The user dropped the node on the treeview control instead
                // of another node so lets place the node at the bottom of the tree.
                draggedNode.Remove();
                tvDiscounts.Nodes.Add(draggedNode);
                draggedNode.Expand();
            }
            else
            {
                TreeNode parentNode = targetNode;

                // Confirm that the node at the drop location is not 
                // the dragged node and that target node isn't null
                // (for example if you drag outside the control)
                if (!draggedNode.Equals(targetNode) && targetNode != null)
                {
                    bool canDrop = true;

                    // Crawl our way up from the node we dropped on to find out if
                    // if the target node is our parent. 
                    while (canDrop && (parentNode != null))
                    {
                        canDrop = !Object.ReferenceEquals(draggedNode, parentNode);
                        parentNode = parentNode.Parent;
                    }

                    // Is this a valid drop location?
                    if (canDrop)
                    {
                        // Yes. Move the node, expand it, and select it.
                        if (draggedNode.Parent.Nodes.Count == 1)
                            draggedNode.Parent.Remove();
                        (draggedNode.Parent.Tag as DiscountManager).
                            Discounts.Remove(draggedNode.Tag as IDiscount);
                        draggedNode.Remove();
                        targetNode.Nodes.Add(draggedNode);
                        (targetNode.Tag as DiscountManager).Discounts.Add(draggedNode.Tag as IDiscount);
                        targetNode.Expand();
                    }
                }
            }

            // Optional: Select the dropped node and navigate (however you do it)
            tvDiscounts.SelectedNode = draggedNode;
            // NavigateToContent(draggedNode.Tag);
        }

        private void ParseDiscountTree(TreeNodeCollection collection)
        {
            foreach (TreeNode node in collection)
            {
                if (node.FirstNode != null)
                {
                    if (node.Tag is DiscountManager)
                    {
                        var manager = node.Tag as DiscountManager;
                        manager.Discounts.Clear();
                        managers.Push(manager);

                        if (managers.Count > 1)
                        {
                            var temp = managers.Pop();
                            var tempParent = managers.Pop();
                            tempParent.Discounts.Add(temp);
                            managers.Push(tempParent);
                        }

                    }
                    ParseDiscountTree(node.Nodes);

                    var QTop = managers.Pop();
                    while (discounts.Count != 0)
                        QTop.Discounts.Add(discounts.Pop());
                    managers.Push(QTop);
                }
                else //leaf node
                {
                    discounts.Push(node.Tag as IDiscount);
                    // return;
                }
                if (node.Tag is RutaAeriana)
                {
                    DicDisc.Add(node.Tag as RutaAeriana, managers.Pop());
                }
            }
            //if( !(collection[0].Tag is RutaAeriana) || !(collection[0].Tag is DiscountGeneric))
            //{
            //    if(managers.Count > 1)
            //    {
            //        var temp = managers.Pop();
            //        var tempParent = managers.Pop();
            //        tempParent.Discounts.Add(temp);
            //        managers.Push(tempParent);
            //    }
            //}
        }

    }
}
