using UnityEngine;
using System.Collections;

public class SwitchStatements : MonoBehaviour
{
    public void start()
    {
        string SwitchStatements = "Lavender"; //whatever the string is set to, is what case it will read. If the string isn't set, the deafult case will read.

        switch (SwitchStatements)
        {
            case "Lavender": //the name for the specific cae. 
                print("You picked a Lavender");
                break; //ends the case so that you're not running through a loop
            case "Tulip":
                print("You picked a Tulip");
                break;
            case "Hyacinth":
                print("You picked a Hyacinth");
                break;
            case "Pinkcat":
                print("You picked a Pinkcat");
                break;
            case "Pansy":
                print("You picked a Pansy");
                break;
            case "Sunflower":
                print("You picked a Sunflower");
                break;
            case "Lily":
                print("You picked a Lily");
                break;
            case "Monrning Glory":
                print("You picked a Morning Glory");
                break;
            case "Rose":
                print("You picked a Rose");
                break;
            default:
                print("You picked a flower");
                break;
        }
    }
}