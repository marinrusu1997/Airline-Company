using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Proiect_PAW.Client_Forms;
using System.Data.SqlClient;

namespace Proiect_PAW
{
    public partial class GestioneazaClienti : Form
    {
        private ListViewColumnSorter listViewColumnSorter = new ListViewColumnSorter();
        private Stack<ListViewItem> highlightedItems = new Stack<ListViewItem>();
        private int findCounter = 0;
        public GestioneazaClienti()
        {
            InitializeComponent();
            lvClienti.ListViewItemSorter = listViewColumnSorter;
        }

        private void GestioneazaClienti_Load(object sender, EventArgs e)
        {
            if(DBRepositoriesManager.OpenAirCompanyDB() == false)
            {
                MessageBox.Show("Eroare la deschiderea bazei de date");
                Close();
                return;
            }
            var DbReader = DBRepositoriesManager.AirCompanyDBExecuteReader("SELECT * from CLIENTI");
            if(DbReader == null)
            {
                MessageBox.Show("Eroare la citirea datelor din baza de date");
                Close();
                return;
            }
            using (DbReader)
            {
                while (DbReader.Read())
                {
                    var client = new Persoana(DbReader["NUME"].ToString(), DbReader["PRENUME"].ToString(),
                        DbReader["EMAIL"].ToString(), DbReader["CETATENIE"].ToString(),
                        ((DateTime)DbReader["DATA_NASTERE"]), DbReader["NUMAR_PASAPORT"].ToString(),
                        DbReader["TELEFON"].ToString(), DbReader["CNP"].ToString(), DbReader["SEX"].ToString());

                    var ClientItem = new ListViewItem(client.Nume);
                    ClientItem.SubItems.Add(client.Prenume);
                    ClientItem.SubItems.Add(client.Cetatenie);
                    ClientItem.SubItems.Add(client.NumarPasaport);
                    ClientItem.SubItems.Add(client.DataNastere.ToShortDateString());
                    ClientItem.SubItems.Add(client.CNP);
                    ClientItem.SubItems.Add(client.Sex);
                    ClientItem.SubItems.Add(client.Telefon);
                    ClientItem.SubItems.Add(client.Email);

                    ClientItem.Tag = client;
                    lvClienti.Items.Add(ClientItem);
                }
            }
            foreach(ColumnHeader column in lvClienti.Columns)
            {
                column.Width = -1;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            DBRepositoriesManager.CloseAirCompanyDB();
            base.OnClosing(e);
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificaClient modificaClient;
            foreach (ListViewItem clientItem in lvClienti.SelectedItems)
            {
                modificaClient = new ModificaClient();
                modificaClient.Client = clientItem.Tag as Persoana;
                if(modificaClient.ShowDialog(this) == DialogResult.OK)
                {
                    var comanda = new SqlCommand();
                    var clientModificat = modificaClient.Client;
                    comanda.CommandText = "UPDATE CLIENTI SET NUME=@nume,PRENUME=@prenume,EMAIL=@email," +
                        "CETATENIE=@cetatenie," +
                        "DATA_NASTERE=@data_nastere,NUMAR_PASAPORT=@nr_pasaport,TELEFON=@telefon," +
                        "CNP=@cnp,SEX=@sex " +
                        "WHERE CNP=@cnp_cautat";
                    
                    comanda.Parameters.Add("@nume", SqlDbType.VarChar).Value = clientModificat.Nume;
                    comanda.Parameters.Add("@prenume", SqlDbType.VarChar).Value = clientModificat.Prenume;
                    comanda.Parameters.Add("@email", SqlDbType.VarChar).Value = clientModificat.Email;
                    comanda.Parameters.Add("@cetatenie", SqlDbType.VarChar).Value = clientModificat.Cetatenie;
                    comanda.Parameters.Add("@data_nastere", SqlDbType.Date).Value = clientModificat.DataNastere.
                                                                                ToString("yyyy-MM-dd");
                    comanda.Parameters.Add("@nr_pasaport", SqlDbType.VarChar).Value = clientModificat.NumarPasaport;
                    comanda.Parameters.Add("@telefon", SqlDbType.VarChar).Value = clientModificat.Telefon;
                    comanda.Parameters.Add("@cnp", SqlDbType.VarChar).Value = clientModificat.CNP;
                    comanda.Parameters.Add("@sex", SqlDbType.VarChar).Value = clientModificat.Sex;
                    comanda.Parameters.Add("@cnp_cautat", SqlDbType.VarChar).Value = 
                        (clientItem.Tag as Persoana).CNP;

                    if(DBRepositoriesManager.AirCompanyDBExecuteNonQuerry(comanda) == -1)
                    {
                        MessageBox.Show("Eroare la actualizarea datelor pentru clientul " + clientModificat.CNP);
                        continue;
                    }
                    else
                    {
                        clientItem.Tag = clientModificat;
                        clientItem.SubItems.Clear();
                        clientItem.Text = clientModificat.Nume;                        
                        clientItem.SubItems.Add(clientModificat.Prenume);
                        clientItem.SubItems.Add(clientModificat.Cetatenie);
                        clientItem.SubItems.Add(clientModificat.NumarPasaport);
                        clientItem.SubItems.Add(clientModificat.DataNastere.ToShortDateString());
                        clientItem.SubItems.Add(clientModificat.CNP);
                        clientItem.SubItems.Add(clientModificat.Sex);
                        clientItem.SubItems.Add(clientModificat.Telefon);
                        clientItem.SubItems.Add(clientModificat.Email);
                        lvClienti.Refresh();
                    }
                }
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem clientItem in lvClienti.SelectedItems)
            {
                var command = new SqlCommand();
                command.CommandText = "DELETE FROM CLIENTI WHERE CNP=@cnp_de_sters";
                command.Parameters.Add("@cnp_de_sters", SqlDbType.VarChar).Value = (clientItem.Tag as Persoana).CNP;

                if(DBRepositoriesManager.AirCompanyDBExecuteNonQuerry(command) != -1)
                {
                    lvClienti.Items.Remove(clientItem);
                }
            }
            lvClienti.Refresh();
        }

        private void sorteazaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lvClienti_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == listViewColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (listViewColumnSorter.Order == System.Windows.Forms.SortOrder.Ascending)
                {
                    listViewColumnSorter.Order = System.Windows.Forms.SortOrder.Descending;
                }
                else
                {
                    listViewColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                listViewColumnSorter.SortColumn = e.Column;
                listViewColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.lvClienti.Sort();
        }

        private void cetatenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvClienti.Groups.Clear();
            // This flag will tell us if proper group already exists
            bool group_exists = false;

            foreach (ListViewItem item in lvClienti.Items)
            {
                // Check each group if it fits to the item
                foreach (ListViewGroup group in this.lvClienti.Groups)
                {
                    // Compare group's header to selected subitem's text
                    if (group.Header == item.SubItems[2].Text)
                    {
                        // Add item to the group.
                        // Alternative is: group.Items.Add(item);
                        item.Group = group;
                        group_exists = true;
                        break;
                    }
                }
                // Create new group if no proper group was found
                if (!group_exists)
                {
                    // Create group and specify its header by
                    // getting selected subitem's text
                    ListViewGroup group = new ListViewGroup(item.SubItems[2].Text);
                    // We need to add the group to the ListView first
                    this.lvClienti.Groups.Add(group);
                    item.Group = group;
                }
                group_exists = false;
            }

            ListViewGroup[] groups = new ListViewGroup[this.lvClienti.Groups.Count];
            this.lvClienti.Groups.CopyTo(groups, 0);

            Array.Sort(groups, Comparer<ListViewGroup>.Create
                (
                    (grp1, grp2) => grp1.Header.CompareTo(grp2.Header)
                ));

            this.lvClienti.BeginUpdate();
            this.lvClienti.Groups.Clear();
            this.lvClienti.Groups.AddRange(groups);
            this.lvClienti.EndUpdate();

            listViewColumnSorter.Order = System.Windows.Forms.SortOrder.Descending;
            lvClienti_ColumnClick(new object(), new ColumnClickEventArgs(0));
        }

