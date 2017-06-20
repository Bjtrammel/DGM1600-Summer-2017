using UnityEngine;
using System.Collections;

public class ScopeAccess : MonoBehaviour {

    public int a = 1; //public: can be accessed anywhere
    public int b = 2;

    List<string> stringlist = new List<string>() { "Red", "White", "Black", "Yellow" }; //private, can only be used in this class. Trying to run this would only give the memory location.
    List<string> stringlist2 = new List<string>() { "Emerald", "Neon", "Bronze", "Cocoa" };

    protected bool = true; //protected: can be accessed by any child classes. 
    protected bool = false;

     
    void Start () {
        internal char c = 'C';
        internal char d = 'D'; //Internal: Can only be accessed within the brackets it's declared in.
        }

    
}
