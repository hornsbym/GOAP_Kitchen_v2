using System;
using UnityEngine;

/// <summary>
/// Contains a tiny bit of state about the world.
/// Can be either local to an object, like a single chef, or 
/// communal world state.
/// </summary>
[Serializable]
public class Condition<T> where T: IComparable
{
    [field: SerializeField]
    public T State { get; private set; }

    public Condition(T state)
    {
        State = state;
    }

    /// <summary>
    /// Check a plain value against the condition value.
    /// </summary>
    public bool Matches(T conditionVal)
    {
        IComparable t = conditionVal as IComparable;
        IComparable s = State as IComparable;

        return t == s;
    }
}