        private void sexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvClienti.Groups.Clear();
            // This flag will tell us if proper group already exists
            bool group_exists = false;

            foreach (ListViewItem item in lvClienti.Items)
            {
                // Check each group if it fits to the item
                foreach (ListViewGroup group in this.lvClienti.Groups)
                {
                    // Compare group's header to selected subitem's text
                    if (group.Header == item.SubItems[6].Text)
                    {
                        // Add item to the group.
                        // Alternative is: group.Items.Add(item);
                        item.Group = group;
                        group_exists = true;
                        break;
                    }
                }
                // Create new group if no proper group was found
                if (!group_exists)
                {
                    // Create group and specify its header by
                    // getting selected subitem's text
                    ListViewGroup group = new ListViewGroup(item.SubItems[6].Text);
                    // We need to add the group to the ListView first
                    this.lvClienti.Groups.Add(group);
                    item.Group = group;
                }
                group_exists = false;
            }

            listViewColumnSorter.Order = System.Windows.Forms.SortOrder.Descending;
            lvClienti_ColumnClick(new object(), new ColumnClickEventArgs(0));
        }

        private void GroupListViewItems(int subItemIndex,int subStrLength)
        {
            lvClienti.Groups.Clear();
            // This flag will tell us if proper group already exists
            bool group_exists = false;

            foreach (ListViewItem item in lvClienti.Items)
            {
                // Check each group if it fits to the item
                foreach (ListViewGroup group in this.lvClienti.Groups)
                {
                    // Compare group's header to selected subitem's text
                    if (group.Header == item.SubItems[subItemIndex].Text.Substring(0, subStrLength))
                    {
                        // Add item to the group.
                        // Alternative is: group.Items.Add(item);
                        item.Group = group;
                        group_exists = true;
                        break;
                    }
                }
                // Create new group if no proper group was found
                if (!group_exists)
                {
                    // Create group and specify its header by
                    // getting selected subitem's text
                    ListViewGroup group = new ListViewGroup(item.SubItems[subItemIndex].Text.Substring(0,
                        subStrLength));
                    // We need to add the group to the ListView first
                    this.lvClienti.Groups.Add(group);
                    item.Group = group;
                }
                group_exists = false;
            }

            ListViewGroup[] groups = new ListViewGroup[this.lvClienti.Groups.Count];
            this.lvClienti.Groups.CopyTo(groups, 0);

            Array.Sort(groups, Comparer<ListViewGroup>.Create
                (
                    (grp1, grp2) => grp1.Header.CompareTo(grp2.Header)
                ));

            this.lvClienti.BeginUpdate();
            this.lvClienti.Groups.Clear();
            this.lvClienti.Groups.AddRange(groups);
            this.lvClienti.EndUpdate();

            listViewColumnSorter.Order = System.Windows.Forms.SortOrder.Descending;
            lvClienti_ColumnClick(new object(), new ColumnClickEventArgs(0));
        }

