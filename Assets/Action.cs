using System;
using UnityEngine;

public abstract class Action: MonoBehaviour
{
    [field: SerializeField]
    public Conditions Preconditions { get; private set; }
    
    [field: SerializeField]
    public Conditions Postconditions { get; private set; }

    public abstract void Perform(Chef chef);
}