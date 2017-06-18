using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ListExamples : MonoBehaviour {

    public List<int> intlist = new List<int>() {1, 2, 3};
    public List<char> charlist = new List<char>() { 'J', 'N', 'P', 'R' };
    public List<string> stringlist = new List<string>() { "Red", "White", "Black", "Yellow" };
    public List<int> intlist2 = new List<int>() { 4, 5, 6 };
    public List<char> charlist2 = new List<char>() { 'c', 'f', 'v', 'y' };
    public List<string> stringlist2 = new List<string>() { "Emerald", "Neon", "Bronze", "Cocoa" };
    public List<int> intlist3 = new List<int>() { 7, 8, 9 };
    public List<char> charlist3 = new List<char>() { 'c', 'r', 'd', 'l' };
    public List<string> stringlist3 = new List<string>() { "Sky", "Raven", "Scarlet", "Sage" };
    public List<int> intlist4 = new List<int>() { 10, 11, 12 };

    void Start() {

        for(int i = 0; i < intlist.Count; i++)
        {
            print(intlist[i]);
        }

        foreach (char item in charlist)
        {
            print(item);
        }

        for (int i = 0; i < stringlist.Count; i++)
        {
            print(stringlist[i]);
        }

        foreach (int number in intlist2)
        {
            print(number);
        }

        for (int i = 0; i < charlist2.Count; i++)
        {
            print(charlist2[i]);
        }

        foreach (string color in stringlist2)
        {
            print(color);
        }


        for (int i = 0; i < intlist3.Count; i++)
        {
            print(intlist3[i]);
        }

        foreach (char character in intlist3)
        {
            print(character);
        }

        for (int i = 0; i < stringlist3.Count; i++)
        {
            print(stringlist3[i]);
        }

        foreach (int numbers in intlist4)
        {
            print(numbers);
        }

    }
}
