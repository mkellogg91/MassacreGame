using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MassacreGame.BL;


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
            Warrior[] warriorArray = new Warrior[105];      //This will hold warrior objects
            bool keepLooping = true;


            //
            // warrior maker
            //
            for (int x=1; x<101; x++)
            {

                //create the new object of Warrior class
                warriorArray[x] = new Warrior();

                //set properties of the new object using some random variables so its slightly randomized
                //this will temporarily be hardcoded for simplicity :)
                warriorArray[x].health = 300;
                warriorArray[x].name = "LittleWarrior" + Convert.ToString(x);
                warriorArray[x].strength = 10;
                warriorArray[x].isAlive = true;
            }

            //
            // warrior find and fight section
            //
           

        }
    }
}
