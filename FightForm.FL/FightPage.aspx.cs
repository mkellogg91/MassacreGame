using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MassacreGame.BL;


namespace FightForm.FL
{
    public partial class FightPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void fightButton_Click(object sender, EventArgs e)
        {
            //
            // Variables!!
            //
            var warriorList = new List<Warrior>();      //This will hold warrior objects
            bool keepLooping = true;


            //
            // warrior maker
            //
            for (int x = 0; x < 101; x++)
            {

                //create the new object of Warrior class
                warriorList.Add(new Warrior());

                //set properties of the new object using some random variables so its slightly randomized
                //this will temporarily be hardcoded for simplicity :)
                warriorList[x].health = 300;
                warriorList[x].name = "LittleWarrior" + Convert.ToString(x);
                warriorList[x].strength = 10;
                warriorList[x].isAlive = true;
            }

            //
            // warrior find and fight section
            //
            Fight theFight = new Fight();
            int leftAlive;
            Warrior warr1;
            Warrior warr2;

            do
            {


                // grab some dudes to fight
                warr1 = theFight.findNextFighter(warriorList);
                // including warr1.name so that warr2 is not set to the same 
                warr2 = theFight.findNextFighter(warriorList, warr1.name);

                // make those turds fight
                theFight.fight(warr1, warr2);

                // get how many warriors are alive in the array
                leftAlive = theFight.warriorsAlive(warriorList);

            } while (leftAlive > 1);   //end fight loop
        }
    }
}