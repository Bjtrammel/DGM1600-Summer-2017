using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public int damage = 1;
    public int time = 5;

    private void Start()
    {
        StartCoroutine(DestroyBullet());
    }

    void OnCollisionEnter(Collision other)
    {
        var hit = other.gameObject;
        var health = hit.GetComponent<wolfHealth>();

        if (health != null)
        {
            health.TakeDamage(damage);
        }
    }

    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
