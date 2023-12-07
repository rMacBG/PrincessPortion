using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace PrincessPortion
{
    internal class Program
    {
        static void Main()
        {
            //These strings represent the task itself and the sayings on each chest
            string goldenChest = "The portrait is not in this chest. The portrait is in the silver chest.";
            string silverChest = "The portrait is not in the gold chest. The portrait is in the iron chest";
            string ironChest = "The portrait is not here. The portrait is in the golden chest";
            string task = "There are 3 chests - a golden one, a silver one and an iron one. \n" +
                "You have to find where princess Portion's portrait is, given the signs on each chest.\n" +
                "The princess also added on  one chest one text says the truth and one says a lie, one chest both\n" +
                "lines are lies and one chest with both saying the truth.\n" +
                "This is what's written on each chest: \n";
            // calling every string so the code doesn't look that crowded.
            Console.WriteLine(task);
            Console.WriteLine(goldenChest + "\n");
            Console.WriteLine(silverChest + "\n");
            Console.WriteLine(ironChest + "\n");

            //This line requires console input from the player and depending
            //on what the player inputs, an answer will pop up on the console!
            Console.WriteLine("In which chest do you think the portrait is in?\n");
            Console.Write("Give an answer: ");
            string answer = Console.ReadLine().ToLower(); //This is where the input is acquired!

            //A bool variable set for every statement on each chest!
            bool goldChestText1 = false;
            bool goldChestText2 = false;
            bool silverChestText1 = false;
            bool silverChestText2 = false;
            bool ironChestText1 = false;
            bool ironChestText2 = false;


            //The IF statements check what the user answer is and depending on that it will change every boolean
            //accordingly so the answer is built upon these booleans and everything is looped in a while loop so
            //the player can try multiple times until the correct answer is given!
            while (true)
            {          
                if (answer == "gold" || answer == "golden")
                {
                    //If the answer is gold OR golden, the answer is wrong
                    //because the statements on the GOLDEN chest are both wrong,
                    //the statements on the SILVER chest are also both wrong and
                    //the statements on the IRON chest are borh right!

                    goldChestText1 = false;
                    goldChestText2 = false;
                    silverChestText1 = false;
                    silverChestText2 = false;
                    ironChestText1 = true;
                    ironChestText2 = true;
                    //Here the method gets every boolean value,
                    //checks it to the predefined answer and then
                    //returns either a correct answer or a wrong answer.
                    //This is done in every if statement!
                    RightAnswerChecker(goldChestText1, goldChestText2,
                        silverChestText1, silverChestText2,
                        ironChestText1, ironChestText2,
                        answer);
                }
                else if (answer == "silver")
                {
                    //If the answer is SILVER, this is a wrong answer because
                    //In this case both statements on the GOLDEN chest are true
                    //the SILVER chest has one right and one wrong statement and
                    //the IRON chest also has one right and one wrong statement.
                    goldChestText1 = true;
                    goldChestText2 = true;
                    silverChestText1 = true;
                    silverChestText2 = false;
                    ironChestText1 = true;
                    ironChestText2 = false;

                    RightAnswerChecker(goldChestText1, goldChestText2,
                        silverChestText1, silverChestText2,
                        ironChestText1, ironChestText2,
                        answer);
                }
                else if (answer == "iron")
                {
                    //If the answer is IRON, this is the correct answer.
                    //Why, well because in this case we have the GOLDEN chest with
                    //ONE TRUE and ONE FALSE statement, the SILVER one with both CORRECT
                    //statements and the IRON chest with two INCORRECT statements.
                    goldChestText1 = true;
                    goldChestText2 = false;
                    silverChestText1 = true;
                    silverChestText2 = true;
                    ironChestText1 = false;
                    ironChestText2 = false;

                    RightAnswerChecker(goldChestText1, goldChestText2,
                        silverChestText1, silverChestText2,
                        ironChestText1, ironChestText2,
                        answer);
                    //This break command stops the while loop once the player has given the correct answer!
                    break;
                }
                //This else statement is mainly if the player gives something different for an answer.
                else
                {
                    Console.WriteLine("This is not a valid chest!");
                }
                answer = Console.ReadLine();
            }
        }

        //This method is called every time the player gives an answer to check if the given chest is the right one!
        //If the chest is right, the program will stop, saying that the answer is correct, if not the program will
        //continue and say that the answer is wrong. 
        public static void RightAnswerChecker(bool gold1,
            bool gold2, bool silver1, bool silver2,
            bool iron1, bool iron2, 
            string chest)
        {
            //This IF statement contains the correct answer of the program
            if (gold1 == true && gold2 == false && 
                silver1 == true && silver2 == true && 
                iron1 == false && iron2 == false)
            {
                Console.WriteLine($"Correct answer! The portrait is here in the {chest} chest!");
            }
            else
            {
                Console.WriteLine($"Wrong answer! The portrait is not in the {chest} chest");
                Console.Write($"Enter another answer: ");
            }
        }
    }
}