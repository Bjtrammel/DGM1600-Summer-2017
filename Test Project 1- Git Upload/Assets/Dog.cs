using UnityEngine;
using System.Collections;

public class Dog : MammalsWithLegs
{

    //PROPERTIES
    //HowManyLegs Overrides (4)
    //Mans Best Friend
    public string DogisFriendly  = "Unfriendly";

    //FUNCTIONS
    //Bark
    //Attack
    //
    void Start()
    {
        if (canEat)
        {
            print(this.name + " is hungry!");
        }
        else
        {
            print(this.name + " isn't hungry!");
        }

        if ( 2+ 2 == 4)
        {
            print("Dog has 4 legs.");
        }
        if (DogisFriendly == "Unfriendly")
        {
            print("This dog is unfriendly");
        }
    }
}