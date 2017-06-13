using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour {

	// Use this for initialization
	void Start () {

        for (int i = 5; i <= 10; i++)
        {
            print(i + " Dogs to pet");
        }

        for (int a = 10; a > 5; a--)
        {
            print("Subtraction");
        }
    }
}
