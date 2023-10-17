using System.Collections.Generic;
using System.Linq;

public class Bijection
{
    public static bool IsBijection<TKey, TValue>(Dictionary<TKey, TValue> A)
    {
        // Check if all values are unique
        return A.Values.Distinct().Count() == A.Values.Count();
    }
}