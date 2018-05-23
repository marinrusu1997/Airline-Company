using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Xml;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
using QuickGraph;



namespace Proiect_PAW
{

    [Serializable]
    public class CompanieAeriana : ICloneable, IComparable, ISerializable , IEnumerable<KeyValuePair<RutaAeriana,DiscountManager>>
    {
        SortedDictionary<RutaAeriana, SortedDictionary<DateTime, SortedDictionary<Zbor, Hashtable>>> rute;
        Dictionary<RutaAeriana, DiscountManager> discounts;
        string nume;
        string adresa;
        string telefon;
        string email;

        internal class DiscountEntry
        {
            public RutaAeriana Key { get; set; }
            public DiscountManager Value { get; set; }

            [JsonConstructor]
            public DiscountEntry(RutaAeriana ruta, DiscountManager manager)
            {
                Key = ruta;
                Value = manager;
            }
        }
        public static string NumeFisierSerializare
        {
            get; set;
        }

        internal float DiscountMaxim { get; set; }

        public string Email
        {
            get { return email; }
            set
            {
                try
                {
                    if (new System.Net.Mail.MailAddress(value).Address == value)
                        email = value;
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Incorrect email format");
                }
            }
        }
        public SortedDictionary<RutaAeriana, SortedDictionary<DateTime, SortedDictionary<Zbor, Hashtable>>> Rute
        {
            get { return rute; }
            set
            {
                if (value != null)
                    rute = value;
            }
        }
        public Dictionary<RutaAeriana, DiscountManager> Discounts
        {
            get { return discounts; }
            set
            {
                if (value != null)
                    discounts = value;
            }
        }
        public AdjacencyGraph<Aeroport, Edge<Aeroport>> GraphRute { get; set; }

        public string Nume
        {
            get { return nume; }
            set
            {
                if (value != null)
                    nume = value;
            }
        }
        public string Adresa
        {
            get { return adresa; }
            set
            {
                if (value != null)
                    adresa = value;
            }
        }
        public string Telefon
        {
            get { return telefon; }
            set
            {
                if (value != null)
                    telefon = value;
            }
        }

        private CompanieAeriana()
        {
            rute = new SortedDictionary<RutaAeriana, SortedDictionary<DateTime, SortedDictionary<Zbor, Hashtable>>>();
            discounts = new Dictionary<RutaAeriana, DiscountManager>();
        }
        //constructor pentru deserializare
        public CompanieAeriana(SerializationInfo info, StreamingContext context) : this()
        {
            nume = (string)info.GetValue("nume", typeof(string));
            adresa = (string)info.GetValue("adresa", typeof(string));
            telefon = (string)info.GetValue("telefon", typeof(string));
            email = (string)info.GetValue("email", typeof(string));
        }

        public CompanieAeriana(string nume, string adresa, string telefon, string email) : this()
        {
            this.Nume = nume;
            this.Adresa = adresa;
            this.Telefon = telefon;
            this.Email = email;
        }

       
        public DiscountManager this[RutaAeriana rutaAeriana]
        {
            get { discounts.TryGetValue(rutaAeriana, out var discountPerioada); return discountPerioada; }
            set
            {
                discounts[rutaAeriana] = value;
            }
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
        public object Clone()
        {
            throw new NotImplementedException();
        }
        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return "Compania Aeriana " + nume + ",avind adresa " + adresa + ",telefonul " + telefon + " si email " + email;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("nume", nume, typeof(string));
            info.AddValue("adresa", adresa, typeof(string));
            info.AddValue("telefon", telefon, typeof(string));
            info.AddValue("email", email, typeof(string));
        }
        public void Serialize()
        {
            IFormatter formatter = new BinaryFormatter();
            FileStream s = new FileStream(NumeFisierSerializare, FileMode.Create);
            formatter.Serialize(s, this);
            s.Close();
        }
        public static CompanieAeriana Deserialize()
        {
            IFormatter formatter = new BinaryFormatter();
            FileStream s = new FileStream(Properties.Settings.Default.SerializationFilesPath + NumeFisierSerializare, FileMode.Open);
            CompanieAeriana companieAeriana = (CompanieAeriana)formatter.Deserialize(s);
            s.Close();
            return companieAeriana;
        }

