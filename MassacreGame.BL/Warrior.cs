using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassacreGame.BL
{
    public class Warrior
    {

        //SO CLEAN....SO BEAUTIFUL!!!

        public Warrior()
        {

        }

        public Warrior(int theHealth, int theStrength, bool theisAlive, string theName)
        {
                //these variable names were designed in honor of ****Trystan34  10:04 PM 9/3/2015****
            health = theHealth;
            strength = theStrength;
            isAlive = theisAlive;
            name = theName;
        }



            //Properties!
        public int health { get; set; }
        public int strength { get; set; }
        public bool isAlive { get; set; }
        public string name { get; set; }
       

    }
}
