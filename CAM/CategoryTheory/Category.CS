namespace CAM
{
  using System;
  using System . Collections . Generic;
  using System . Linq;
  using System . Numerics;
  using System . Text;
  using System . Threading . Tasks;
  public class Category : Atom
  {
    public static string [ ] Name = new string [ ] { "Category" };
    public static string [ ] Symbol = new string [ ] { "C" };
    public static string [ ] Formula = new string [ ] { };
    /*public Dictionary<string, List<object>>[] Entities = new Dictionary<string, List<object>>()
    {
        ["CompositionOfMorphisms"] = new List<CompositionOfMorphisms>(),
        ["Homomorphism"] = new List<Homomorphism>(),
        ["Object"] = new List<Object>()
    };*/

    public override string ToString ( )
    {
      return this.Value . ToString ( );
    } 
  }
}