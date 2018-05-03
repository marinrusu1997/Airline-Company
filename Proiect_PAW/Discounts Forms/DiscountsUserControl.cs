using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class DiscountsUserControl : UserControl
    {
        public DiscountsUserControl()
        {
            InitializeComponent();
            cbMotiv.DataSource = Enum.GetValues(typeof(DiscountSpecific.MotivDiscount));
            cbMotiv.SelectedIndex = 0;
            cbTipDiscount.SelectedIndex = 1;
        }

        public IDiscount GetDiscount()
        {

            float discountProc = (float)numericProcSpec.Value / 100;
            if (cbTipDiscount.Text == "Discount Numar Bilete")
            {
                return new DiscountNrBilete(discountProc);
            }
            else if (cbTipDiscount.Text == "Discount Specific")
            {
                if (DateTime.Compare(dateTimeInceput.Value, dateTimeSfirsit.Value) >= 0)
                {
                    MessageBox.Show("Data de început nu poate fi mai mică decît data de sfîrșit",
                        "Eroare generare discount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                return new DiscountSpecific((DiscountSpecific.MotivDiscount)cbMotiv.SelectedItem, dateTimeInceput.Value,
                    dateTimeSfirsit.Value - dateTimeInceput.Value, (float)numericSumaAd.Value,
                    discountProc);
            }
            else
                return null;

        }

        public void SetDiscount(IDiscount Idiscount)
        {
            if(Idiscount.GetType() == typeof(DiscountNrBilete))
            {
                cbTipDiscount.SelectedItem = "Discount Numar Bilete";
                cbTipDiscount.Enabled = false;
                var discount = Idiscount as DiscountNrBilete;
                numericProcSpec.Value =(decimal)discount.ProcentDiscount * 100;
            } else if (Idiscount is DiscountSpecific)
            {
                cbTipDiscount.SelectedItem = "Discount Specific";
                cbTipDiscount.Enabled = false;
                var discount = Idiscount as DiscountSpecific;
                numericProcSpec.Value = (decimal)discount.ProcentDiscount * 100;
                numericSumaAd.Value = (decimal)discount.SumaAditionala;
                cbMotiv.SelectedItem = discount.MotivulDiscountului;
                dateTimeInceput.Value = discount.DataInceput;
                dateTimeSfirsit.Value = discount.DataSfirsit;
            }
        }

        private void ResetFields()
        {
            numericProcSpec.Value = numericProcSpec.Minimum;
            numericSumaAd.Value = numericSumaAd.Minimum;
            try { cbMotiv.SelectedIndex = 0; } catch { }
            dateTimeInceput.Value = dateTimeInceput.MinDate;
            dateTimeSfirsit.Value = dateTimeSfirsit.MinDate;
        }
        public void ResetAllFields()
        {
            try { cbTipDiscount.SelectedIndex = 0; } catch { }
            ResetFields();
        }
        private void cbMotiv_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbTipDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbTipDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetFields();
            if (cbTipDiscount.Text == "Discount Numar Bilete")
            {
                labelSuma.Visible = false; numericSumaAd.Visible = false;
                labelMotiv.Visible = false; cbMotiv.Visible = false;
                labelDataInc.Visible = false; dateTimeInceput.Visible = false;
                labelDataSf.Visible = false; dateTimeSfirsit.Visible = false;
            }
            else if (cbTipDiscount.Text == "Discount Specific")
            {
                labelSuma.Visible = true; numericSumaAd.Visible = true;
                labelMotiv.Visible = true; cbMotiv.Visible = true;
                labelDataInc.Visible = true; dateTimeInceput.Visible = true;
                labelDataSf.Visible = true; dateTimeSfirsit.Visible = true;
            }
        }
    }
}
