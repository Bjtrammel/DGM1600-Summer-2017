using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{

    public const int maxHealth = 100;
    public int currentHealth = maxHealth;

    public Text hp;
    public Text maxHp;

    void Update()
    {
        hp.text = currentHealth.ToString();
        maxHp.text = maxHealth.ToString();
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            SceneManager.LoadScene(3); ;
        }
            
    }
}
