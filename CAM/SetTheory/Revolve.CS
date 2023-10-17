using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Revolve
{
    public static string [ ] Name = new string [ ] { "Revolve Set" };

    public static List<T> Revolve<T>(List<T> A, int Position, bool Toward = true)
    {
        int Count = A.Count;
        Position = Position % Count; // Handle rotation greater than list size
        if (Position < 0)
        {
            Position += count; // Handle negative rotation
        }
        List<T> revolvedList = new List<T>(Count);
        if(Toward)
        {
            revolvedList.AddRange(A.Skip(Count - Position));
            revolvedList.AddRange(A.Take(Count - Position));
        }
        else
        {
            revolvedList.AddRange(A.Skip(Position));
            revolvedList.AddRange(A.Take(Position));
        }
        return revolvedList;
    }
}