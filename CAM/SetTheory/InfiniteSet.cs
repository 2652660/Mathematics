namespace CAM . SetTheory
{
  using System;
  using System . Collections . Generic;
  using System . Linq;
  using System . Runtime . CompilerServices;
  using System . Text;
  using System . Threading . Tasks;

  public class InfiniteSet<T>
  {
    public string [ ] Name = new string [ ] { "Infinite Set" };
    public string [ ] Symbol = new string [ ] { "Infinite Set" };
    public string [ ] Formula = new string [ ] { "{0}({1})={{{2}}}" , "Infinite Set of {0}" };
    public List<List<object>> C { get; private set; } = new List<List<object>> ( );

    public InfiniteSet ( )
    {
      ComplimentOfSet<object , object> . Instance . Add ( this . GetType ( ) , typeof ( FiniteSet<T> ) );
    }

    public override string ToString ( )
    {
      return this . ToString ( 0 );
    }

    public string ToString ( int Index = 0 , string? Name = null , List<object>? Set = null )
    {
      if ( Index < 0 || (Index > Formula . LongLength || Index > Variable.Name.LongLength) )
      {
        Index = 0;
      }     
      if ( Name is null)
      {
        Name = Variable . Name [Index];
      }
      if(Set is null)
      {
        Set = new List<object>();
      }
      return FormattableStringFactory . Create ( Formula [ Index ] , Name , string . Join ( "," , Set ) ) . ToString ( );
    }
  }
}
