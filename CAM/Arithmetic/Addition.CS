namespace CAM
{
    using System;
    using System . Collections . Generic;
    using System . Linq;
    using System . Numerics;
    using System . Text;
    using System . Threading . Tasks;

    public class Addition : BinaryOperation
    {
        public static string [ ] Name = new string [ ] { "Addition", "Add" };
        public static string [ ] Symbol = new string [ ] { "+" };
        public static string [ ] Formula = new string [ ] { "{0}{1}{2}" };

        

        public override string ToString ( )
        {
            return this.Value . ToString ( );
        }
    }
}