using UnityEngine;

public abstract class Ingredient : MonoBehaviour
{
    public abstract Inventory.Item Type { get; }
}