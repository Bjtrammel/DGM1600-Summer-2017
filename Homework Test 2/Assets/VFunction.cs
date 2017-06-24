using UnityEngine;
using System.Collections;

public class VFunction : MonoBehaviour
{

    public void Butterfly()
    {
        print("I'm a beautiful butterfly!");
    }

    int a = 5;
    int b = 10;
    public void doMath()
    {
       int result = a + b;
       print(result);
    }
    
    public void TellTime()
    {
        print(System.DateTime.Now);
    }

    public void Example4()
    {
        print(this.name);
    }

    public string myString = "TONY";
    public void Example5()
    {
        if (myString.Any(char.IsUpper))
        {
            print("Tony humble brags about his dps");
        }
        else
        {
            print("Tony does actually ahve good dps");
        }
    }
    void Start()
    {
        Butterfly();
        doMath();
        TellTime ();
        Example4();
        Example5();
        //Example6();
        //Example7();
        //Example8();
        //Example9();
        //Example10();
    }
}