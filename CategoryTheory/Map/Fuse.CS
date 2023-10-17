namespace CAM
{
  using System;
  using System . Collections . Generic;
  using System . Linq;
    using System.Numerics;
    using System . Text;
  using System . Threading . Tasks;

  public class Fuse
  {
    public BigInteger Identifier = BigInteger.MinusOne;
    private Dictionary<string, BigInteger> isDictionary = new Dictionary<string, BigInteger>();
    private Dictionary<BigInteger, List<BigInteger>> asDictionary = new Dictionary<BigInteger, List<BigInteger>>();

    public static Fuse? instance;

    public Fuse ( ) { }

    public static Fuse Instance
    {
      get
      {
        if ( instance == null )
        {
          instance = new Fuse( );
        }
        return instance;
      }
    }

    public BigInteger Identify(string name)
    {
        if(this.Entity.ContainsKey(name) is false)
        {
            try
            {
                this.Identifier += BigInteger.One;
                this.isDictionary.Add(name, this.Identifier);
                return this.Identifier;
            }
            catch { }
        }
        return this.Entity[name];
    }

    public string Identify(BigInteger key)
    {
        if(this.isDictionary.ContainsValue(key))
        {
            try
            {
                return this.isDictionary.Where(i => i.Value == key).ToArray().First().Key;
            }
            catch { }
        }
        return string.Empty;
    }

    public void Identify(string name, string value, bool bidirectional = false)
    {
        BigInteger idName = this.Identify(name);
        BigInteger idValue = this.Identify(value);
        if(this.asDictionary.ContainsKey(idName) is false)
        {
            try
            {
                this.asDictionary.Add(idName, new List<BigInteger>() { idValue });
            }
            catch { }
        }
        else
        {
            try
            {
                this.asDictionary[idName].Add(idValue);
            }
            catch { }
        }
        if(!bidirectional)
        {
            this.Identify(value, name, true);
        }
    }

    public void Add(string name, params string[] values)
    {
        foreach(string value in values)
        {
          this.Identify(name, value);
          this.Identify(value, name);
        }
    }

    public void Add(string[] names, params string[][] element)
    {
      foreach(string name in names)
      {
        foreach(string[] members in element)
        {
          foreach (string member in members)
          {
            this.Identify(name, member);
            this.Identify(member, name);
          }
        }
      }
    }

    public List<BigInteger> IdSet()
    {
        return this.isDictionary.Values.ToList();
    }

    public List<string> NameSet()
    {
        return this.isDictionary.Keys.ToList();
    }

    public List<string> KeyNameSet()
    {
        return this.asDictionary.Keys.Select(i => this.Identify(i)).ToList();
    }

    public List<string> TagNameSet()
    {
        return this.asDictionary.Values.Select(i => this.Identify(i)).ToList();
    }

    public List<string> KeyNamedSet(string name)
    {
        List<string> KeyNamedSet = new ();
        BigInteger idName = this.Identify(name);
        if(this.asDictionary.ContainsKey(idName))
        {
          KeyNamedSet = this.asDictionary[idName].Select(i => this.Identify(i)).ToList();
        }
        return KeyNamedSet.Distinct().ToList();
    }

    public List<string> AdjacentNamedSet(string name)
    {
        List<string> KeyNamedSet = this.KeyNamedSet(name);
        List<string> AdjacentNamedSet = new List<string>();
        foreach(string KeyNamed in KeyNamedSet)
        {
          AdjacentNamedSet = AdjacentNamedSet.Concat(this.KeyNamedSet(name));
        }
        return AdjacentNamedSet.Except(KeyNamedSet).Distinct().ToList();
    }
  }
}
