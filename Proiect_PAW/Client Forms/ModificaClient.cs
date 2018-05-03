using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW.Client_Forms
{
    public partial class ModificaClient : Form
    {
        public Persoana Client { get; set; }
        public ModificaClient()
        {
            InitializeComponent();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            Client = clientUserControl1.Persoana;
            Close();
        }

        private void ModificaClient_Load(object sender, EventArgs e)
        {
            clientUserControl1.Persoana = Client;          
        }


    }
}
