using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

    public Rigidbody projectile;
    public Transform spawnPointB;
    public int shootSpeed;
    public int damage;

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody clone;
            clone = (Rigidbody)Instantiate(projectile, spawnPointB.position, projectile.rotation);
            clone.velocity = spawnPointB.TransformDirection(Vector3.forward * shootSpeed);
        }
	}

    private void OnCollisionEnter(Collision other)
    {
        var hit = other.gameObject;
        var health = hit.GetComponent<playerHealth>();

        if (health != null)
        {
            health.TakeDamage(damage);
        }
    }
}
