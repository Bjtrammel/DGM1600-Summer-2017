using UnityEngine;
using System.Collections;

public class wolfFollow : MonoBehaviour
{

    public Rigidbody enemy;
    public float moveSpeed;
    public Transform target;
    public int damage;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            transform.LookAt(target);
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        var hit = other.gameObject;
        var health = hit.GetComponent<playerHealth>();

        if(health != null)
        {
            health.TakeDamage(damage);
        }
    }
}