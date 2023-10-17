namespace CAM . SetTheory
{
  using System;
  using System . Collections . Generic;
  using System . Linq;
  using System . Runtime . CompilerServices;
  using System . Text;
  using System . Threading . Tasks;

  public class Finite<T> : List<T>
  {
    public string [ ] Name = new string [ ] { "Finite Set" };
    private int Maximum;

    public Finite(int Maximum)
    {
        this.Maximum = Maximum;
    }

    public new void Add(TKey key, TValue value)
    {
        if (base.Count >= Maximum)
        {
            throw new InvalidOperationException("Limit Maximum of Set Reached.");
        }
        base.Add(key, value);
    }
  }
}
