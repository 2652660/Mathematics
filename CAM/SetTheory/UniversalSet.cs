namespace CAM . SetTheory
{
  using System;
  using System . Collections . Generic;
  using System . Linq;
  using System . Text;
  using System . Threading . Tasks;

  public class UniversalSet<T>
  {
    public string [ ] Name = new string [ ] { "U", "ε" , "Universal Set" };
    public List<T> C { get; private set; } = new List<T> ( );

    public UniversalSet ( )
    {
      ComplimentOfSet<object , object>.Instance . Add ( this.GetType() , typeof(EmptySet<T>));
    }

    public List<T> Get ( List<T> A , List<T> B )
    {
      this.C = new List<T> ( );
      foreach ( T item in A.Concat(B) )
      {
        if( this . C .Contains(item) is false)
        {
          this . C . Add ( item );
        }
      }
      return this . C = this.C.Distinct().ToList();
    }
  }
}
