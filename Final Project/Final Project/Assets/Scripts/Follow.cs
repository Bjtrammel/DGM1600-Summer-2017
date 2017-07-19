using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

    public Rigidbody enemy;
    public float moveSpeed;
    public Transform target;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player") {
            transform.LookAt(target);
            transform.Translate(Vector3.forward * -moveSpeed * Time.deltaTime);
        }
    }
}
