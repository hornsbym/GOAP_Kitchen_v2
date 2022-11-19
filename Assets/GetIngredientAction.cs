using UnityEngine;

public class GetIngredientAction: Action
{
    [SerializeField]
    Ingredient _ingredient;
    
    public float Cost { get; private set; }

    void Start()
    {
        Cost = 1;
    }

    public override string ToString()
    {
        return "GetIngredientAction<" + _ingredient.name + ">";
    }

    public bool SatisfiesCondition()
    {
        return true;
    }

    public override void Perform(Chef chef)
    {
        chef.Inventory = AddIngredient(chef.Inventory);
    }

    Inventory AddIngredient(Inventory inventory)
    {
        Inventory copy = new Inventory(inventory.Items);
        copy.Items[_ingredient.Type]++;
        return copy;
    }
}