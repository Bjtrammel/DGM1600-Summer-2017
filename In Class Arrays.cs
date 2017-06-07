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
