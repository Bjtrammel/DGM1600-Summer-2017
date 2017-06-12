using UnityEngine;
using System.Collections;

public class Mammal : Animal {

    //PROPERTIES
    //Hair
    public bool hasHair = true;
    public Color HairColor = Color.gray;
    public int haircount = 1000;

    //Warm Blooded
    //HowManyLegs (1, 2, 4)
    public int legCount = 1;


    //FUNCTIONS
    //Live Birth Overrides Reproduction
    //Produce Milk
    //Bite

    void Start()
    {
        if(!hasHair || haircount < 20)
        {
            print("Isn't a very nice looking Mammal");
        }
    }
}
