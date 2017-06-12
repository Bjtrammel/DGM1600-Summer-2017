using UnityEngine;
using System.Collections;

public class Dog : MammalsWithLegs
{

    //PROPERTIES
    //HowManyLegs Overrides (4)
    //Mans Best Friend
    public string DogisFriendly  = "friendly";
    public int Friendliness = 100;

    //FUNCTIONS
    //Bark
    //Attack
    //
    void Start()
    {
        if (canEat && Friendliness == 100)
        {
            print(this.name + " begs for a treat");
        }


        if (canEat || Friendliness <= 50)
        {
            print(this.name + " wants a treat");
        }
    }
}