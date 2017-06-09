using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour
{


    void Start()
    {
        int a = 5; //set your int
        int b = 10;
        while (a++ < 10) //create loop and tell it how to count from your int to another number.
        {
            print("Count Von Count says, " + a); //tell it to print your numbers. the a without parentheses is a counted number.
        }

        while (a-- > 2)
        {
            print("Ah, Ah, Ah " + a);
        }

        while (a-- >= 2)
        {
            print(a + "Ah, Ah, Ah");
        }

        while (a-- > b)
        {
            print(a + "bottles on the wall");
        }

        while (a++ > b)
        {
            print(a + "Bottles");
        }
        else{
            print("Dummy");
        }
        //Attempted to create a while-else loop. 
    }