using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Globalization;

namespace Proiect_PAW
{
    public class ZborBasic : IComparable, ICloneable
    {
        public DateTime TimpDecolare
        {
            get;
            set;
        }
        public DateTime TimpAterizare
        {
            get; set;
        }

        public ZborBasic() { }
        public ZborBasic(DateTime timpDecolare, DateTime timpAterizare)
        {
            TimpDecolare = timpDecolare;
            TimpAterizare = timpAterizare;
        }

        public virtual int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            ZborBasic zborBasic = obj as ZborBasic;
            if (zborBasic != null)
            {
                if (this.TimpAterizare == zborBasic.TimpAterizare &&
                    this.TimpDecolare == zborBasic.TimpDecolare)
                    return 0;
                else
                {
                    var dec = DateTime.Compare(this.TimpDecolare, zborBasic.TimpDecolare);
                    if (dec == 0)
                    {
                        return DateTime.Compare(this.TimpAterizare, zborBasic.TimpAterizare);
                    }
                    else
                        return dec;
                }
            }
            else
                throw new ArgumentException("Object is not a " + this.GetType().ToString());
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
            ZborBasic zborBasic = obj as ZborBasic;
            return this.TimpAterizare.Equals(zborBasic.TimpAterizare) &&
                this.TimpDecolare.Equals(zborBasic.TimpDecolare);
        }

        public override int GetHashCode()
        {
            var hashCode = -1600445500;
            hashCode = hashCode * -1521134295 + TimpDecolare.GetHashCode();
            hashCode = hashCode * -1521134295 + TimpAterizare.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return "Decolare: " + TimpDecolare.ToShortTimeString() + " ,Aterizare: " + TimpAterizare.ToShortTimeString();
        }

        public virtual object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class Zbor : ZborBasic, ICloneable
    {
        private float cost;
        private int nrLocuriDisponibile;

        public int NumarLocuri { get; internal set; }
        public float Cost
        {
            get { return cost; }
            set
            {
                if (value >= 0)
                    cost = value;
            }
        }
        public int LocuriDisponibile
        {
            get { return nrLocuriDisponibile; }
            set
            {
                if (value >= 0)
                    nrLocuriDisponibile = value;
            }
        }

        public Zbor(DateTime timpDecolare, DateTime timpAterizare,
            float cost, int nrLocuri) : base(timpDecolare, timpAterizare)
        {
            if (cost >= 0)
                this.cost = cost;
            else
                this.cost = 0;
            if (nrLocuri >= 0)
            {
                this.nrLocuriDisponibile = nrLocuri;
                NumarLocuri = nrLocuri;
            }
            else
            {
                this.nrLocuriDisponibile = 0;
                NumarLocuri = 0;
            }
        }
        public override object Clone()
        {
            return this.MemberwiseClone();
        }
        public override int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            Zbor zbor = obj as Zbor;
            if (zbor != null)
            {
                int baseComp = base.CompareTo(zbor);
                if (baseComp != 0)
                    return baseComp;
                else
                if (this.cost > zbor.cost)
                    return 1;
                else if (this.cost < zbor.cost)
                    return -1;
                else if (this.nrLocuriDisponibile > zbor.nrLocuriDisponibile)
                    return 1;
                else if (this.nrLocuriDisponibile < zbor.nrLocuriDisponibile)
                    return -1;
                else
                    return 0;
            }
            else
                throw new ArgumentException("Object is not a " + this.GetType().ToString());
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
            System.Diagnostics.Debug.Assert(base.GetType() != typeof(object)); // check base.Equals() if base overides Equals()
            if (!base.Equals(obj))
                return false;
            Zbor zbor = obj as Zbor;
            return this.cost == zbor.cost && this.nrLocuriDisponibile == zbor.nrLocuriDisponibile && this.NumarLocuri == zbor.NumarLocuri;
        }

