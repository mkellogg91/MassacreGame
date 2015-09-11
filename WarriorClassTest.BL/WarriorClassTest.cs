using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MassacreGame.BL;
using System.Collections.Generic;

namespace WarriorClassTest.BL
{
    [TestClass]
    public class WarriorClassTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            //
            // Variables!!
            //
            var warriorList = new List<Warrior>();      //This will hold warrior objects
            bool keepLooping = true;
            var returnList = new List<List<string>>();

            //
            // warrior maker
            //
            for (int x=0; x<101; x++)
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
            // warrior fight section
            //

            Fight theFight = new Fight();


            // calling the battle method
            returnList = theFight.battle(warriorList);

            // returning the fight text
            foreach(List<string> i in returnList)
            {
                
                foreach(string x in i)
                {
                    System.Diagnostics.Debug.WriteLine(x);
                }

            }



            //Fight theFight = new Fight();
            //int leftAlive;
            //Warrior warr1;
            //Warrior warr2;

            //do
            //{


            //    // grab some dudes to fight
            //    warr1 = theFight.findNextFighter(warriorList);
            //            // including warr1.name so that warr2 is not set to the same 
            //    warr2 = theFight.findNextFighter(warriorList, warr1.name);

            //    // make those turds fight
            //    theFight.fight(warr1, warr2);

            //    // get how many warriors are alive in the array
            //    leftAlive = theFight.warriorsAlive(warriorList);

            //} while (leftAlive > 1);   //end fight loop

        }
    }
}
