using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour
{
    public Transform spawnPoint;

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Player")
        {
            transform.position = spawnPoint.position;
        }
    }
}