        public static Zbor operator -(Zbor obj, int NrLocuri)
        {
            if (obj != null && (obj.nrLocuriDisponibile - NrLocuri) >= 0)
            {
                obj.nrLocuriDisponibile -= NrLocuri;
                return obj;
            }
            else
                return obj;
        }
        public static Zbor operator -(Zbor obj, float cost)
        {
            if (obj != null && (obj.cost - cost) >= 0)
            {
                obj.cost -= cost;
                return obj;
            }
            else
                return obj;
        }
        public static Zbor operator +(Zbor obj, float cost)
        {
            if (cost > 0)
            {
                obj.cost += cost;
                return obj;
            }
            else
                return obj;
        }

        public override string ToString()
        {
            return "Decolare: " + TimpDecolare.ToShortTimeString() + ",Aterizare: " + TimpAterizare.ToShortTimeString()
                + ",Cost: " + cost + ",Locuri: " + nrLocuriDisponibile;
            //return "Cost: " + cost + ",Locuri: " + nrLocuri;
        }

        public override int GetHashCode()
        {
            var hashCode = 1350721730;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + cost.GetHashCode();
            hashCode = hashCode * -1521134295 + nrLocuriDisponibile.GetHashCode();
            hashCode = hashCode * -1521134295 + Cost.GetHashCode();
            hashCode = hashCode * -1521134295 + LocuriDisponibile.GetHashCode();
            return hashCode;
        }
    }

    public class RutaAeriana : ICloneable, IComparable
    {
        public Aeroport AeroportDecolare { get; set; }
        public Aeroport AeroportAterizare { get; set; }
        public RutaAeriana() { }

        public RutaAeriana(Aeroport decolare, Aeroport aterizare)
        {
            AeroportDecolare = decolare;
            AeroportAterizare = aterizare;
        }

        public RutaAeriana(RutaAeriana ruta)
        {
            AeroportDecolare = (Aeroport)ruta.AeroportDecolare.Clone();
            AeroportAterizare = (Aeroport)ruta.AeroportAterizare.Clone();
        }

        public object Clone()
        {
            RutaAeriana ruta = new RutaAeriana();
            ruta.AeroportDecolare = (Aeroport)this.AeroportDecolare.Clone();
            ruta.AeroportAterizare = (Aeroport)this.AeroportAterizare.Clone();
            return ruta;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            RutaAeriana ruta = obj as RutaAeriana;
            if (ruta != null)
            {
                if (this.AeroportAterizare == null || this.AeroportDecolare == null)
                    return -1;
                if (ruta.AeroportAterizare == null || ruta.AeroportDecolare == null)
                    return 1;
                if (this.AeroportDecolare.CompareTo(ruta.AeroportDecolare) == 1)
                    return 1;
                else if (this.AeroportDecolare.CompareTo(ruta.AeroportDecolare) == -1)
                    return -1;
                else
                    return this.AeroportAterizare.CompareTo(ruta.AeroportAterizare);
            }
            else
                throw new ArgumentException("Object is not a " + this.GetType().ToString());
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
            // System.Diagnostics.Debug.Assert(base.GetType() != typeof(object)); // check base.Equals() if base overides Equals()
            //if (!base.Equals(obj))
            //   return false;
            RutaAeriana ruta = obj as RutaAeriana;
            return this.AeroportAterizare.Equals(ruta.AeroportAterizare) &&
                this.AeroportDecolare.Equals(ruta.AeroportDecolare);
        }

        public override string ToString()
        {
            string ruta = AeroportDecolare.Oras;
            ruta += "(";
            if (AeroportDecolare.IATA == "\\N")
                ruta += AeroportDecolare.ICAO;
            else
                ruta += AeroportDecolare.IATA;
            ruta += ") - ";
            ruta += AeroportAterizare.Oras;
            ruta += "(";
            if (AeroportAterizare.IATA == "\\N")
                ruta += AeroportAterizare.ICAO;
            else
                ruta += AeroportAterizare.IATA;
            ruta += ")";
            return ruta;
        }

        public override int GetHashCode()
        {
            var hashCode = 1311214324;
            hashCode = hashCode * -1521134295 + EqualityComparer<Aeroport>.Default.GetHashCode(AeroportDecolare);
            hashCode = hashCode * -1521134295 + EqualityComparer<Aeroport>.Default.GetHashCode(AeroportAterizare);
            return hashCode;
        }
    }
}
