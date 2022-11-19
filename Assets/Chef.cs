using System.Collections.Generic;
using UnityEngine;

public class Chef : MonoBehaviour
{
    public Inventory Inventory { get; set; }

    [field: SerializeField]
    public List<Action> Actions { get; private set; }

    void Start()
    {
        Inventory = new Inventory();
    }
}
