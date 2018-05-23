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
            if (obj == null)
                return 1;
            Persoana persoana = obj as Persoana;
            if (persoana != null)
            {
                var compData = DataNastere.CompareTo(persoana.DataNastere);
                if (compData == 0)
                    return CNP.CompareTo(persoana.CNP);
                else
                    return compData;
            }
            else
                throw new ArgumentException("Object is not a " + this.GetType());
        }

        public object Clone()
        {
            return MemberwiseClone();           
        }

        public override string ToString()
        {
            return Nume + " " + Prenume + "(" + CNP + ")";
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
            Persoana persoana = obj as Persoana;
            return Nume.Equals(persoana.Nume) && Prenume.Equals(persoana.Prenume) &&
                Email.Equals(persoana.Email) && Cetatenie.Equals(persoana.Cetatenie) &&
                DataNastere.Equals(persoana.DataNastere) && NumarPasaport.Equals(persoana.NumarPasaport)
                && Telefon.Equals(persoana.Telefon) && CNP.Equals(persoana.CNP) &&
                Sex.Equals(persoana.Sex);
        }

        public override int GetHashCode()
        {
            var hashCode = -1350515998;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(sex);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nume);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Prenume);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Cetatenie);
            hashCode = hashCode * -1521134295 + DataNastere.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NumarPasaport);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Telefon);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CNP);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Sex);
            hashCode = hashCode * -1521134295 + EsteClient.GetHashCode();
            return hashCode;
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
            if (obj == null)
                return 1;
            Rezervare rezervare = obj as Rezervare;
            if (rezervare != null)
            {
                if (numarBilete == rezervare.numarBilete)
                    if (Rezervant.CompareTo(rezervare.Rezervant) == 0)
                        if (RutaAeriana.CompareTo(rezervare.RutaAeriana) == 0)
                            if (Zbor.CompareTo(rezervare.Zbor) == 0)
                                return 0;
                            else
                                return Zbor.CompareTo(rezervare.Zbor);
                        else
                            return RutaAeriana.CompareTo(rezervare.RutaAeriana);
                    else
                        return Rezervant.CompareTo(rezervare.Rezervant);
                else
                    return numarBilete.CompareTo(rezervare.numarBilete);
            }   
            else
                throw new ArgumentException("Object is not a " + this.GetType());
            
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
            return Rezervant.Nume + " " + Rezervant.Prenume + " " + NumarBilete + " bilete";
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
            Rezervare rezervare = obj as Rezervare;
            //verificam egalitatea dupa id
            return this.numarBilete == rezervare.numarBilete && this.RutaAeriana.Equals(rezervare.RutaAeriana) &&
                this.Zbor.Equals(rezervare.Zbor) && this.Rezervant.Equals(rezervare.Rezervant);
        }

        public override int GetHashCode()
        {
            var hashCode = 1246232170;
            hashCode = hashCode * -1521134295 + numarBilete.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<RutaAeriana>.Default.GetHashCode(RutaAeriana);
            hashCode = hashCode * -1521134295 + EqualityComparer<ZborBasic>.Default.GetHashCode(Zbor);
            hashCode = hashCode * -1521134295 + NumarBilete.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Persoana>.Default.GetHashCode(Rezervant);
            return hashCode;
        }
    }
}
