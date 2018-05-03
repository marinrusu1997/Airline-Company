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
    public partial class SeteazaDiscounts : Form
    {
        private IList<IDiscount> discounts;
        public float DiscountMaxim { get; internal set; }
        public IList<IDiscount> Discounts
        {
            get { return discounts.Distinct(new IDiscountComparer()).ToList(); }
            internal set { discounts = value; }
        }
        public IDiscount Discount { get; internal set; }
        public RutaAeriana Ruta { get; internal set; }

        public ComboBox RuteAeriene { get { return cbRute; } }

        public Button AdaugaDiscountsButton { get { return btnAdgDiscounturi; } }

        public void SetDiscount(IDiscount Idiscount)
        {
            discountsUserControl1.SetDiscount(Idiscount);
        }

        public SeteazaDiscounts(IList<RutaAeriana> ruteAieriene)
        {
            InitializeComponent();
            Discounts = new List<IDiscount>();
            cbRute.DataSource = ruteAieriene;
        }

        private void AdaugaDiscounts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                e.SuppressKeyPress = true;
                this.Close();
                e.SuppressKeyPress = false;
            }
        }

        private void btnAdgDiscounturi_Click(object sender, EventArgs e)
        {
            Ruta = (RutaAeriana)cbRute.SelectedItem;
            DiscountMaxim =(float)numericMaxDiscount.Value / 100;
            Discount = discountsUserControl1.GetDiscount();
        }

        private void btnAdgDiscount_Click(object sender, EventArgs e)
        {
            var discount = discountsUserControl1.GetDiscount();
            if (discount != null)
            {
                discounts.Add(discount);
                if (discounts.Count > 0)
                    btnClear.Enabled = true;
            }
        }

        private void cbRute_SelectedIndexChanged(object sender, EventArgs e)
        {
            discountsUserControl1.ResetAllFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            discounts.Clear();
            btnClear.Enabled = false;
        }

        private void btnAdaugaToate_Click(object sender, EventArgs e)
        {
            DiscountMaxim = (float)numericMaxDiscount.Value / 100;
        }

        private void AdaugaDiscounts_Load(object sender, EventArgs e)
        {
            if (Owner.GetType() == typeof(ConfigurareDiscounts))
            {
                btnAdaugaToate.Visible = false;
                btnAdgDiscount.Visible = false;
                btnClear.Visible = false;
                btnAdgDiscounturi.Location = btnClear.Location;
                labelDiscMaxim.Visible = false;
                numericMaxDiscount.Visible = false;
            }
        }
    }
}
