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
            var returnList = new List<List<string>>();
            bool safeToRun = true;
            int numOfWars = 1;

            try
            {
                numOfWars = Convert.ToInt32(warriorNumber.Text);
            }
            catch
            {
                warriorNumber.Text = "Please enter a number";
                safeToRun = false;
            }
            finally
            {
                // safeToRun variable must be true in order for the fight code to execute
                if (safeToRun == true)
                {
                    //
                    // warrior maker
                    //
                    for (int x = 0; x < numOfWars; x++)
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
                    foreach (List<string> i in returnList)
                    {

                        foreach (string x in i)
                        {
                            FightText.Text += x + "\r\n";
                        }

                    }
                }
            }
        }// end button click event
    }
}