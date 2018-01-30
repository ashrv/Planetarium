using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Inventory : MonoBehaviour {
    [SerializeField]GameObject slotPrefab;
    
    public IEnumerable<Slot> slots
    {
        get
        {
            return transform.GetComponentsInChildren<Slot>();
        }
    }
    private void OnValidate()
    {
        slotPrefab = Assets.prefabs.Get("Slot");
    }

    public void Add(Item item)
    {
        var slot = slots.FirstOrDefault(z => z.item.Equals(item))??slots.First(z => z.empty);
        slot.Add(item);

    }

}
