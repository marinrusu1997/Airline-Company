using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW.Chart_Forms
{
    public partial class ZboruriChartConfig : Form
    {
        public RutaAeriana RutaAeriana { get; internal set; }
        public string Luna { get; internal set; }
        public IList<Zbor> Zboruri { get; internal set; }
        public SortedDictionary<RutaAeriana, SortedDictionary<DateTime, SortedDictionary<Zbor, Hashtable>>> RuteAeriene {internal get; set; }
        public ZboruriChartConfig()
        {
            InitializeComponent();
            cbLuni.SelectedIndex = 0;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            cbRuteAeriene.DataSource = RuteAeriene.Keys.ToList();
        }

        private void cbTrimestre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbRuteAeriene.SelectedItem != null)
            {
                RutaAeriana = cbRuteAeriene.SelectedItem as RutaAeriana;
                Luna = cbLuni.SelectedItem.ToString();
                List<Zbor> zboruri = new List<Zbor>();
                foreach (var data in RuteAeriene[RutaAeriana])
                {
                    if (data.Key.Month == (cbLuni.SelectedIndex + 1))
                        zboruri.AddRange(RuteAeriene[RutaAeriana][data.Key].Keys);
                }
                Zboruri = zboruri;              
            } else
            {
                RutaAeriana = null;
                Luna = null;
                Zboruri = null;
            }
        }
    }
}
