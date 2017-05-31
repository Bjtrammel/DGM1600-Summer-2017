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
    public float speed = 7f;
    //Size
    public string size = "Big";
  
    public Color basecolor;

    //FUNCTIONS (things they do)
    //Breathe
    //Reproduce
    //Eat
    public bool canEat = false;

    //Move
    //Die
    //Grow
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

        if (AnimalName == "Jen")
        {
            print("Jen");
        }

        if (speed > 0f)
        {
            speed %= 2f;
        }

        if (health > 0)
        {
            health %= 2;
            print(health);
        }
        else
        {
            //print("Error");
            Debug.LogError("You can't divide by zero");
        }

    }

    }