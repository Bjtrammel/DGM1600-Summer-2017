using UnityEngine;
using System.Collections;

public class SwitchStatements : MonoBehaviour
{
   public void start()
    {
        string SwitchStatements = "Lavender"; //whatever number the int is set to, is what case it will read. If the int isn't set, the deafult case will read.

        switch (SwitchStatements) 
        {
            case "Lavender":
                print("Case 1");
                break; //ends the case so that you're not running through a loop
            case "Tulip":
                print("Case 2");
                break;
            case "Hyacinth":
                print("Case 3");
                break;
            case "Pinkcat":
                print("Case 4");
                break;
            case "Pansy":
                print("Case 5");
                break;
            case "Sunflower":
                print("Case 6");
                break;
            case "Lily":
                print("Case 7");
                break;
            case "Monrning Glory":
                print("Case 8");
                break;
            case "Rose":
                print("Case 9");
                break;
            default:
                print("Default case");
                break;
        }
    }
}