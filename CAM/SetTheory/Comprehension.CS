using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Comprehension
{
    public static List<T> ComprehensionSet<T>(List<T> Set, Func<T, bool> Predicate)
    {
        return new List<T>(Set.Where(Predicate));
    }
}