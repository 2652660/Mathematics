using System;
using System.Collections;
using System . Collections . Generic;
using System . Linq;
using System.Numerics;
using System . Text;
using System . Threading . Tasks;


namespace CAM
{
  public class Set<T>
  {
    private class Element
    {
      private Element? tail {get; set;} = null;
      private T value {get; set;} = default(T)!;

      public Element(T Data)
      {
        this.Value = Data;
      }

      public Element? Tail
      {
        get { return tail; }
        set { this.tail = value; }
      }

      public T Value
      {
        get { return value; }
        set { this.value = value; }
      }
    }

    public static readonly string [ ] Name = new string [ ] { "Generic Set", "Set" };
    private BigInteger count = BigInteger.Zero;
    private Element? head {get; set;} = null;

    public T this[BigInteger index]
    {
        get
        {
            var node = this.head;
            for (BigInteger i = 0; i < index && node is not null; i++)
            {
              node = node.Tail;
            }
            if (node is null)
            {
              throw new IndexOutOfRangeException();
            }
            return node.Value;
        }
        set
        {
            var node = this.head;
            for (BigInteger i = 0; i < index && node is not null; i++)
            {
              node = node.Tail;
            }
            if (node is null)
            {
              throw new IndexOutOfRangeException();
            }
            node.Value = value;
        }
    }

    public Set()
    {
      Set<BigInteger> t = new Set<BigInteger>();
      t.Add(BigInteger.Zero);
      foreach(BigInteger a in t)
      {
        
      }
    }

    public IEnumerator<T> GetEnumerator()
    {
      Element? current = this.head;
      while (current != null)
      {
        yield return current.Value;
        current = current.Tail;
      }
    }

    public BigInteger Count
    {
      get
      {
        return count;
      }
    }

    public bool Add(T member)
    {
      try
      {
        Element element = new Element(member);
        element.Tail = this.head;
        this.head = element;
        this.count += BigInteger.One;
        return true;
      }
      catch { }
      return false;
    }

    public void Clear()
    {
      this.head = null;
    }

    public bool Contains(T item)
    {
      foreach(T member in this)
      {
        if(member is not null && member.Equals(item))
        {
          return true;
        }
      }
      return false;
    }
  }
}