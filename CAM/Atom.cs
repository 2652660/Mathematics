namespace CAM
{
  using System;
  using System . Collections . Generic;
  using System . Linq;
  using System . Numerics;
  using System . Text;
  using System . Threading . Tasks;

  public class Atom
  {
    public static string [ ] Name = new string [ ] { "A" , "Atom" };
    public BigInteger Value { get; set; } = BigInteger .Zero;

    public override string ToString ( )
    {
      return this.Value . ToString ( );
    } 
  }
}
