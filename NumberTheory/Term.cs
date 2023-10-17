namespace CAM
{
  using System;
  using System . Collections . Generic;
  using System . Linq;
  using System . Text;
  using System . Threading . Tasks;

  public class Term
  {
    private Atom Nomial = new RationalNumber(1, 1);
    
    public void SetVariable(Variable variable)
    {
      this.Nomial = variable;
    }

    public void SetConstant(Constant constant)
    {
      this.Nomial = constant;
    }
  }
}
