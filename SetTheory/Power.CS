using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Power
{
    public static string [ ] Name = new string [ ] { "Power Set" };
    public static string [ ] Symbol = new string [ ] { "P" };
    public static string [ ] Formula = new string [ ] { "{0}({1})={{{2}}}" , "Power Set of {0}" };

    public static List<List<T>> Power<T>(List<T> A)
    {
        return from m in Enumerable.Range(0, 1 << A.Count)
            select
                from i in Enumerable.Range(0, A.Count)
                where (m & (1 << i)) != 0
                select A[i];
    }

    public static List<List<T>> Power<T> ( List<T> A )
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
}