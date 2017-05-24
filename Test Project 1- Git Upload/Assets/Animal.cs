using UnityEngine;
using System.Collections;

public class Animal : MonoBehaviour {

    //PROPERTIES (things they are or have)
    //BodySegments
    public string[] BodySegments = { "Head", "Abs", "Thorax" };
    public string AnimalName = "Jenny";
    //Health
    public int health = 100;
    //Speed
    public float speed = 0.0f;
    //Size
    public string size = "Big";
    public bool canEat = false;

    public Color basecolor;

    //FUNCTIONS (things they do)
    //Breathe
    //Reproduce
    //Eat
    void Start()
    {
        if (canEat)
        {
            print(this.name + " can eat.");
        }
        else
        {
            print(this.name + " can't eat.");
        }

        if (2 + 5 == 7)
        {
            print(7);
        }

        if(AnimalName == "Jen")
        {
            print("Jen"); 
        }

    }
    //Move
    //Die
    //Grow



}
