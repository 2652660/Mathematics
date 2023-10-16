namespace CAM . SetTheory
{
  using System;
  using System . Collections . Generic;
  using System . Linq;
  using System . Text;
  using System . Threading . Tasks;

  public class SubSet
  {
    public string [ ] Name = new string [ ] { "Subset" };
    public string [ ] Symbol = new string [ ] { "⊂", "⊆" };
    public string [ ] Formula = new string [ ] { "{0}({1},{2})={{{3}}}" , "{0}({1},{2})={{{3}}}" };
    public List<List<object>> C { get; private set; } = new List<List<object>> ( );

    public SubSet ( )
    {
      ComplimentOfSet<object , object> . Instance . Add ( this . GetType ( ) , typeof ( EmptySet<HashSet<object>> ) );
    }

    public override string ToString ( )
    {
      return this . ToString ( 0 );
    }

    public string ToString ( int Index = 0 , string? Name = null , List<object>? Set = null , List<object>? SubSet = null )
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
      if(SubSet is null)
      {
        SubSet = new List<object>();
      }
      return FormattableStringFactory . Create ( Formula [ Index ] , Name , string . Join ( "," , Set ) , string . Join ( "," , SubSet ) ) . ToString ( );
    }
  }
}
