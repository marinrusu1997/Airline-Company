using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW.Rute_Forms
{
    public partial class RutaBaseForm : Form
    {
        protected delegate void RutaChangeHandler(object sender, EventArgs eventArgs);

        protected event RutaChangeHandler OnRutaChange;
        public RutaBaseForm()
        {
            InitializeComponent();
            OnRutaChange += new RutaChangeHandler((obj, args) => { MainWindow.CurrentMainWindow.DrawRoutesGraph(); });
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            OnRutaChange(this, new EventArgs());
        }
    }
}
