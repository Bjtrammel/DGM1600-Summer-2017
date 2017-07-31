using UnityEngine;
using System.Collections;

public class Coroutine : MonoBehaviour
{


    public int counter;
    public int maxNumber;

    public int ammo;

    void Start()
    {
        StartCoroutine(ammoLoad());
        StartCoroutine(Health());
    }

    IEnumerator Health()
    {
        while (counter < maxNumber)
        {
            yield return new WaitForSeconds(3);
            print("Health at " + counter + ".");
            counter++;

        }

        //print("First Action");
        //yield return new WaitForSeconds(5);
        //print("Second Action");
    }

    IEnumerator ammoLoad()
    {
        while (ammo < 15)
        {
            yield return new WaitForSeconds(2);
            print("Ammo ammount " + ammo + ".");
            ammo++;
        }
    }
}