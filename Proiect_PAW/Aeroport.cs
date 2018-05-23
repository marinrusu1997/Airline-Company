using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace Proiect_PAW
{
    public class Aeroport : IComparable,ICloneable
    {
        public string Nume { get; set; }
        public string Oras { get; set; }
        public string Tara { get; set; }
        public string IATA { get; set; }
        public string ICAO { get; set; }

        // Tara => Oras => Aeroporturi
        private static SortedDictionary<string, SortedDictionary<string, IList<Aeroport>>> aeroporturi = null;

        public static SortedDictionary<string, SortedDictionary<string, IList<Aeroport>>> Aeroporturi
        {
            get { return aeroporturi; }
        }
        public Aeroport()
        {

        }
        public Aeroport(string nume,string oras,string tara,string IATA,string ICAO)
        {
            this.Nume = nume;
            this.Oras = oras;
            this.Tara = tara;
            this.IATA = IATA;
            this.ICAO = ICAO;
        }

        public static void LoadAeroporturi()
        {
            if (Aeroport.aeroporturi == null)
               Aeroport.aeroporturi = new SortedDictionary<string, SortedDictionary<string, IList<Aeroport>>>();
            string[] aeroporturi = File.ReadAllLines(Properties.Settings.Default.DataFilesPath + "Airports.txt");
            foreach (var aeroport in aeroporturi)
            {
                string[] atribute = aeroport.Split(',');
                try
                {
                    var aeroportNou = new Aeroport(atribute[0], atribute[1], atribute[2],
                                                    atribute[3], atribute[4]);
                    if (Aeroporturi.ContainsKey(aeroportNou.Tara) == false)
                    {
                        Aeroporturi.Add(aeroportNou.Tara, new SortedDictionary<string, IList<Aeroport>>());
                        Aeroporturi[aeroportNou.Tara].Add(aeroportNou.Oras, new List<Aeroport>());
                    }
                    else if (Aeroporturi[aeroportNou.Tara].ContainsKey(aeroportNou.Oras) == false)
                    {
                        Aeroporturi[aeroportNou.Tara].Add(aeroportNou.Oras, new List<Aeroport>());
                    }
                    Aeroporturi[aeroportNou.Tara][aeroportNou.Oras].Add(aeroportNou);
                }
                catch (ArgumentNullException)
                {
                }
                catch (FormatException)
                {
                }
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (this.GetType() != obj.GetType())
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (this.GetHashCode() != obj.GetHashCode())
                return false;
            //System.Diagnostics.Debug.Assert(base.GetType() != typeof(object)); // check base.Equals() if base overides Equals()
            //if (!base.Equals(obj))
            //    return false;
            Aeroport aeroport = obj as Aeroport;
            return this.Nume.Equals(aeroport.Nume) && this.Tara.Equals(aeroport.Tara) &&
                this.Oras.Equals(aeroport.Oras) && this.IATA.Equals(aeroport.IATA)
                && this.ICAO.Equals(aeroport.ICAO);
        }

        public override string ToString()
        {
            //return Nume + "," + Oras + "," + Tara + "," + IATA + "," + ICAO + "," + Latitude + "," + Longitude +
            //    "," + Altitude + "," + TimeZone + "," + DST + "," + TZDATA;
            return Nume;
        }

        public override int GetHashCode()
        {
            var hashCode = -2012840122;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nume);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Oras);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Tara);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(IATA);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ICAO);
            return hashCode;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            Aeroport aeroport = obj as Aeroport;
            if (obj != null)
            {
                if (this.Nume.CompareTo(aeroport.Nume) == 1)
                    return 1;
                else if (this.Nume.CompareTo(aeroport.Nume) == -1)
                    return -1;
                else
                    return this.IATA.CompareTo(aeroport.IATA);
            }
            else
                throw new ArgumentException("Object is not a " + this.GetType().ToString());
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
