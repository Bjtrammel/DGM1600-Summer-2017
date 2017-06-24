using UnityEngine;
using System.Collections;

public class VFunction : MonoBehaviour
{
    //similar to declairing a veriable, you are declairing a function or section of code that can be called upon by name and proformed without having to copy and paste the code.
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

    public void Example5()
    {
        if (a > 9)
        {
            if (a < 11)
                print("<('_')✓");
        }
        else
        {
            print(">(o)__ /)");
        }
    }

    public void Example6()
    {
        for (char c = 'c'; c < 'h'; c++)
        {
            print(c);
        }
    }

    public void Example7()
    {
        print("ʕ•ᴥ•ʔ");
    }

    public void Example8()
    {
        print("◉_◉");
    }

    public void Example9()
    {
        print("┬┴┬┴┤(･_├┬┴┬┴");
    }

    public void Example10()
    {
        print("☼.☼");
    }

    void Start()
    {
        Butterfly();
        doMath();
        TellTime ();
        Example4();
        Example5();
        Example6();
        Example7();
        Example8();
        Example9();
        Example10();
    }
}