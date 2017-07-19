using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

    public int points;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Player") {
            scoreManager.AddPoints(points);
            //Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
