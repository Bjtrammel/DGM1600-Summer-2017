using UnityEngine;
using System.Collections;

public class Birds : Animal {

    //PROPERTIES
    //Feather count
    public int feathers = 100;
    //Beaks
    public float beak = 0.05f;
    //Wings bool for if they work
    public bool wings = true;
    //Color
    public Color featherColor = Color.red;



    //FUNCTIONS
    //Fly
    //Build Nests
    //Lay Eggs Overrides Reproduction
    //Call

    void Start()
    {
        if (wings && feathers > 0)
        {
            print("Flying Type Animal");
        }
        else
        {
            print("Bird is lame.");
        }

        if(beak < 0.1f || beak > 10)
        {
            print("This bird is too smalll, or too big");
        }
    }


}