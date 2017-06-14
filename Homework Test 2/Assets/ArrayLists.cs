using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ArrayLists : MonoBehaviour {

    public List<string> players = new List<string>();

    //void Start()
    //{
    //    players.Add("Bill");
    //    players.Add("Charlie");
    //    players.Add("Percy");
    //}

    public void RunLoop ()
    {
        foreach (string item in players)
        {
            print(item);
        }
        if (players.Count != 1 )
        {
            print("You have " + players.Count + " Players.");
        }
        else
        {
            print("You have " + players.Count + " Player.");
        }
    }
}