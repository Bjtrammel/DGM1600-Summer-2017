using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour {

	
	void Start () {

        for (int i = 5; i <= 10; i++)
        {
            print(i + " Dogs to pet");
        }

        for (int a = 10; a > 5; a--)
        {
            print("Subtraction " + a);
        }

        for (char c = 'c'; c < 'h'; c++)
        {
            print(c);
        }

        for (char c = 'c'; c < 'h'; c--)
        {
            print(c);
        }
       //learned that this will count backwards from c through ASCII characters to get to h

        for (char c = 'c'; c > 'H'; c--)
        {
            print(c);
        }
        //fixed the example above to run straight through backwards c to H.

        for (int b = 12; b != 15; b++)
        {
            print(b + " peanuts");
        }

        for (float a = 1.5f; a > 1.00f; a--)
        {
            print(a + " souls");
        }

        for (float a = 1.5f; a < 1.75f; a++)
        {
            print(a + " Fruit Candies");
        }
    }
}
