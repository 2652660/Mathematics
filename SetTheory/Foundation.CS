using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Foundation
{
    public static T FindDisjointMember<T>(List<T> A)
    {
        foreach (var member in A)
        {
            // Assuming that 'member' is also a set represented as HashSet<T>
            if (member is List<T> memberSet)
            {
                if (!A.Overlaps(memberSet))
                {
                    return member;
                }
            }
            else
            {
                // If 'member' is not a set, it is disjoint from 'setA'
                return member;
            }
        }
        return default(T);
    }
}