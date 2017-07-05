using UnityEngine;
using System.Collections;

public class FunProp : MonoBehaviour {


	void Awake()
    {
        print("Awake");
    }

    void OnEnable()
    {
        print("Enable");
    }

    void Start()
    {
        print("Start");
    }

    private void OnDisable()
    {
        print("Disable");
    }

    private void OnTriggerEnter(Collider _col)
    {
        print(_col.name);
        //_col.transform.position = Vector3.zero;
        if(_col.name != "Enemy")
        {
            _col.gameObject.SetActive(false);
        }
        else
        {
            print("Adding Health");
        }
    }

    //private void OnTriggerStay()
    //{
    //    Print("Staying");
    //}

    private void OnTriggerExit()
    {
        print("Exit");

    }
}
