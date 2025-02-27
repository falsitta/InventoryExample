using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth;
    public Image healthBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = currentHealth / maxHealth;
    }
}
