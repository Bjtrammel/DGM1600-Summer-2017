using UnityEngine;
using System.Collections;

public class ForEach : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {

        string[] pokemon = { "Vaporeon", "Jolteon", "Flareon", "Espeon", "Umbreon", "Leafeon", "Glaceon", "Eevee" };
        string[] evolutions = new string[7];

        foreach (string eevee in pokemon)
        {
            print(eevee);
        }

        foreach (string change in pokemon)
        {
            if (change == "Eevee")
            {
                continue;
            }
            print(change);
        }
        //It referenced the array, and if it wasn't "Eevee" then it printed the string. Once it got to "Eevee" then it went to the if statement and used continue to go to the next loop element.

        foreach (string change in pokemon)
        {
            if (change == "Espeon")
            {
                break;
            }
            print(change);
            //same thing as the example above, but once it gets to "Espeon", it will break, ending the loop.
        }

        foreach (string change in pokemon)
        {
            if (change != "Eevee")
            {
                print(change);
            }
        }

        string filter = "";
        foreach (string change in pokemon) //telling change to look in the pokemon array
        {
            if (change != "Eevee" ) //if statement, change goes through and looks at everything that isn't eevee
            {
                filter += change + ","; //then if it's not eevee it adds a comma, and adds it to a string
            }
        }
        filter = filter.Substring(0, filter.Length - 1); //removing extra comma
        evolutions = filter.Split(','); //splits the filter into an array every time there is a comma. that array is the evolutions

        foreach (string evolution in evolutions)  
        {
            print(evolution);
        } //prints the new array
    }
}
