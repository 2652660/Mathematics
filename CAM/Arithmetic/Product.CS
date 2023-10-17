namespace CAM
{
    using System;
    using System . Collections . Generic;
    using System . Linq;
    using System . Numerics;
    using System . Text;
    using System . Threading . Tasks;

    public class Product : Factor
    {
        public static readonly string [ ] Name = new string [ ] { "Product" };

        public Product()
        {
            
        }

        public BigInteger Value
        {
            get
            {
                BigInteger value = BigInteger.Zero;
                for(int i = 0;i<this.Multiplier;i++)
                {
                    value += this.Multiplicand;
                }
                return value;
            }
        }

        public BigInteger Multiplicand
        {
            get
            {
                return base.Multiplicand;
            }
            set
            {
                base.Multiplicand = value;
            }
        }

        public BigInteger Multiplier
        {
            get
            {
                return base.Multiplier;
            }
            set
            {
                base.Multiplier = value;
            }
        }
    }
}