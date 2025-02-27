using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class InventoryUI : MonoBehaviour
{
    public Inventory inventory;
    public Transform inventoryPanel;
    public GameObject inventorySlotPrefab;

    private List<GameObject> slots = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inventory = FindFirstObjectByType<Inventory>();
        inventory.onInventoryUpdated += UpdateUI;
    }

    private void OnDisable()
    {
        inventory.onInventoryUpdated -= UpdateUI;
    }

    private void UpdateUI()
    {
        //clear old slots out
        foreach (var slot in slots)
        {
            Destroy(slot);
        }
            slots.Clear();
        // create new slots from dictionary
        foreach (KeyValuePair<ItemSO, int> entry in inventory.items)
        {
            GameObject newSlot = Instantiate(inventorySlotPrefab, inventoryPanel);
            //populate UI info here
            newSlot.GetComponent<InventorySlotUI>().nameText.text = entry.Key.itemName;
            newSlot.GetComponent<InventorySlotUI>().descriptionText.text = entry.Key.itemDescription;
            newSlot.GetComponent<InventorySlotUI>().itemAmountText.text = entry.Value.ToString();
            newSlot.GetComponent<InventorySlotUI>().icon.sprite = entry.Key.icon;
            slots.Add(newSlot);
        }

    }
}
