namespace CAM
{
  using System;
  using System . Collections . Generic;
  using System . Linq;
  using System . Numerics;
  using System . Text;
  using System . Threading . Tasks;

  public class Constant : Atom
  {
    public bool Sum { get; set; } = false;
    public bool Product { get; set; } = false;
    public bool Quotient { get; set; } = false;
  }
}