        public static DateTime ExtractDate(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
        }
        public bool AdaugaRezervare(Rezervare rezervare,out float sumaDePlata)
        {
            if (this.rute.TryGetValue(rezervare.RutaAeriana, out var zboruri)) //daca aceasta ruta exista
            {
                if (zboruri.TryGetValue(ExtractDate(rezervare.Zbor.TimpDecolare), out var zbor)) //daca exista acest zbor
                {
                    var zborCautat = zbor.Keys.ToList().Find(zborInput =>
                   {
                       if (((ZborBasic)zborInput).Equals(rezervare.Zbor))
                           return true;
                       else
                           return false;
                   });
                    if (zborCautat != null) //daca zborul a fost gasit
                    {
                        if (zborCautat.LocuriDisponibile - rezervare.NumarBilete > 0) //daca sunt locuri disponibile
                        {
                            //aplicam discount daca e posibil
                            float sumaPlatita = zborCautat.Cost;
                            if (this.discounts.TryGetValue(rezervare.RutaAeriana, out var discountManager))
                            {
                                sumaPlatita = discountManager.ApplyDiscount(rezervare, zborCautat);
                            }
                            sumaDePlata = sumaPlatita * rezervare.NumarBilete;
                            try
                            {
                                zbor[zborCautat].Add(rezervare.Rezervant.CNP, rezervare); //adaugam rezervarea
                                zborCautat -= rezervare.NumarBilete;
                            } catch 
                            {
                                //rezervantul deja se afla in lista
                                sumaDePlata = -1;
                                return false;
                            }                                   
                            return true; //succes
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Nu mai sunt locuri disponibile");
                            sumaDePlata = -1;
                            return false;
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Acest zbor nu exista");
                        sumaDePlata = -1;
                        return false;
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Pentru aceasta ruta nu exista zboruri pe data specificata");
                    sumaDePlata = -1;
                    return false;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Compania " + Nume + " nu are zboruri pe ruta specificata ");
                sumaDePlata = -1;
                return false;
            }
        }
        public bool AdaugaDiscount(RutaAeriana ruta, IDiscount discount)
        {
            if (ruta == null || discount == null)
                return false;
            if (!this.discounts.ContainsKey(ruta))
                this.discounts.Add(ruta, new DiscountManager(DiscountMaxim, new List<IDiscount>()));
            this.discounts[ruta].Discounts.Add(discount);
            //this.discounts[ruta].ProcentDiscountMaxim = DiscountMaxim;
            return true;
        }
        public void AdaugaDiscount(RutaAeriana ruta, IList<IDiscount> discounturi)
        {
            if (ruta == null || discounturi == null)
                return;
            if (this.discounts.ContainsKey(ruta))
            {
                this.discounts[ruta].Discounts = discounturi;
                this.discounts[ruta].ProcentDiscountMaxim = DiscountMaxim;
            }
            else
                this.discounts.Add(ruta, new DiscountManager(DiscountMaxim, discounturi));
        }
        public bool StergeRezervare(Rezervare rezervare)
        {
            if (rute.TryGetValue(rezervare.RutaAeriana, out var dateDecolare))
            {
                if (dateDecolare.TryGetValue(ExtractDate(rezervare.Zbor.TimpDecolare), out var zboruri))
                {
                    var zborCautat = zboruri.Keys.ToList().Find(zborInput =>
                    {
                        if (((ZborBasic)zborInput).Equals(rezervare.Zbor))
                            return true;
                        else
                            return false;
                    });
                    if (zborCautat != null)
                    {
                        zboruri[zborCautat].Remove(rezervare.Rezervant.CNP);
                        zborCautat.LocuriDisponibile += rezervare.NumarBilete;
                        return true;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            else
                return false;
        }
        public bool StergeDiscount(RutaAeriana ruta, IDiscount discount)
        {
            try
            {
                return this.discounts[ruta].StergeDiscount(discount);
            }
            catch
            {
                return false;
            }
        }
        public bool StergeDiscounturi(RutaAeriana ruta)
        {
            try
            {
                return this.discounts.Remove(ruta);
            }
            catch
            {
                return false;
            }
        }
        public bool AdaugaZboruri(RutaAeriana ruta, IList<Zbor> zboruri)
        {
            if (ruta == null || zboruri == null)
                return false;
            if (this.rute.ContainsKey(ruta))
            {
                foreach (var zbor in zboruri)
                {
                    var dataDecolare = ExtractDate(zbor.TimpDecolare);
                    if (this.rute[ruta].ContainsKey(dataDecolare) == false)
                    {
                        this.rute[ruta].Add(dataDecolare, new SortedDictionary<Zbor, Hashtable>());
                        this.rute[ruta][dataDecolare].Add(zbor, new Hashtable());
                    }
                    else
                        try
                        {
                            this.rute[ruta][dataDecolare].Add(zbor, new Hashtable());
                        }
                        catch (ArgumentException)
                        {
                            System.Windows.Forms.MessageBox.Show("Zborul" + zbor.ToString() +
                                "deja există în colecție", "Eroare adăugare zbor",
                                System.Windows.Forms.MessageBoxButtons.OK,
                                System.Windows.Forms.MessageBoxIcon.Error);
                        }
                }
                return true;
            }
            else
                return false;
        }
        public bool AdaugaZbor(RutaAeriana rutaAeriana, Zbor zbor, Hashtable rezervari)
        {
            if (rutaAeriana == null || zbor == null || rezervari == null)
                throw new ArgumentNullException();
            if (rute.TryGetValue(rutaAeriana, out var zboruri))
            {
                if (zboruri.ContainsKey(ExtractDate(zbor.TimpDecolare)))
                {
                    try
                    {
                        zboruri[ExtractDate(zbor.TimpDecolare)].Add(zbor, rezervari);
                        return true;
                    }
                    catch (ArgumentException)
                    {
                        return false;
                    }
                }
                else
                {
                    zboruri.Add(ExtractDate(zbor.TimpDecolare), new SortedDictionary<Zbor, Hashtable>());
                    zboruri[ExtractDate(zbor.TimpDecolare)].Add(zbor, rezervari);
                    return true;
                }
            }
            else
                return false;
        }
        public bool AdaugaRuta(RutaAeriana ruta)
        {
            if (this.rute.ContainsKey(ruta))
                return false;
            else
            {
                this.rute.Add(ruta, new SortedDictionary<DateTime, SortedDictionary<Zbor, Hashtable>>());
                return true;
            }
        }
        public bool AdaugaRuta(RutaAeriana ruta, SortedDictionary<DateTime, SortedDictionary<Zbor, Hashtable>> zboruri)
        {
            if (ruta == null || zboruri == null)
                throw new ArgumentNullException();
            if (!this.rute.ContainsKey(ruta))
            {
                this.rute.Add(ruta, zboruri);
                return true;
            }
            else
                return false;
        }
        public bool StergeRuta(RutaAeriana ruta)
        {
            if (ruta == null)
                return false;
            if (this.rute.ContainsKey(ruta))
            {
                this.rute.Remove(ruta);
                return true;
            }
            else
                return false;
        }

        public void SalveazaRuteXML()
        {
            MemoryStream memstream = new MemoryStream();
            XmlTextWriter xmlwriter = new XmlTextWriter(memstream, Encoding.UTF8);
            xmlwriter.Formatting = System.Xml.Formatting.Indented;

            //inceput document
            xmlwriter.WriteStartDocument();
            //inceput Rute Aeriene
            xmlwriter.WriteStartElement("RuteAeriene");
            foreach (var ruta in rute)
            {
                //inceput ruta
                xmlwriter.WriteStartElement("RutaAeriana");

                xmlwriter.WriteAttributeString("taraDec", ruta.Key.AeroportDecolare.Tara);
                xmlwriter.WriteAttributeString("orasDec", ruta.Key.AeroportDecolare.Oras);
                xmlwriter.WriteAttributeString("numeAeropDec", ruta.Key.AeroportDecolare.Nume);
                xmlwriter.WriteAttributeString("codIATAAeropDec", ruta.Key.AeroportDecolare.IATA);
                xmlwriter.WriteAttributeString("codICAOAeropDec", ruta.Key.AeroportDecolare.ICAO);

                xmlwriter.WriteAttributeString("taraAter", ruta.Key.AeroportAterizare.Tara);
                xmlwriter.WriteAttributeString("orasAter", ruta.Key.AeroportAterizare.Oras);
                xmlwriter.WriteAttributeString("numeAeropAter", ruta.Key.AeroportAterizare.Nume);
                xmlwriter.WriteAttributeString("codIATAAeropAter", ruta.Key.AeroportAterizare.IATA);
                xmlwriter.WriteAttributeString("codICAOAeropAter", ruta.Key.AeroportAterizare.ICAO);

                foreach (var zboruri in ruta.Value)
                {
                    //inceput data
                    xmlwriter.WriteStartElement("DataPlecare");
                    xmlwriter.WriteAttributeString("data", zboruri.Key.ToShortDateString());
                    //scriem zborurile pe data curenta
                    foreach (var zbor in zboruri.Value)
                    {
                        //inceput zbor
                        xmlwriter.WriteStartElement("Zbor");
                        xmlwriter.WriteAttributeString("dataPlecare", zbor.Key.TimpDecolare.ToString());
                        xmlwriter.WriteAttributeString("nrLocuriDisponibile", zbor.Key.LocuriDisponibile.ToString());
                        xmlwriter.WriteAttributeString("nrLocuriTotal", zbor.Key.NumarLocuri.ToString());
                        xmlwriter.WriteAttributeString("cost", zbor.Key.Cost.ToString());
                        xmlwriter.WriteAttributeString("dataSosire", zbor.Key.TimpAterizare.ToString());

                        //scriem rezervarile
                        foreach (var rezervare in zbor.Value.Values)
                        {
                            //inceput rezervare
                            xmlwriter.WriteStartElement("Rezervare");
                            xmlwriter.WriteAttributeString("nrBilete", ((Rezervare)rezervare).NumarBilete.ToString());
                            xmlwriter.WriteAttributeString("persoana", ((Rezervare)rezervare).Rezervant.CNP);
                            //sfirsit rezervare
                            xmlwriter.WriteEndElement();
                        }
                        //sfirsit zbor
                        xmlwriter.WriteEndElement();
                    }
                    //sfirsit data
                    xmlwriter.WriteEndElement();
                }
                //sfirsit ruta
                xmlwriter.WriteEndElement();
            }
            //sfirsit rute aeriene
            xmlwriter.WriteEndElement();
            //sfirsit document
            xmlwriter.WriteEndDocument();
            xmlwriter.Close();

            string xml = Encoding.UTF8.GetString(memstream.ToArray());
            memstream.Close();

            StreamWriter streamwriter = new StreamWriter(@Properties.Settings.Default.SerializationFilesPath + "RuteAeriene.xml");
            streamwriter.WriteLine(xml);
            streamwriter.Close();
        }
        public void CitesteRuteXML()
        {
            if (!DBRepositoriesManager.OpenAirCompanyDB())
            {
                System.Windows.Forms.MessageBox.Show("Eroare la deschiderea bazei de date", "Eroare deschidere baza de date",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            

            XmlDocument document = new XmlDocument();
            try
            {
                document.Load(@Properties.Settings.Default.SerializationFilesPath + "RuteAeriene.xml");
            }
            catch (FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("Unnable to open rute.xml");
                return;
            }

            this.rute.Clear();
            RutaAeriana ruta;
            Hashtable TabelaRezervari;
            SortedDictionary<DateTime, SortedDictionary<Zbor, Hashtable>> DicInfoRute;
            DateTime data;
            SortedDictionary<Zbor, Hashtable> DicZboruri;
            //nivelul cu rute
            foreach (XmlNode rutaNode in document.DocumentElement.ChildNodes)
            {
                //alocare dictionar pentru ruta
                DicInfoRute = new SortedDictionary<DateTime, SortedDictionary<Zbor, Hashtable>>();
                //alocare ruta
                ruta = new RutaAeriana(new Aeroport(rutaNode.Attributes["numeAeropDec"]?.InnerText,
                    rutaNode.Attributes["orasDec"]?.InnerText, rutaNode.Attributes["taraDec"]?.InnerText,
                    rutaNode.Attributes["codIATAAeropDec"]?.InnerText, rutaNode.Attributes["codICAOAeropDec"]?.InnerText),
                    new Aeroport(rutaNode.Attributes["numeAeropAter"]?.InnerText, rutaNode.Attributes["orasAter"]?.InnerText,
                    rutaNode.Attributes["taraAter"]?.InnerText, rutaNode.Attributes["codIATAAeropAter"]?.InnerText,
                    rutaNode.Attributes["codICAOAeropAter"]?.InnerText));
                //nivelul cu zboruri pentru o data anumita
                foreach (XmlNode dataNode in rutaNode.ChildNodes)
                {
                    //alocare data
                    data = DateTime.ParseExact(dataNode.Attributes["data"]?.InnerText, "dd/MM/yyyy",
                        System.Globalization.CultureInfo.InvariantCulture);
                    DicZboruri = new SortedDictionary<Zbor, Hashtable>();
                    //nivelul cu zboruri
                    foreach (XmlNode zborNode in dataNode.ChildNodes)
                    {
                        //alocam tabela de rezervari pentru zborul curent
                        TabelaRezervari = new Hashtable();

                        Zbor zbor = new Zbor(DateTime.ParseExact(zborNode.Attributes["dataPlecare"]?.InnerText,
                            "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
                            , DateTime.ParseExact(zborNode.Attributes["dataSosire"]?.InnerText,
                            "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
                            , float.Parse(zborNode.Attributes["cost"]?.InnerText),
                            int.Parse(zborNode.Attributes["nrLocuriDisponibile"]?.InnerText));
                        zbor.NumarLocuri = int.Parse(zborNode.Attributes["nrLocuriTotal"]?.InnerText);
                        foreach (XmlNode rezervareNode in zborNode.ChildNodes)
                        {
                            var rezervare = new Rezervare(
                                            ruta, zbor, int.Parse(rezervareNode.Attributes["nrBilete"]?.InnerText),
                                            //new Persoana(rezervareNode.Attributes["persoana"]?.InnerText));
                                            DBRepositoriesManager.AirCompanyDBGetPersoana(rezervareNode.Attributes["persoana"]?.InnerText));
                            TabelaRezervari.Add(rezervare.Rezervant.CNP, rezervare);
                        }
                        DicZboruri.Add(zbor, TabelaRezervari);
                    }
                    DicInfoRute.Add(data, DicZboruri);
                }
                //adauga ruta cu dictionarul ei in Rutele Companiei
                this.rute.Add(ruta, DicInfoRute);
            }

            DBRepositoriesManager.CloseAirCompanyDB();
        }
        public void SerializeazaDiscounturi()
        {
            File.WriteAllText(@Properties.Settings.Default.SerializationFilesPath +  "Discounturi.txt",
                JsonConvert.SerializeObject(
                                   discounts.Keys.AsEnumerable().
                                   Select(key => new DiscountEntry(key, discounts[key]))
                                   .ToList(),
                                   Newtonsoft.Json.Formatting.Indented,
                                   new JsonSerializerSettings
                                   {
                                       TypeNameHandling = TypeNameHandling.Auto
                                   }
                                   ));
        }
        public void DeserializeazaDiscounturi()
        {
            try
            {
                var dictionaryEntries = JsonConvert.
                    DeserializeObject<List<DiscountEntry>>(
                    File.ReadAllText(@Properties.Settings.Default.SerializationFilesPath + "Discounturi.txt"),
                    new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.Auto
                    }
                    );
                foreach (var entry in dictionaryEntries)
                {
                    discounts.Add(entry.Key, entry.Value);
                }
            }
            catch (FileNotFoundException)
            {
                return;
            }

        }

        public IEnumerator<KeyValuePair<RutaAeriana, DiscountManager>> GetEnumerator()
        {
            return discounts.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
