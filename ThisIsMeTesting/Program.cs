using System;

namespace ThisIsMeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            /*
            string MyStringChallengeOne;
            Console.WriteLine("Please enter your name and press enter");
            MyStringChallengeOne = Console.ReadLine();
            string MyStringChallengeOneUpper = string.Format("Upper is {0}", MyStringChallengeOne.ToUpper());
            string MyStringChallengeOneLower = string.Format("Lower is {0}", MyStringChallengeOne.ToLower());
            string MyStringChallengeOneTrim = string.Format("Trimmed is {0}", MyStringChallengeOne.Trim());
            string MyStringChallengeOneSubstring =string.Format("Substring of 1 is {0}", MyStringChallengeOne.Substring(0, 1));
            Console.WriteLine(MyStringChallengeOneUpper);
            Console.WriteLine(MyStringChallengeOneLower);
            Console.WriteLine(MyStringChallengeOneTrim);
            Console.WriteLine(MyStringChallengeOneSubstring);
            */
            /*
            Console.WriteLine(MyStringChallengeOne.ToUpper());
            Console.WriteLine(MyStringChallengeOne.ToLower());
            Console.WriteLine(MyStringChallengeOne.Trim());
            Console.WriteLine(MyStringChallengeOne.Substring(1));
            */
            /*
            string StringChallengeTwo; //Remember that you can declare a variable anytime- even directly when you ask/ need to store them, will do with the next variable in the next line
            //string ChallangerName; //Honestly I think it may be a little more condensed, but is it more legible? probably at a higher skill level
            //string MyFirstName;
            string MyLastName;
            //string ChallengeTwoQuestionTwo; //So I'ma try something here- where the previous commented out sections worked, but I want to use less space, and only have one
            //string ChallengeExtraResponse; //"response" string stored that changes with the response, as its not really needed to keep them
            // In all reality I probably done even need a string. I'll try that
            //its overall shorter for the same code, no assigning strings needed- but has the effect of not storing those strings

            
            Console.WriteLine("Please enter your test string, then press enter");
            StringChallengeTwo = Console.ReadLine();
            Console.WriteLine("This is your string: " + StringChallengeTwo);
            Console.Write("Do you wish to continue? y/n ");
            ChallengeExtraResponse = Console.ReadLine();
            if (ChallengeExtraResponse == "n")
                Environment.Exit(0);
            if (ChallengeExtraResponse == "y")
                Console.WriteLine("continuing..");
            Console.Write("Please enter a search character: ");
            ChallengeTwoQuestionTwo = Console.ReadLine();
            Console.WriteLine("Index of requested character: " + StringChallengeTwo.IndexOf(ChallengeTwoQuestionTwo));
            */
            /*
            Console.WriteLine("Please enter your test string, then press enter");
            StringChallengeTwo = Console.ReadLine();
            Console.WriteLine("This is your string: " + StringChallengeTwo);
            Console.Write("Do you wish to continue? y/n ");
            if (Console.ReadLine() == "n")  //Now this does not seem to work with the .readline instead of a string-- update only this line works, the "y" will not
                Environment.Exit(0);
            //if (Console.ReadLine() == "y") //Replacing with the illusion of choice 
            //    Console.WriteLine("continuing..");
            else
                Console.WriteLine("Continuing..");
            Console.Write("Please enter a search character: ");
            Console.WriteLine("Index of requested character: " + StringChallengeTwo.IndexOf(Console.ReadLine()));

            Console.WriteLine("Please enter your first name: ");
            string MyFirstName = Console.ReadLine();
            Console.WriteLine("Plesae enter your last name: ");
            MyLastName = Console.ReadLine();
            string ChallangerName = MyFirstName + " " + MyLastName; // could also be writen like : string ChallengerName = string.Concat(MyFirstName + " " + MyLastName);
            Console.WriteLine("Welcome " + ChallangerName + "!"); //could also wite as: Console.WriteLione("Welcome {0} !", ChallengerName);
            */

            string oneTest = "This";
            string twoTest = "Is";
            string threeTest = "a";
            string fourTest = "Test";
            Console.WriteLine("{0} {1} {2} {3}", oneTest, twoTest, threeTest, fourTest);

            Console.Read();




        }
    }
}
