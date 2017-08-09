using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour
{
    public Transform spawnPoint;
    public int points;

    public string[] spawnPoints = { "spawnPoint", "spawnPoint1", "spawnPoint2", "spawnPoint3", "spawnPoint4", "spawnPoint5" };
    

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Player")
        {
            scoreManager.AddPoints(points);
            transform.position = spawnPoint.position;
            transform.rotation = spawnPoint.rotation;
        }
    }
}