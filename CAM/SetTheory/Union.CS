using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Union
{
    public static List<T> Union<T>(List<List<T>> Sets)
    {
        return Sets.SelectMany(Set => Set).ToList();
    }
}