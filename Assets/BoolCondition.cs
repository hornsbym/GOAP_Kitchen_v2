using System;
using UnityEngine;

[Serializable]
public class BoolCondition
{
    [field: SerializeField]
    public bool Value { get; private set; }
}