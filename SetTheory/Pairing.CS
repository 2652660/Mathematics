using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Pairing
{
    public static List<List<T>> Pairing<T>(List<T> A, List<T> B)
    {
        return new List<List<T>> { A, B };
    }
}