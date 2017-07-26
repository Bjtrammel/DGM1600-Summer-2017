using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class wolfHealth : MonoBehaviour
{

    public const int maxHealth = 100;
    public int currentHealth = maxHealth;

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            print("The Wolf is Dead! Good Job!");
        }

    }
}
