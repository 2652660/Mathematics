using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Difference
{
    public static List<T> Difference<T>(List<T> A, List<T> B)
    {
        List<T> difference = new List<T>(A);
        difference.ExceptWith(B);
        return difference.ToList();
    }
}