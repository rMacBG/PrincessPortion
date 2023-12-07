using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace PrincessPortion
{
    internal class Program
    {
        static void Main(string[] args)
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
            // calling every string so the code doesn't look that crowded!
            Console.WriteLine(task);
            Console.WriteLine(goldenChest + "\n");
            Console.WriteLine(silverChest + "\n");
            Console.WriteLine(ironChest + "\n");
            //This line requires console input from the user and depending
            //on what the user inputs, an answer will pop up on the console!
            Console.Write("Enter what chest you think the portrait is in: ");
            //This is where the input is acquired!
            string input = Console.ReadLine().ToLower();
            //a bool variable set for every statement on each chest!

            bool goldChestText1 = false;
            bool goldChestText2 = false;
            bool silverChestText1 = false;
            bool silverChestText2 = false;
            bool ironChestText1 = false;
            bool ironChestText2 = false;


            //The if statements check what the user answer is and depending on that it will change every boolean
            //accordingly so the answer is built upon these booleans
            while (true)
            {
                if (input == "gold")
                {
                    goldChestText1 = false;
                    goldChestText2 = false;
                    silverChestText1 = false;
                    silverChestText2 = false;
                    ironChestText1 = true;
                    ironChestText2 = true;

                    RightAnswerChecker(goldChestText1, goldChestText2,
                        silverChestText1, silverChestText2,
                        ironChestText1, ironChestText2,
                        input);
                }
                else if (input == "silver")
                {
                    goldChestText1 = true;
                    goldChestText2 = true;
                    silverChestText1 = true;
                    silverChestText2 = false;
                    ironChestText1 = true;
                    ironChestText2 = false;

                    RightAnswerChecker(goldChestText1, goldChestText2,
                        silverChestText1, silverChestText2,
                        ironChestText1, ironChestText2,
                        input);
                }
                else if (input == "iron")
                {
                    goldChestText1 = true;
                    goldChestText2 = false;
                    silverChestText1 = true;
                    silverChestText2 = true;
                    ironChestText1 = false;
                    ironChestText2 = false;

                    RightAnswerChecker(goldChestText1, goldChestText2,
                        silverChestText1, silverChestText2,
                        ironChestText1, ironChestText2,
                        input);
                    break;
                }
                //This else is mainly if the user inputs something different
                else
                {
                    Console.WriteLine("error");
                }
                input = Console.ReadLine();
            }
        }

        //This method is called every time the user gives an answer to check if the given chest is the right one!
        //If the chest is right the program will stop saying that the answer is correct, if not the program will
        //exit and say that the answer is wrong.
        //The idea is less repeating code!  
        public static void RightAnswerChecker(bool gold1,
            bool gold2, bool silver1, bool silver2,
            bool iron1, bool iron2, 
            string chest)
        {
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