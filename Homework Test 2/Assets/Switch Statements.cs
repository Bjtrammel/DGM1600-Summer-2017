using UnityEngine;
using System.Collections;

public class SwitchStatements : MonoBehaviour
{
{
   public void start()
    {
        int caseSwitch = 1;

        switch (caseSwitch)
        {
            case 1:
                print("Case 1");
                break;
            case 2:
                print("Case 2");
                break;
            case 3:
                print("Case 3");
                break;
            case 4:
                print("Case 4");
                break;
            case 5:
                print("Case 5");
                break;
            case 6:
                print("Case 6");
                break;
            case 7:
                print("Case 7");
                break;
            case 8:
                print("Case 8");
                break;
            case 9:
                print("Case 9");
                break;
            default:
                print("Default case");
                break;
        }
    }
}