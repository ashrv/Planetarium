using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class BuildTree : MonoBehaviour
{
    [SerializeField] Inventory inventory;
    [SerializeField] GameObject categoryPrefab;
    List<Category> categories
    {
        get
        {
            return transform.GetComponentsInChildren<Category>().ToList();
        }
    }
    
    private void OnValidate()
    {
        inventory = FindObjectOfType<Inventory>();
        categoryPrefab = Assets.prefabs.Get("Category");
    }

    public void AddCategory(List<GameObject> crafts)
    {
        GameObject newCategory = Instantiate(categoryPrefab, transform);
        foreach (var craft in crafts)
        {
            var newCraft = Instantiate(categoryPrefab, newCategory.transform);
            craft.transform.parent = newCraft.transform;
        }
    }

    private void Start()
    {

    }

    internal void Update(Craftable content)
    {
        foreach (var child in content.children)
        {
            if (child.disabled)
            {
                child.disabled = false;
            }
        }
    }

    internal void Update(Item item)
    {
        
    }
}
