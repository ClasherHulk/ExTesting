using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPlayerTesting
{
    class Program
    {
        public static List<Player> Playerslist()
        {
            List<Player> plist = new List<Player>
            {
                new Player{PId=1,PName="sachin",PTeam="India"},
                new Player{PId=2,PName="MS Dhoni",PTeam="India"},
                new Player{PId=3,PName="Virat",PTeam="India"},

            };
            return plist;

        }
        static void Main(string[] args)
        {
            
            
        }
    }
}
