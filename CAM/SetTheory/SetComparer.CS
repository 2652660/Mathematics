using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using CAM.SetTheory;

namespace CAM
{
    public class SetComparer<T> : IEqualityComparer<Set<T>>
    {
        public bool Equals(Set<T>? A, Set<T>? B)
        {
            if(A is not null && B is not null)
            {
                //return A.SetEquals(B);
            }
            return (A is null && B is null); // true is both Empty Set or False.
        }

        int IEqualityComparer<Set<T>>.GetHashCode(Set<T> A)
        {
            BigInteger hashCode = 0;
            foreach (T type in A)
            {
                hashCode ^= type!.GetHashCode();
            }
            return (int)hashCode;
        }
    }
}