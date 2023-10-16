namespace CAM . SetTheory
{
  using System;
  using System . Collections . Generic;
  using System . Linq;
  using System . Runtime . CompilerServices;
  using System . Text;
  using System . Threading . Tasks;
  using System . Xml . Linq;

  public class EmptySet<T>
  {
    public static string [ ] Name { get; private set; } = new string [ ] { "Empty Set", "Null Set" };
    public static string [ ] Formula { get; private set; } = new string [ ] { "{{}}" , "ϕ" , "∅" };
    public static List<T> Value { get; private set; } = new List<T> ( );

    public EmptySet ( )
    {
      ComplimentOfSet<object , object>.Instance . Add ( this.GetType() , typeof(UniversalSet<T>));
    }

    public override string ToString ( )
    {
      return this . ToString ( 0 );
    }

    public string ToString ( int Index = 0 )
    {
      if( Index < 0 || Index > Formula . LongLength )
      {
        Index = 0;
      }
      return FormattableStringFactory . Create ( EmptySet < T > . Formula [ Index ].ToString() ) . ToString ( );
    }
  }
}
