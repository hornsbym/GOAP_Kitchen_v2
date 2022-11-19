using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Contains a set of conditions, in any scope.
/// This could be used for a local object, like a character,
/// or a shared resource, like a world state object.
/// </summary>
[Serializable]
public class Conditions
{
    [field: SerializeField]
    public List<Condition<bool>> Boolean { get; private set; }

    [field: SerializeField]
    public List<Condition<string>> String { get; private set; }

    [field: SerializeField]
    public List<Condition<float>> Float { get; private set; }

    [field: SerializeField]
    public List<Condition<int>> Integer { get; private set; }

    /// <summary>
    /// Used to create a clone.
    /// </summary>
    public Conditions(Conditions conditions)
    {
        Boolean = new List<Condition<bool>>(conditions.Boolean);
        String = new List<Condition<string>>(conditions.String);
        Float = new List<Condition<float>>(conditions.Float);
        Integer = new List<Condition<int>>(conditions.Integer);
    }
}