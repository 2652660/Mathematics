using System.Collections.Generic;

public class DynamicSets<T>
{
    private Dictionary<string, List<T>> sets;

    public DynamicSets()
    {
        sets = new Dictionary<string, List<T>>();
    }

    public void AddSet(string setName)
    {
        if (!sets.ContainsKey(setName))
        {
            sets[setName] = new List<T>();
        }
    }

    public void AddElementToSet(string setName, T element)
    {
        if (sets.ContainsKey(setName))
        {
            sets[setName].Add(element);
        }
    }

    public List<T> GetSet(string setName)
    {
        if (sets.ContainsKey(setName))
        {
            return sets[setName];
        }
        return null;
    }

    public void ClearSet(string setName)
    {
        sets[setName] = new List<T>();
    }
}