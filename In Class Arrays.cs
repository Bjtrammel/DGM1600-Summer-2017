using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public GameObject[] players;

    void start ()
    {
        players = GameObject.FindGameObjectWithTag("Player");      
        for(int i = 0; i < player.length; i++)
        {
            Debug.log("Player Number" + i + "is named " + player[i].name);

        }
        }
    }
}
//debug.log(where it reports to
// i = #0
// Player Number (array number) is named (gives array number name)
//play.length is the number of things stored in the array
// so long as the amount of things stored in the array is higher than the int; it will print until it hits that number.
//i++ is # +1
