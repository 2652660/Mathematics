namespace CAM
{
    using System;
    using System . Collections . Generic;
    using System . Linq;
    using System . Numerics;
    using System . Text;
    using System . Threading . Tasks;
    using U.C;

    public class CompositionOfMorphisms : BinaryOperation
    {
        public static string [ ] Name = new string [ ] { "Composition Of Morphisms" };
        public static string [ ] Symbol = new string [ ] { "∘" };
        public static string [ ] Formula = new string [ ] { };

        public override string ToString ( )
        {
            return this.Value . ToString ( );
        } 
    }
}