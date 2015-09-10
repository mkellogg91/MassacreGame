using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassacreGame.BL
{
    public class Fight
    {

        //Randoms
        public static Random rnd = new Random();           //this determines which warrior takes the first turn
        public static Random fightAttack = new Random();   //generates random number for how big the hit will be on this fighter's turn

       


            /// <summary>
            /// 
            /// This method is used to accept 2 objects of the warrior class, allow them to fight to the death, and return the winner warrior
            /// 
            /// </summary>
            /// <param name="fighter1"></param>
            /// <param name="fighter2"></param>
            /// <returns></returns>
        public List<string> fight(Warrior fighter1, Warrior fighter2)
        {
            //Here I use an array of the warrior class so I can programatically refer to each warrior since its up in the air who's turn it will be
            Warrior[] fightersArray = new Warrior[3];
            var fightEvents = new List<string>();
            fightersArray[1] = fighter1;
            fightersArray[2] = fighter2;

            int firstTurn;
            int currentTurn;
            int notTurn;
            int hit;                //attack damage on hit

            firstTurn = rnd.Next(1, 3);     //this randomly will decide which warrior takes the first turn
            currentTurn = firstTurn;        //For the first round currentTurn will be whoever wins first attack coin toss



            //this is where the loop starts for the 2 soldiers to battle to the DEATH!!!
            do
            {
                //making sure notTurn is opposite of current turn
                if (currentTurn == 1)
                {
                    notTurn = 2;
                }
                else
                {
                    notTurn = 1;
                }


                //Determine how big the hit will be
                //this random will generate a hit between 0 and whatever the fighter's strength is
                hit = fightAttack.Next(0, fightersArray[currentTurn].strength + 1);

                //Attack
                fightersArray[notTurn].health -= hit;

                //Output string representing the hit
                //using a switch statement to handle different cases
                switch (hit)
                {
                    case 0:

                        fightEvents.Add(fightersArray[currentTurn].name + " missed cause he's a big huge NOOB HEHEHEHE! ");
                        break;

                    case 1 - 2:
                        fightEvents.Add(fightersArray[currentTurn].name + " hit " + fightersArray[notTurn].name + " for a measly " + Convert.ToString(hit) + " points of damage");
                        break;

                    default:
                        fightEvents.Add(fightersArray[currentTurn].name + " hit " + fightersArray[notTurn].name + " right in the face for " + Convert.ToString(hit) + " points of damage");
                        break;
                }

                //Switch Turns
                currentTurn = notTurn;       //This sets current turn to what notTurn was..notTurn will be set at the top of the loop to the opposite

                //Checks if one of the fighters died
                if(fighter1.health <= 0)
                {
                    fightEvents.Add("-----------------------" + fighter1.name + " IS DEAD!! XD XD XD XD XD" + "-----------------------");
                    fighter1.isAlive = false;
                }
                else if(fighter2.health <= 0)
                {
                    fightEvents.Add("----------------------- " + fighter2.name + " IS DEAD!! XD XD XD XD XD" + "-----------------------");
                    fighter2.isAlive = false;
                }
                
            } while (fighter1.health > 0 && fighter2.health > 0);

            return fightEvents;

        }//end fight method





        /// <summary>
        /// This method loops through and calls the fight method over and over until only 1 warrior remains
        /// </summary>
        /// <param name="warriorList"></param>
        public List<List<string>> battle(List<Warrior> warriorList)
        {

            // takes a list of warriors
            // it calls the fight method over and over until there is only 1 warrior left alive

            // this is my list of lists since each call of "fight" method returns 1 list 
            // I am storing each list in one big list 
            var battleList = new List<List<string>>();
            int leftAlive;
            Warrior warr1;
            Warrior warr2;

            do
            {


                // grab some dudes to fight
                warr1 = findNextFighter(warriorList);
                // including warr1.name so that warr2 is not set to the same 
                warr2 = findNextFighter(warriorList, warr1.name);

                // make those turds fight
               battleList.Add(fight(warr1, warr2));

                // get how many warriors are alive in the array
                leftAlive = warriorsAlive(warriorList);

            } while (leftAlive > 1);   //end fight loop

            return battleList;

        }







        /// <summary>
        /// 
        /// This method returns an enemy that is alive
        /// 
        /// </summary>
        /// <param name="warriorArray"></param>
        public Warrior findNextFighter(List<Warrior> warriorArray)
        {
            

            Warrior war = null;

            foreach (Warrior i in warriorArray)
            {
               
                if (i.isAlive == true)
                {
                    war = i;
                    break;
                }
                
            }
            return war;

        }//end findNextwarrior

        /// <summary>
        /// This overloads the findNextWarrior method and allows us to provide a string value to represent warrior name
        /// to not stop on for the second warrior found
        /// </summary>
        /// <param name="warriorArray"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public Warrior findNextFighter(List<Warrior> warriorArray, string warrSkipName)
        {


            Warrior war = null;

            foreach (Warrior i in warriorArray)
            {

                if (i.isAlive == true && i.name != warrSkipName)
                {
                    war = i;
                    break;
                }

            }
            return war;

        }//end findNextwarrior


        /// <summary>
        /// This function just returns the number of warriors left alive in the given list
        /// </summary>
        /// <param name="warriorArray"></param>
        /// <returns></returns>
        public int warriorsAlive(List<Warrior> warriorArray)
        {
            int isAlive = 0;

            foreach(Warrior i in warriorArray)
            {
                if(i.isAlive == true)
                {
                    isAlive ++;
                }
                else
                {
                    //nothing!
                }
            }

            return isAlive;

        }


    }
}
