using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour
{
    //public Transform spawnPoint;
    //public GameObject player;

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.name == "Player")
    //    {
    //        Debug.Log("Hit Spawn Point");
    //        player.transform.position = spawnPoint.transform.position;
    //    }
    //}

    public Transform spawnPoint;

    public OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Player")
        {
            other.transform.position = spawnPoint.position;
            yield return new WaitForSecondsRealtime(3);
        }
    }
}