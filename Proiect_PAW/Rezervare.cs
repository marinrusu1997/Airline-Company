using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows;


namespace Proiect_PAW
{
   [Serializable]
    public class Persoana : IComparable, ICloneable
    {
        private string email;
        private string sex;
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email
        {
            get { return email; }
            set
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(value);
                    if (addr.Address == value)
                        email = value;
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Incorrect email format");
                }
            }
        }
        public string Cetatenie { get; set; }
        public DateTime DataNastere { get; set; }
        public string NumarPasaport { get; set; }
        public string Telefon { get; set; }
        public string CNP { get; set; }
        public string Sex
        {
            get { return sex; }
            set
            {
                if (value == "M" || value == "F")
                    sex = value;
            }
        }

        public const string FormatClipboard = "ClientObject";
        public bool EsteClient { get; set; }

        public Persoana() { }

        public Persoana(Persoana p)
        {
            Nume = p.Nume;
            Prenume = p.Prenume;
            Email = p.Email;
            Cetatenie = p.Cetatenie;
            DataNastere = p.DataNastere;
            NumarPasaport = p.NumarPasaport;
            Telefon = p.Telefon;
            CNP = p.CNP;
            Sex = p.Sex;
            EsteClient = p.EsteClient;
        }

        public Persoana(string CNP) 
        {
            this.CNP = CNP;
            if (DBRepositoriesManager.IsOpen)
            {
                var p = DBRepositoriesManager.AirCompanyDBGetPersoana(CNP);
                if (p != null)
                {
                    Nume = p.Nume;
                    Prenume = p.Prenume;
                    Email = p.Email;
                    Cetatenie = p.Cetatenie;
                    DataNastere = p.DataNastere;
                    NumarPasaport = p.NumarPasaport;
                    Telefon = p.Telefon;
                    CNP = p.CNP;
                    Sex = p.Sex;
                    EsteClient = p.EsteClient;
                }
            }
        }

        public Persoana(string nume,string prenume,string email,string cetatenie,DateTime dataNastere,
            string numarPasaport,string telefon,string cnp,string sex)
        {
            Nume = nume;
            Prenume = prenume;
            Email = email;
            Cetatenie = cetatenie;
            DataNastere = dataNastere;
            NumarPasaport = numarPasaport;
            Telefon = telefon;
            CNP = cnp;
            Sex = sex;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            return MemberwiseClone();           
        }

        public override string ToString()
        {
            return Nume + " " + Prenume + " " + Email + " " + Cetatenie + " " + DataNastere.ToShortDateString() +
                " " + NumarPasaport + " " + CNP + " " + Sex + " " + Telefon;
        }

        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }

    public class Rezervare : ICloneable, IComparable
    {
        private int numarBilete;
        public RutaAeriana RutaAeriana { get; set; }
        public ZborBasic Zbor { get; set; }
        public int NumarBilete
        {
            get { return numarBilete; }
            set { if (value >= 0) numarBilete = value; }
        }
        public Persoana Rezervant { get; set; }

        public Rezervare(RutaAeriana ruta,ZborBasic zbor,int nrBilete,
            Persoana persoana) 
        {
            RutaAeriana = ruta;
            Zbor = zbor;
            NumarBilete = nrBilete;
            Rezervant = persoana;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            Rezervare rez = (Rezervare)this.MemberwiseClone();
            rez.RutaAeriana = (RutaAeriana)RutaAeriana.Clone();
            rez.Zbor = (Zbor)Zbor.Clone();
            rez.Rezervant = (Persoana)Rezervant.Clone();
            return rez;
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            //if (obj == null)
            //    return false;
            //if (this.GetType() != obj.GetType())
            //    return false;
            //if (ReferenceEquals(this, obj))
            //    return true;
            //if (this.GetHashCode() != obj.GetHashCode())
            //    return false;
            ////System.Diagnostics.Debug.Assert(base.GetType() != typeof(object)); // check base.Equals() if base overides Equals()
            //// if (!base.Equals(obj))
            ////  return false;
            //Rezervare rezervare = obj as Rezervare;
            ////verificam egalitatea dupa id
            //return this.IdRezervare == rezervare.IdRezervare;
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
