namespace CAM . SetTheory
{
  using System;
  using System . Collections . Generic;
  using System . Linq;
  using System . Runtime . CompilerServices;
  using System . Text;
  using System . Threading . Tasks;

  public class PowerSet<T>
  {
    public string [ ] Name = new string [ ] { "P", "Power Set" };
    public string [ ] Symbol = new string [ ] { "P" };
    public string [ ] Formula = new string [ ] { "{0}({1})={{{2}}}" , "Power Set of {0}" };
    public List<List<T>> C { get; private set; } = new List<List<T>> ( );

    public PowerSet ( )
    {
      ComplimentOfSet<object , object> . Instance . Add ( this . GetType ( ) , typeof ( EmptySet<HashSet<object>> ) );
    }

    public List<List<T>> Get<T> ( List<T> A )
    {
      List<List<T>>? powerSet = new List<List<T>>();
      if ( A . Count == 0 )
      {
        powerSet . Add ( new List<T> ( ) );
        return powerSet;
      }

      T? element = A[0];
      List<T>? remainingSet = A.Skip(1).ToList();
      List<List<T>>? remainingPowerSet = this.Get(remainingSet);

      foreach ( List<T> subset in remainingPowerSet )
      {
        powerSet . Add ( new List<T> ( subset ) );
        subset . Add ( element );
        powerSet . Add ( new List<T> ( subset ) );
      }

      return powerSet;
    }

    public override string ToString ( )
    {
      return this . ToString ( 0 );
    }

    public string ToString ( int Index = 0 , string? Name = null , List<T>? Set = null )
    {
      if ( Index < 0 || (Index > Formula . LongLength || Index > Variable.Name.LongLength) )
      {
        Index = 0;
      }
      if ( Name is null)
      {
        Name = Variable.Name[Index];
      }
      if(Set is null)
      {
        Set = EmptySet<T>.Value;
      }
      return FormattableStringFactory . Create (
        EmptySet<T> . Formula [ Index ] . ToString ( ),
        Symbol [Index],
        Name,
        Set
      ) . ToString ( );
    }
  }
}
