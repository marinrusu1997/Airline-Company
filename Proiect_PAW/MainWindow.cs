using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Data.SqlClient;
using QuickGraph;
using QuickGraph.Graphviz;
using QuickGraph.Graphviz.Dot;
using Proiect_PAW.Rezervari_Forms;

namespace Proiect_PAW
{
    public partial class MainWindow : Form
    {
        CompanieAeriana AirMoldova;
        IList<Aeroport> aeroports = new List<Aeroport>();

        public static MainWindow CurrentMainWindow { get; internal set; }

        public MainWindow()
        {
            InitializeComponent();
            CompanieAeriana.NumeFisierSerializare = "CompanieAeriana.txt";
            if (File.Exists(Properties.Settings.Default.SerializationFilesPath + CompanieAeriana.NumeFisierSerializare))
            {
                AirMoldova = CompanieAeriana.Deserialize();
            }
            else
            {
                AirMoldova = new CompanieAeriana("Air", "Chisinau", "0789856356", "air@moldova.md");
            }
            AirMoldova.GraphRute = new AdjacencyGraph<Aeroport, Edge<Aeroport>>();
            ThreadPool.SetMaxThreads(2, 2);
            ThreadPool.QueueUserWorkItem(obj => { Aeroport.LoadAeroporturi(); });
            ThreadPool.QueueUserWorkItem(obj => { AirMoldova.DeserializeazaDiscounturi(); });
            LoadRoutes();

            CurrentMainWindow = this;
            //Action LoadAeropAsync = new Action(Aeroport.LoadAeroporturi);
            //LoadAeropAsync.BeginInvoke(new AsyncCallback(result =>
            //{
            //    (result.AsyncState as Action).EndInvoke(result);

            //}), LoadAeropAsync);
        }

        public sealed class FileDotEngine : IDotEngine
        {
            public string Run(GraphvizImageType imageType, string dot, string outputFileName)
            {
                string output = outputFileName;
                File.WriteAllText(output, dot);


                // assumes dot.exe is on the path:
                var args = string.Format(@"{0} -Tjpg -O", output);
                System.Diagnostics.Process.Start(@"C:\Users\dimar\source\repos\Proiect_PAW\packages\Graphviz.2.38.0.2\dot.exe", args);
                return output;
            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                using (var wrapMode = new System.Drawing.Imaging.ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImage;
        }

        private async void LoadRoutes()
        {
            AirMoldova.CitesteRuteXML();
            pictureBox1.Image = new Bitmap(@"" + await CreateRoutesGraph());
        }

        private async Task<string> CreateRoutesGraph()
        {
            AirMoldova.GraphRute.Clear();
            HashSet<Edge<Aeroport>> aeroports = new HashSet<Edge<Aeroport>>();
            foreach (var Ruta in AirMoldova.Rute)
            {
                aeroports.Add(new Edge<Aeroport>(Ruta.Key.AeroportDecolare, Ruta.Key.AeroportAterizare));
            }
            AirMoldova.GraphRute.AddVerticesAndEdgeRange(aeroports);

            var graphReprez = new GraphvizAlgorithm<Aeroport, Edge<Aeroport>>(AirMoldova.GraphRute);
            graphReprez.FormatVertex += new FormatVertexEventHandler<Aeroport>((obj, args) =>
            {
                args.VertexFormatter.FillColor = GraphvizColor.LightYellow;
                args.VertexFormatter.Style = GraphvizVertexStyle.Bold | GraphvizVertexStyle.Filled;
                args.VertexFormatter.Shape = GraphvizVertexShape.Ellipse;
                args.VertexFormatter.Size = new GraphvizSizeF(50, 50);
                args.VertexFormatter.Font = new GraphvizFont("Times New Roman", 8);
            });

            if (File.Exists(@"C:\Users\dimar\source\repos\Proiect_PAW\Proiect_PAW\Resources\Images\graphRute.jpg"))
                File.Delete(@"C:\Users\dimar\source\repos\Proiect_PAW\Proiect_PAW\Resources\Images\graphRute.jpg");
            if (File.Exists(@"C:\Users\dimar\source\repos\Proiect_PAW\Proiect_PAW\Resources\Images\graphRute"))
                File.Delete(@"C:\Users\dimar\source\repos\Proiect_PAW\Proiect_PAW\Resources\Images\graphRute");

            graphReprez.Generate(new FileDotEngine(),
                @"C:\Users\dimar\source\repos\Proiect_PAW\Proiect_PAW\Resources\Images\" + "graphRute");
            while (!File.Exists(@"C:\Users\dimar\source\repos\Proiect_PAW\Proiect_PAW\Resources\Images\graphRute.jpg"))
                await Task.Delay(2000);

            return @"C:\Users\dimar\source\repos\Proiect_PAW\Proiect_PAW\Resources\Images\graphRute.jpg";
        }

        public async void DrawRoutesGraph()
        {
            try
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = new Bitmap(@"" + await CreateRoutesGraph());
            } catch
            {

            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MessageBox.Show("Doriți să salvați modificările?",
            "Salvare Modificări", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                AirMoldova.Serialize();
                AirMoldova.SalveazaRuteXML();
                AirMoldova.SerializeazaDiscounturi();
            }
            base.OnFormClosing(e);
        }

        private void dateDeContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateCompanie dateCompanie = new DateCompanie(AirMoldova);
            dateCompanie.StartPosition = FormStartPosition.CenterScreen;
            if (dateCompanie.ShowDialog(this) == DialogResult.OK)
            {
                AirMoldova.Nume = dateCompanie.tbNume.Text;
                AirMoldova.Adresa = dateCompanie.tbAdresa.Text;
                AirMoldova.Email = dateCompanie.tbEmail.Text;
                AirMoldova.Telefon = dateCompanie.tbTelefon.Text;
            }
        }

        private void adaugaRutaNouaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugaRuta adaugaRuta = new AdaugaRuta(AirMoldova);
            adaugaRuta.StartPosition = FormStartPosition.CenterParent;
            adaugaRuta.ShowDialog(this);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void adaugaZboruriRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugaZboruriRuta adaugaZboruriRuta = new AdaugaZboruriRuta(this.AirMoldova);
            adaugaZboruriRuta.StartPosition = FormStartPosition.CenterParent;
            adaugaZboruriRuta.ShowDialog(this);
        }

