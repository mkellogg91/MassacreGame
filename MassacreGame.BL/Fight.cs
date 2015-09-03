using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassacreGame.BL
{
    class Fight
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
        public Warrior fight(Warrior fighter1, Warrior fighter2)
        {
            //Here I use an array of the warrior class so I can programatically refer to each warrior since its up in the air who's turn it will be
            Warrior[] fightersArray = new Warrior[3];
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
                        Console.WriteLine(fightersArray[currentTurn].name + " missed cause he's a big huge NOOB HEHEHEHE! ");
                        break;

                    case 1 - 2:
                        Console.WriteLine(fightersArray[currentTurn].name + " hit " + fightersArray[notTurn].name + " for a measly " + Convert.ToString(hit) + " points of damage");
                        break;

                    default:
                        Console.WriteLine(fightersArray[currentTurn].name + " hit " + fightersArray[notTurn].name + " right in the face for " + Convert.ToString(hit) + " points of damage");
                        break;
                }

                //Switch Turns
                currentTurn = notTurn;       //This sets current turn to what notTurn was..notTurn will be set at the top of the loop to the opposite

            } while (fighter1.health > 0 && fighter2.health > 0);

            //This checks for who the winner of the fight was
            if (fighter1.health == 0)
            {
                fighter1.isAlive = false;       //Setting this warrior to DEAD!!!
                return fighter2;
            }
            else
            {
                fighter2.isAlive = false;       //Setting this warrior to DEAD!!!
                return fighter2;
            }

        }//end fight method

        /// <summary>
        /// 
        /// This method is the logic behind fighters finding a new enemy
        /// 
        /// </summary>
        /// <param name="warriorArray"></param>
        public void findNextFighter(Warrior[] warriorArray)
        {
            bool keepLooping = true;

            do
            {




                if(/*logic to determine if only 1 warrior's isAlive property == true*/)
                {
                    keepLooping = false;
                }
                else
                {
                    //do nothing
                }

            } while(keepLooping == true);

        }


    }
}
