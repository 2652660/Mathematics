namespace CAM . SetTheory
{
  using System;
  using System . Collections . Generic;
  using System . Linq;
  using System . Text;
  using System . Threading . Tasks;

  public class Universal<T>
  {
    public static string [ ] Name = new string [ ] { "Universal Set" };
    public static string [ ] Symbol = new string [ ] { "U", "ε" };

    public static List<T> Universal ( List<T> A , List<T> B )
    {
      List<T> C = new List<T> ( );
      foreach ( T item in A.Concat(B) )
      {
        if( C .Contains(item) is false)
        {
          C . Add ( item );
        }
      }
      return this.C.Distinct().ToList();
    }
  }
}
