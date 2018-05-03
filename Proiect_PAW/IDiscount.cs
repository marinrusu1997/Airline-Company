using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Proiect_PAW
{
    delegate float ApplyDiscount(float suma);

    public class IDiscountComparer : IEqualityComparer<IDiscount>
    {
        public bool Equals(IDiscount x, IDiscount y)
        {
            return x.Equals(y);
        }

        public int GetHashCode(IDiscount obj)
        {
            return obj.GetHashCode();
        }
    }
    public interface IDiscount : ICloneable, IComparable
    {
        float ApplyDiscount(Rezervare rezervare, Zbor zbor);
    }

    public abstract class DiscountGeneric : IDiscount, IEquatable<DiscountGeneric>
    {

        protected float procentDiscount;
        public float ProcentDiscount
        {
            get { return procentDiscount; }
            set
            {
                if (value >= 0 && value <= 1)
                    procentDiscount = value;
            }
        }

        public DiscountGeneric()
        {
            procentDiscount = 0;
        }
        public DiscountGeneric(float discount)
        {
            this.ProcentDiscount = discount;
        }
        public virtual float ApplyDiscount(Rezervare rezervare, Zbor zbor)
        {
            if (rezervare == null || zbor == null)
                throw new ArgumentNullException();
            else
                return Discount(rezervare, zbor);
        }
        protected abstract float Discount(Rezervare rezervare, Zbor zbor);
        public virtual int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            DiscountGeneric discount = obj as DiscountGeneric;
            if (discount != null)
            {
                if (this.procentDiscount > discount.procentDiscount)
                    return 1;
                else if (this.procentDiscount < discount.procentDiscount)
                    return -1;
                else
                    return 0;
            }
            else
                throw new ArgumentException("Object is not an " + this.GetType().ToString());
        }
        public override string ToString()
        {
            return (procentDiscount * 100).ToString() + "%";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            DiscountGeneric discountGeneric = (DiscountGeneric)obj;
            return this.procentDiscount == discountGeneric.procentDiscount;
        }

        public override int GetHashCode()
        {
            return 1921137113 + procentDiscount.GetHashCode();
        }

        public bool Equals(DiscountGeneric other)
        {
            return this.Equals((object)other);
        }

        public virtual object Clone()
        {
            return this.MemberwiseClone();
        }

        public virtual void CopyDiscount(IDiscount discount)
        {
            if (discount is DiscountGeneric)
                this.procentDiscount = ((DiscountGeneric)discount).procentDiscount;
        }

        public static float? operator +(DiscountGeneric discount, float procentDiscount)
        {
            if (discount == null)
                return null;
            discount.ProcentDiscount += procentDiscount;
            return discount.ProcentDiscount;
        }
        public static float? operator -(DiscountGeneric discount, float procentDiscount)
        {
            if (discount == null)
                return null;
            discount.ProcentDiscount -= procentDiscount;
            return discount.ProcentDiscount;
        }
    }

    public class DiscountNrBilete : DiscountGeneric
    {
        public DiscountNrBilete(float discount) : base(discount)
        {
        }

        public override float ApplyDiscount(Rezervare rezervare, Zbor zbor)
        {
            return base.ApplyDiscount(rezervare, zbor);
        }
        protected override float Discount(Rezervare rezervare, Zbor zbor)
        {
            var sumaDeDecontat = zbor.Cost;
            for (int i = 1; i <= rezervare.NumarBilete; i++)
            {
                if (i == 1)
                    sumaDeDecontat -= sumaDeDecontat * procentDiscount;
                else
                    sumaDeDecontat -= sumaDeDecontat * (procentDiscount / i);
            }
            return sumaDeDecontat;
        }
        public override int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            DiscountNrBilete discount = obj as DiscountNrBilete;
            if (discount != null)
            {
                return base.CompareTo(obj);
            }
            else
                throw new ArgumentException("Object is not an " + this.GetType().ToString());

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
            else
                return true;
        }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }
        public override string ToString()
        {
            return this.GetType().ToString().Remove(0, 12) + " => " + base.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void CopyDiscount(IDiscount discount)
        {
            if(discount is DiscountNrBilete)
            {
                base.CopyDiscount(discount);
            }
        }

        public static DiscountNrBilete operator +(DiscountNrBilete discount, float procentDiscount)
        {
            if (discount == null)
                return discount;
            discount.ProcentDiscount += procentDiscount;
            return discount;
        }
        public static DiscountNrBilete operator -(DiscountNrBilete discount, float procentDiscount)
        {
            if (discount == null)
                return discount;
            discount.ProcentDiscount -= procentDiscount;
            return discount;
        }

        public static explicit operator float(DiscountNrBilete discount)
        {
            if (discount == null)
                return 0.0f;
            else
                return discount.procentDiscount;
        }
    }

    public class DiscountSpecific : DiscountGeneric
    {
        public enum MotivDiscount { CLIENT, ANIVERSARE, SARBATOARE, PERIOADA };

        private MotivDiscount motivDiscount;
        private DateTime dataInceput;
        private TimeSpan durata;
        private float sumaAditionala;

        public float SumaAditionala
        {
            get { return sumaAditionala; }
            set { if (value >= 0) sumaAditionala = value; }
        }
        public MotivDiscount MotivulDiscountului
        {
            get { return motivDiscount; }
            set { motivDiscount = value; }
        }
        public DateTime DataInceput
        {
            get { return dataInceput; }
        }
        public DateTime DataSfirsit
        {
            get { return dataInceput + durata; }
        }
        public TimeSpan Durata
        {
            get
            {
                return durata;
            }
        }
        public DiscountSpecific(MotivDiscount motiv, DateTime dataInceput, TimeSpan durata,
            float sumaAditionala, float procentDiscount) : base(procentDiscount)
        {
            this.motivDiscount = motiv;
            this.dataInceput = dataInceput;
            this.durata = durata;
            this.SumaAditionala = sumaAditionala;
        }
        public override float ApplyDiscount(Rezervare rezervare, Zbor zbor)
        {
            return base.ApplyDiscount(rezervare, zbor);
        }
        protected override float Discount(Rezervare rezervare, Zbor zbor)
        {
            if (this.motivDiscount == MotivDiscount.CLIENT && !rezervare.Rezervant.EsteClient)
                return zbor.Cost;
            float SumaDeDecontat = zbor.Cost;
            if (zbor.TimpDecolare >= dataInceput && zbor.TimpDecolare <= dataInceput + durata)
            {
                SumaDeDecontat -= SumaDeDecontat * procentDiscount;
                SumaDeDecontat -= sumaAditionala;
            }
            return SumaDeDecontat;
        }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }
        public override int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            DiscountSpecific temp = obj as DiscountSpecific;
            if (temp != null)
            {
                int baseCompare = base.CompareTo(obj);
                if (baseCompare != 0)
                    return baseCompare;
                else if (this.sumaAditionala > temp.sumaAditionala)
                    return 1;
                else if (this.sumaAditionala < temp.sumaAditionala)
                    return -1;
                else if (this.dataInceput + this.durata > temp.dataInceput + temp.durata)
                    return 1;
                else if (this.dataInceput + this.durata < temp.dataInceput + temp.durata)
                    return -1;
                else
                    return this.motivDiscount.CompareTo(temp.motivDiscount);
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
            DiscountSpecific discount = obj as DiscountSpecific;
            return this.dataInceput == discount.dataInceput && this.motivDiscount == discount.motivDiscount
                && this.durata == discount.durata && this.sumaAditionala == discount.sumaAditionala;
        }
        public override string ToString()
        {
            return this.GetType().ToString().Remove(0, 12) + " (" + motivDiscount + ") " + DataInceput + " - " + DataSfirsit +
                " => " + base.ToString();
        }

        public override int GetHashCode()
        {
            var hashCode = -1174331891;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + motivDiscount.GetHashCode();
            hashCode = hashCode * -1521134295 + dataInceput.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<TimeSpan>.Default.GetHashCode(durata);
            hashCode = hashCode * -1521134295 + sumaAditionala.GetHashCode();
            hashCode = hashCode * -1521134295 + SumaAditionala.GetHashCode();
            hashCode = hashCode * -1521134295 + MotivulDiscountului.GetHashCode();
            hashCode = hashCode * -1521134295 + DataInceput.GetHashCode();
            hashCode = hashCode * -1521134295 + DataSfirsit.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<TimeSpan>.Default.GetHashCode(Durata);
            return hashCode;
        }

        public override void CopyDiscount(IDiscount Idiscount)
        {
            if(Idiscount is DiscountSpecific)
            {
                base.CopyDiscount(Idiscount);
                var discount = Idiscount as DiscountSpecific;
                this.sumaAditionala = discount.sumaAditionala;
                this.motivDiscount = discount.motivDiscount;
                this.dataInceput = discount.dataInceput;
                this.durata = discount.durata;
            }
        }

        public static DiscountSpecific operator -(DiscountSpecific discount, float procentDiscount)
        {
            discount.ProcentDiscount -= procentDiscount;
            return discount;
        }
        public static DiscountSpecific operator +(DiscountSpecific discount, float procentDiscount)
        {
            discount.ProcentDiscount += procentDiscount;
            return discount;
        }
    }

    public class DiscountManager : IDiscount
    {
        private float discountMaxim;
        private IList<IDiscount> discounts = null;
        public float ProcentDiscountMaxim
        {
            get { return discountMaxim; }
            set
            {
                if (value >= 0 && value <= 1)
                    discountMaxim = value;
            }
        }
        public IList<IDiscount> Discounts
        {
            get { return discounts; }
            set
            {
                if (value != null)
                    discounts = value;
            }
        }

        private static bool isDeletingDone = false;

        public DiscountManager(float procentDiscountMaxim, List<IDiscount> discounts)
        {
            this.discountMaxim = procentDiscountMaxim;
            this.discounts = discounts;
        }
        public DiscountManager(float procentDiscountMaxim)
        {
            discountMaxim = 0;
            ProcentDiscountMaxim = procentDiscountMaxim;
            discounts = new List<IDiscount>();
        }

        [JsonConstructor]
        public DiscountManager(float procentDiscountMaxim, IList<IDiscount> discounts) : this(procentDiscountMaxim)
        {
            if (discounts != null)
                foreach (IDiscount discount in discounts)
                {
                    this.discounts.Add((IDiscount)discount.Clone());
                }
        }

        public float ApplyDiscount(Rezervare rezervare, Zbor zbor)
        {
            float sumaMinima = zbor.Cost - zbor.Cost * discountMaxim;
            var zborCopie = (Zbor)zbor.Clone();
            var rezervareCopie = (Rezervare)rezervare.Clone();
            foreach (IDiscount discount in discounts)
            {
                zborCopie.Cost = discount.ApplyDiscount(rezervareCopie, zborCopie);
            }
            if (zborCopie.Cost < sumaMinima)
                return sumaMinima;
            else
                return zborCopie.Cost;
        }

        public object Clone()
        {
            var clone = (DiscountManager)this.MemberwiseClone();
            IList<IDiscount> discounts = (IList<IDiscount>)Activator.CreateInstance(this.discounts.GetType());
            foreach (var discount in this.discounts)
            {
                discounts.Add((IDiscount)discount.Clone());
            }
            clone.Discounts = discounts;
            return clone;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            var DiscountManager = obj as DiscountManager;
            if (DiscountManager != null)
            {
                if (this.discountMaxim > DiscountManager.discountMaxim)
                    return 1;
                else if (this.discountMaxim < DiscountManager.discountMaxim)
                    return -1;
                else if (this.discounts.Count > DiscountManager.discounts.Count)
                    return 1;
                else if (this.discounts.Count < DiscountManager.discounts.Count)
                    return -1;
                else
                    return 0;
            }
            else
                throw new ArgumentException("Object is not a " + this.GetType());
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
            var DiscountManager = obj as DiscountManager;
            int matches = 0;
            if (this.discounts.Count == DiscountManager.discounts.Count)
            {
                for (int i = 0; i < this.discounts.Count; i++)
                    if (this.discounts[i].Equals(DiscountManager.discounts[i]))
                        matches++;
            }
            else
                return false;
            return matches == this.discounts.Count && this.discountMaxim == DiscountManager.discountMaxim;
        }

        public override int GetHashCode()
        {
            var hashCode = -1112581239;
            hashCode = hashCode * -1521134295 + discountMaxim.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<IList<IDiscount>>.Default.GetHashCode(discounts);
            hashCode = hashCode * -1521134295 + ProcentDiscountMaxim.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<IList<IDiscount>>.Default.GetHashCode(Discounts);
            return hashCode;
        }

        public IDiscount this[int index]
        {
            get
            {
                return this.discounts[index];
            }
        }

        public override string ToString()
        {
            return this.GetType().ToString().Remove(0, 12) + " Procent Maxim : " + (ProcentDiscountMaxim * 100).ToString() + "%";
        }

        public bool StergeDiscount(IDiscount Idiscount)
        {
            foreach (var discount in discounts)
            {
                isDeletingDone = false;
                if (discount.Equals(Idiscount))
                {
                    this.discounts.Remove(Idiscount);
                    isDeletingDone = true;
                    return isDeletingDone;
                }
                if(discount.GetType() == typeof(DiscountManager))
                {
                    ((DiscountManager)discount).StergeDiscount(Idiscount);
                }
                if (isDeletingDone)
                    return isDeletingDone;
            }
            return false;
        }
    }

}
