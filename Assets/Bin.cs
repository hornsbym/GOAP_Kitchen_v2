using System;
using System.Collections.Generic;
using UnityEngine;

public class Bin : MonoBehaviour
{
    [SerializeField] Ingredient _ingredient;
    [SerializeField] GameObject _model;
    [field: SerializeField] List<IngredientTypeMaterialPair> _ingredientMaterials;

    [Serializable]
    class IngredientTypeMaterialPair
    {
        [field: SerializeField]
        public Material Material { get; private set; }

        [field: SerializeField]
        public Inventory.Item IngredientType { get; private set; }
    }

    void Start()
    {
        ColorBinModel();
    }

    /// <summary>
    /// Changes the color of the bin based on the material contained within it.
    /// </summary>
    void ColorBinModel()
    {
        foreach(IngredientTypeMaterialPair pair in _ingredientMaterials)
        {
            if (_ingredient.Type == pair.IngredientType)
            {
                _model.GetComponent<MeshRenderer>().material = pair.Material;
                break;
            }
        }
    }
}
