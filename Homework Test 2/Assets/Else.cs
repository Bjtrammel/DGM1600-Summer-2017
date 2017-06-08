﻿using UnityEngine;
using System.Collections;
using System.Linq;

public class Else : MonoBehaviour
//If statement: checks if a block of code is true or false. If it is true, it will run a block of code.If it is false, it will do nothing.
//Else: if it can do the default, it will do the default, if it can’t, it will do the else.
//site used for reference: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else

{
    public bool mountClicked = true;
    public int a = 5;
    public int b = 10;
    public string myString = "TONY";

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
        //Regular if-else statement. Because mountClicked is set to true, the top line is printed.

        if (a < 6)
            if (b < 11)
            {
                print("The top one is true, Dummy.");
            }
            else
            {
                print("The Top one Isn't true, Genious.");
            }
        //using two ints to create an if with a nested if else statement. Because 6 is greater than a, the statement is true and it would print the top line.

        if (a > 9)
        {
            if (a < 11)
                print("<('_')✓");
        }
        else
        {
            print(">(o)__ /)");
        }
        //using one int with if-else statment with a nested if.

        if (myString.Any(char.IsUpper))
        {
            print("Tony is in upper case");
        }
        else
        {
            print("Tony is in lower case");
        }
        //The any is creating a loop that goes through the Tony string, and to determine if the statement is true or false.

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
        //an if-else if-else created based off of the 
    }
   }