using UnityEngine;
using System.Collections;

public class Elephant : MammalsWithLegs {

    // Properties
    //howmanylegs overides (4)
    //Vegeterian overrides eats
    //
    public bool Vegeterian = true;
    public int AmountEaten = 1000;

    void Start()
    {
        if(Vegeterian && AmountEaten ==1000)
        {
            print("Elephants eat alot");
        }

        if(Vegeterian || AmountEaten < 2000)
        {
            print("Elephant has eaten a lot");
        }

        if (!Vegeterian || AmountEaten < 2000)
        {
            print("Elephant hasn't eaten enough");
        }
    }
	
}
