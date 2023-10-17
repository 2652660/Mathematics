namespace CAM
{
  using System;
  using System . Collections . Generic;
  using System . Linq;
  using System . Text;
  using System . Threading . Tasks;

  public class Unit<TKey, TTag> where TKey : notnull where TTag : notnull
  {
    public Dictionary<TKey , TTag> Foreword { get; set; } = new Dictionary<TKey , TTag> ( );
    public Dictionary<TTag , TKey> Backward { get; set; } = new Dictionary<TTag , TKey> ( );

    public static Unit<TKey, TTag>? instance;

    public Unit ( ) { }

    public static Unit<TKey , TTag> Instance
    {
      get
      {
        if ( instance == null )
        {
          instance = new Unit<TKey , TTag> ( );
        }
        return instance;
      }
    }

    public void Add ( TKey key , TTag tag )
    {
      if ( this . Foreword . ContainsKey ( key ) || this . Backward . ContainsKey ( tag ) )
      {
        throw new ArgumentException ( "Duplicate Key/Tag Pairing." );
      }
      this . Foreword . Add ( key , tag );
      this . Backward . Add ( tag , key );
    }

    public bool TryGetTag ( TKey key , out TTag tag )
    {
      return this . Foreword . TryGetValue ( key , out tag! );
    }

    public bool TryGetKey ( TTag tag , out TKey key )
    {
      return this . Backward . TryGetValue ( tag , out key! );
    }
  }
}