        private void literaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupListViewItems(0, 1);
        }

        private void litereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupListViewItems(0, 2);
        }

        private void litereToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GroupListViewItems(0, 3);
        }

        private void toolStripClienti_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lvClienti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool ItemMatches(ListViewItem item, string text)
        {
            bool matches = false;

            matches |= item.Text.ToLower().Contains(text.ToLower());

            if (matches)
            {
                return true;
            }

            foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
            {
                matches |= subitem.Text.ToLower().Contains(text.ToLower());
                if (matches)
                {
                    return true;
                }
            }

            return false;
        }

        private void SearchItem()
        {
            string search = toolStripSearchTb.Text;
            // Search items in our Jobs ListView, remove those that do not match search
            if (search != String.Empty)
            {
                for (int i = lvClienti.Items.Count - 1; i >= 0; i--)
                {
                    ListViewItem currentItem = lvClienti.Items[i];
                    if (ItemMatches(currentItem, search))
                    {
                        currentItem.BackColor = BackColor = SystemColors.Highlight;
                    }
                }
            }
        }

        private void GestioneazaClienti_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                if (findCounter % 2 == 0)
                {
                    toolStrip1.Visible = true;
                    this.ActiveControl = toolStrip1;
                }
                else
                {
                    toolStrip1.Visible = false;
                    while (highlightedItems.Count != 0)
                    {
                        highlightedItems.Pop().BackColor = lvClienti.BackColor;
                    }
                }
                findCounter++;
            }
        }

        private void toolStripSearchTb_TextChanged(object sender, EventArgs e)
        {
            while(highlightedItems.Count != 0)
            {
                highlightedItems.Pop().BackColor = lvClienti.BackColor;
            }

            string search = toolStripSearchTb.Text;
            // Search items in our Jobs ListView, remove those that do not match search
            if (search != String.Empty)
            {
                for (int i = lvClienti.Items.Count - 1; i >= 0; i--)
                {
                    ListViewItem currentItem = lvClienti.Items[i];
                    if (ItemMatches(currentItem, search))
                    {
                        currentItem.BackColor = BackColor = SystemColors.Highlight;
                        highlightedItems.Push(currentItem);
                    }
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvClienti.SelectedItems.Count == 1)
            {
                Clipboard.Clear();
                Clipboard.SetData(Persoana.FormatClipboard,(Persoana)lvClienti.SelectedItems[0].Tag);
            }
        }
    }
}
