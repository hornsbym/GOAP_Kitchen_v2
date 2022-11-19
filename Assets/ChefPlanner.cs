using System.Collections.Generic;
using UnityEngine;

public class ChefPlanner: MonoBehaviour
{
    Chef _chef;
    List<Action> _actions;

    void Start()
    {
        _chef = GetComponent<Chef>();
        _actions = _chef.Actions;

        Inventory targetInv = new Inventory();

        Plan(targetInv);
    }

    /// <summary>
    /// Starting from the goal, creates a tree until the preconditions of the action match the 
    /// Chef's actual state.
    /// 
    /// For example, consider a chef that currently has no ingredients in its inventory.
    /// 
    /// To bake an apple pie the chef will need 1 apple, 1 flour, and 1 sugar. 
    /// 
    /// This function begins at the state where the chef has the 1 apple, 1 flour, and 1 sugar and
    /// then work backwards, subtracting ingredients until the chef has 0 apples, 0 flour, and 0 sugar.
    /// 
    /// It stops here because this is the chef's current state, proving it's possible to get from the current state
    /// to the desired state. 
    ///
    /// The chef can then perform the actions which are chained together in order to navigate from the
    /// current state to the desire state.
    /// </summary>
    void Plan(Inventory targetInventory)
    {

    }
}