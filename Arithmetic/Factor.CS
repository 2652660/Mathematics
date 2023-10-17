namespace CAM
{
    using System;
    using System . Collections . Generic;
    using System . Linq;
    using System . Numerics;
    using System . Text;
    using System . Threading . Tasks;

    public class Factor : Constant
    {
        public static readonly string [ ] Name = new string [ ] { "Factor" };
        public static readonly string [ ] Element = new string [ ] { "Multiplier", "Multiplicand" };
        private DynamicSets<BigInteger> Value = new DynamicSets<BigInteger>();

        public Factor()
        {
            foreach(string Member in Element)
            {
                Value.AddSet(Member);
            }
        }

        public Product Product
        {
            get
            {
                Product product = new Product();
                product.Multiplier = this.Multiplier;
                product.Multiplicand = this.Multiplicand;
                return product.Product;
            }
        }

        public BigInteger Multiplicand
        {
            get
            {
                return GetFactor(Element.First());
            }
            set
            {
                SetFactor(Element.First(), value);
            }
        }

        public BigInteger Multiplier
        {
            get
            {
                return GetFactor(Element.Last());
            }
            set
            {
                SetFactor(Element.Last(), value);
            }
        }

        private BigInteger GetFactor(string Name, BigInteger? Default = null)
        {
            List<BigInteger> Factor = Value.GetSet(Name);
            if(Factor.Length.Equals(0))
            {
                return Default is null ? BigInteger.One : Default;
            }
            return Factor.Last();
        }

        private void SetFactor(string Name, BigInteger value)
        {
            Value.ClearSet();
            Value.AddElementToSet(Element.Last(), value);
        }
    }
}