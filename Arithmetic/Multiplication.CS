namespace CAM
{
    using System;
    using System . Collections . Generic;
    using System . Linq;
    using System . Numerics;
    using System . Text;
    using System . Threading . Tasks;
    using CAM.SetTheory;

    public class Multiplication : BinaryOperation
    {
        public static string [ ] Name = new string [ ] { "Multiplication", "Multiply" };
        public static string [ ] Symbol = new string [ ] { "×", "⋅", "*" };
        public static string [ ] Formula = new string [ ] { "{0}×{1}", "{0}⋅{1}", "{0}*{1}" };
        private Factor factor = new Factor();

        public Product Product
        {
            get
            {
                return factor.Product;
            }
        }

        public BigInteger Multiplicand
        {
            get
            {
                return factor.Multiplicand;
            }
            set
            {
                factor.Multiplicand = value;
            }
        }

        public BigInteger Multiplier
        {
            get
            {
                return factor.Multiplier;
            }
            set
            {
                factor.Multiplier = value;
            }
        }

        public override string ToString ( )
        {
            return this.Value . ToString ( );
        }
    }
}