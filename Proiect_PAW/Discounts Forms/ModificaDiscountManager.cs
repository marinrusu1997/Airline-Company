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
    public partial class ModificaDiscountManager : Form
    {
        public float ProcentDiscountMaxim { get; set; }
        public ModificaDiscountManager()
        {
            InitializeComponent();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            ProcentDiscountMaxim = (float)numericProcentMaxim.Value / 100;
            Close();
        }

        private void ModificaDiscountManager_Load(object sender, EventArgs e)
        {
            numericProcentMaxim.Value = (decimal)ProcentDiscountMaxim;
        }
    }
}
