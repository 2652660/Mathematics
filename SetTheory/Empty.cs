namespace CAM . SetTheory
{
  using System;
  using System . Collections . Generic;
  using System . Linq;
  using System . Runtime . CompilerServices;
  using System . Text;
  using System . Threading . Tasks;
  using System . Xml . Linq;

  public class Empty<T>
  {
    public static char [] Glyph {get; private set;} = new char[] { '∅', 'ϕ' };
    public static string [ ] Note { get; private set; } = new string [ ] { "{{}}" };
    public static string [ ] Name { get; private set; } = new string [ ] { "Empty Set", "Null Set" };
    
    public static bool IsEmpty<T>(List<T>? A)
    {
      return A == null || A.Length == 0;
    }
  }
}
