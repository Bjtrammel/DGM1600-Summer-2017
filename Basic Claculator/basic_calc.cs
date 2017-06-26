using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class basic_calc : MonoBehaviour {

    public InputField In1;
    public InputField In2;
    public Text result;

    public void AddClick() {
        int num = int.Parse(In1.text) + int.Parse(In2.text);
        result.text = num.ToString();
    }
    public void SubClick()
    {
        int num = int.Parse(In1.text) - int.Parse(In2.text);
        result.text = num.ToString();
    }
    public void MuliClick()
    {
        int num = int.Parse(In1.text) * int.Parse(In2.text);
        result.text = num.ToString();
    }
    public void DevideClick()
    {
        int num = int.Parse(In1.text) / int.Parse(In2.text);
        result.text = num.ToString();
    }
   }