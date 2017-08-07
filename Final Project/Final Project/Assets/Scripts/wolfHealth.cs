using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class wolfHealth : MonoBehaviour
{

    public const int maxHealth = 15;
    public int currentHealth;
    public Text hpWolf;
    public int points;
    public Transform spawnPoint;

    void Update()
    {
        hpWolf.text = currentHealth.ToString();
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount; //keep score at zero
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            scoreManager.AddPoints(points); //add point for kill and respawn
            transform.position = spawnPoint.position;
            transform.rotation = spawnPoint.rotation;
            //reset health
            currentHealth = maxHealth;
         }

    }
}
