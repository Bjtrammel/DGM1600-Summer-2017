using UnityEngine;
using System.Collections;

public class resetChicken : MonoBehaviour
{
    public Transform spawnPoint;

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Chicken")
        {
            other.transform.position = spawnPoint.position;
        }
    }
}