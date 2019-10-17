/*Class name: My validation
  Programmer: Ivoire Morrell
  Date: October 17th, 2019
  Description: The power class applications displays 
  squares and cubes based off the integer entered by the user
 */

using System;

namespace powersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string num;
            bool ok = true;
            bool isNumber = false;

            //print out the welcome message
            Console.WriteLine("Learn your Squares and Cubes! \n");

            //use a while loop to see if the user wants to continue after processing
            while (ok)
            {

                //wrap code in while loop to check if user enter a number
                while (isNumber != true )
                {
                    //prompt the the user to enter a number 
                    Console.WriteLine("Please enter a number \n");

                    num = Console.ReadLine();

                    Console.WriteLine();

                    //check to see if the user enter a number
                    if (double.TryParse(num, out double number))
                    {
                        //send the number to the power calculator
                        powerCalculator(number);

                        //convert isNumber to true
                        isNumber = true;
                    }
                    else
                    {
                        //user did not enter a number
                        Console.WriteLine("This is not a number! Please enter a number. \n");
                        isNumber = false;
                    }
                }

                Console.WriteLine();
                //Ask user if they would like to go again
                ok = getContinue();

                Console.WriteLine();

                //reset is number back to false
                isNumber = false;

            }

        }

        //the powerCalculator method calculate the square and cube of a given integer
        public static void powerCalculator(double number)
        {
            double square;
            double cube;

            //display the lables for the squares and cubes
            Console.WriteLine("Number   Squares  Cubes");
            Console.WriteLine("==========================");

            //use a for loop to calculate the powers
            for (int i = 1; i < number; i++)
            {
                //calculate the square and the cube
                square = Math.Pow(i, 2);
                cube = Math.Pow(i, 3);

                //calculate and print out the squares and cubes
                Console.WriteLine("|" + i + "\t" + "  |" + square + "\t" +"  |" + cube);
            }
        }

        //this method is used to determine if the user wants to continue within a loop
        public static bool getContinue()
        {
            //create variables
            String choice;
            bool ok = true;
            bool result = true;

            //create while loop to determine if user wants to continue
            while (ok)
            {
                Console.WriteLine("Continue? (y/n): \n");

                //retrieve user input
                choice = Console.ReadLine();

                //determine the users input and return corresponding message
                if (choice.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    //user wants to continue. exit the while loop and return true
                    ok = false;
                    result = true;
                }
                else if (choice.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    //user does not want to continue
                    ok = false;
                    result = false;
                }
                else
                {
                    //user did not enter y or n
                    Console.WriteLine("Error! Please enter Y or N. Please enter correct input \n");

                }

            }

            return result;
        }
    }
}
