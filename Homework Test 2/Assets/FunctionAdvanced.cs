using UnityEngine;
using System.Collections;

public class FunctionAdvanced : MonoBehaviour {

    //   public string myName = "Tony";
    //   public int myScore = 2;

    // Use this for initialization
    //void Start () {
    //       UseData(myName);
    //       UseData(myScore);
    //}

    // Update is called once per frame
    //void UseData (string _s) {
    //       print(_s + ", Hello.");
    //}

    //   void UseData(int _i)
    //   {
    //       print(_i * 10);
    //   }

    public string keyWord;
    public int health;

    private void Start()
    {
        health = PowerUp(10);
        keyWord = PowerUp("OU812");
    }

    string PowerUp(string _s)
    {
        return _s;
    } 

        int PowerUp(int _i)
    {
        return _i;
    }

}
