using UnityEngine;
using System.Collections;

public class Else : MonoBehaviour
//If statement: checks if a block of code is true or false. If it is true, it will run a block of code.If it is false, it will do nothing.
//Else: if it can do the default, it will do the default, if it can’t, it will do the else.
//site used for reference: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else

{
    public bool mountClicked = true;
    public int a = 5;
    public int b = 10;
    public string TONY = (string)Console.Read();

    void Start()
    {
        if (mountClicked)
        {
            print("You are now mounted.");
        }
        else
        {
            print("You are not prepared!");
        }

        if (a < 6)
            if (b < 11)
            {
                print("The top one is true, Dummy.");
            }
            else
            {
                print("The Top one Isn't true, Genious.");
            }

        if (a > 9)
        {
            if (a < 11)
                print("<('_')✓");
        }
        else
        {
            print(">(o)__ /)");
        }

        if (string.IsUpper(TONY))
        {
            print("Tony is in upper case");
        }
        else
        {
            print("Tony is in lower case");
        }

        if (a > 9)
        {
            print("<('_')✓");
        }
        else if (a > 11)
        {
            print(">(o)__ /)");
        }
        else
        {
            print("Ƹ̵̡Ӝ̵̨̄Ʒ");
        }
    }
   }