using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public ItemSO item;
    public int amount = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        { 
            Inventory inventory = other.GetComponent<Inventory>();

            if (inventory)
            {
                inventory.AddItem(item, amount);
                Destroy(gameObject);
            }
        }

    }
}
