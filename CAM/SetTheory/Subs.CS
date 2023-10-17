using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Subs
{
    public static List<List<T>> Subs<T>(List<T> A)
    {
        var Subs = new List<List<T>>();
        for (int subMask = 0, subCount = (int)Math.Pow(2, A.Count); subMask < subCount; subMask++)
        {
            var Sub = new List<T>();
            int bitIndex = 0;
            foreach (T Element in A)
            {
                if ((subMask & (1 << bitIndex)) != 0)
                {
                    Sub.Add(Element);
                }
                bitIndex++;
            }
            Subs.Add(Sub);
        }
        return Subs;
    }
}