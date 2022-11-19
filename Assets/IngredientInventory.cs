using System;
using System.Collections.Generic;

public class Inventory
{
    public enum Item
    {
        APPLE,
        SUGAR,
        FLOUR,
        APPLE_PIE
    }
    public Dictionary<Inventory.Item, int> Items { get; private set; }

    /// <summary>
    /// Used for creating a new, blank inventory.
    /// </summary>
    public Inventory()
    {
        Items = new Dictionary<Item, int>();
        foreach(Inventory.Item inventoryItem in Enum.GetValues(typeof(Inventory.Item)))
        {
            Items.Add(inventoryItem, 0);
        }
    }

    /// <summary>
    /// Used for cloning an exiting inventory.
    /// </summary>
    public Inventory(Dictionary<Inventory.Item, int> ingredients)
    {
        Items = ingredients;
    }
}
