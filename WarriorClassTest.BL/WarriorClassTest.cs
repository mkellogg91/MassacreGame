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

            Warrior warrior1 = new Warrior();
            Warrior warrior2 = new Warrior();
            Warrior winner;

            warrior1.health = 200;
            warrior1.strength = 5;
            warrior1.isAlive = true;

            warrior2.health = 200;
            warrior2.strength = 5;
            warrior2.isAlive = true;

           winner = Warrior.fight(warrior1, warrior2);

        }
    }
}
