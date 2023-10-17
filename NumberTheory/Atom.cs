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
    public static string [ ] Name = new string [ ] { "Atom" };
    public static string [ ] Symbol = new string [ ] { "A" };
    public static string [ ] Formula = new string [ ] { "{0}{1}" };
    public BigInteger Value { get; set; } = BigInteger.Zero;

    public override string ToString ( )
    {
      return FormattableStringFactory.Format(Formula.First(), this.Value.Sign, this . Value);
    } 
  }
}
