using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Player") {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
