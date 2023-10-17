using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Inductive
{
    public static bool IsInductive<T>(List<List<T>> set)
    {
        // Check if the set contains the empty set
        if (!set.Contains(new List<T>()))
        {
            return false;
        }
        // Check if for every element in the set, the successor of that element is also in the set
        foreach (var element in set)
        {
            var successor = new List<T>(element);
            successor.Add(element.First());
            if (!set.Contains(successor))
            {
                return false;
            }
        }
        return true;
    }
}