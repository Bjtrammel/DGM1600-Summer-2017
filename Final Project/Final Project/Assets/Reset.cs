using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour
{
    public Transform spawnPoint;

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Player")
        {
            other.transform.position = spawnPoint.position;
        }
    }
}