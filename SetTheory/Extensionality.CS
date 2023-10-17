using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Extensionality
{
    public static bool AreEqual<T>(List<T> A, List<T> B)
    {
        return A.SetEquals(B);
    }

    public static bool Is<T>(List<T> A, List<T> B)
    {
        bool areEqual = AreEqual(A, B);
        return A.SequenceEqual(B) && areEqual;
    }
}