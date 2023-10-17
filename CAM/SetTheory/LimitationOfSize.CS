using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class LimitationOfSize
{
    public static bool IsOneToOneCorrespondence<T, U>(Dictionary<T, U> map)
    {
        return map.Keys.Count == map.Values.Distinct().Count();
    }
}