        private void stergeRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StergeRuta stergeRuta = new StergeRuta(AirMoldova);
            stergeRuta.StartPosition = FormStartPosition.CenterParent;
            stergeRuta.Width = 500;
            stergeRuta.Height = 150;
            stergeRuta.ShowDialog(this);
        }

        private void modificaRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificaRuta modificaRuta = new ModificaRuta(AirMoldova);
            modificaRuta.StartPosition = FormStartPosition.CenterParent;
            modificaRuta.ShowDialog(this);
        }

        private void valoriDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeteazaDiscounts adaugaDiscounts = new SeteazaDiscounts(AirMoldova.Rute.Keys.ToList());
            adaugaDiscounts.StartPosition = FormStartPosition.CenterParent;
            var result = adaugaDiscounts.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                AirMoldova.DiscountMaxim = adaugaDiscounts.DiscountMaxim;
                AirMoldova.AdaugaDiscount(adaugaDiscounts.Ruta, adaugaDiscounts.Discounts);
            }
            else if (result == DialogResult.Yes)
            {
                AirMoldova.DiscountMaxim = adaugaDiscounts.DiscountMaxim;
                foreach (var ruta in AirMoldova.Rute)
                {
                    AirMoldova.AdaugaDiscount(ruta.Key, adaugaDiscounts.Discounts);
                }
            }
        }

        private void configurareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurareDiscounts configurareDiscounts = new ConfigurareDiscounts(AirMoldova);
            configurareDiscounts.StartPosition = FormStartPosition.CenterParent;
            configurareDiscounts.ShowDialog(this);
        }

        private void adaugaClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var adaugaClient = new AdaugaClient();
            adaugaClient.StartPosition = FormStartPosition.CenterParent;
            adaugaClient.ShowDialog(this);
        }

        private void vizualizeazaClientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gestiuneClienti = new GestioneazaClienti();
            gestiuneClienti.StartPosition = FormStartPosition.CenterParent;
            gestiuneClienti.Show();
        }

        private void adaugaRezervareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugaRezervare adaugaRezervare = new AdaugaRezervare(AirMoldova);
            adaugaRezervare.StartPosition = FormStartPosition.CenterParent;
            adaugaRezervare.ShowDialog(this);
        }

        private void stergeRezervareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rezervareConfig = new RezervariConfigurare(AirMoldova);
            rezervareConfig.StartPosition = FormStartPosition.CenterParent;
            rezervareConfig.ShowDialog(this);
        }

        private void rapoarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_Forms.ReportManager reportManager = new Report_Forms.ReportManager();
            reportManager.StartPosition = FormStartPosition.CenterParent;
            reportManager.CompanieAeriana = AirMoldova;
            reportManager.Show(this);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.StartPosition = FormStartPosition.CenterParent;
            about.ShowDialog(this);
        }

        private void redeseneazăRuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawRoutesGraph();
        }

        private void diagrameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chart_Forms.ChartsManager chartsManager = new Chart_Forms.ChartsManager();
            chartsManager.CompanieAeriana = AirMoldova;
            chartsManager.WindowState = FormWindowState.Maximized;
            chartsManager.ShowDialog();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBRepositoriesManager.CloseAirCompanyDB();
        }
    }
}
