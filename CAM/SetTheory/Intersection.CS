using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Intersection
{
    public static List<T> Intersection<T>(List<T> A, List<T> B)
    {
        List<List> intersection = new List<List>(A);
        intersection.IntersectWith(B);
        return intersection.ToList();
    }
}