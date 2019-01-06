/*
 Author: Clinton Daniel
 Date: 1/5/2019
 Comments: This C# Console application code demonstrates the use of 
           conditional statements after getting input from users
*/

using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.WriteLine("Please enter a Sales Amount ...");
            /*
               Use the try catch block to validate user input.
               If the user provides bad input, the catch block
               will handle the error and a message will be displayed.
            */
            try
            {
                // This variable will gather the user input
                string input = Console.ReadLine();
                /* 
                   This variable will be used to store sales
                   after the input variable is parsed to decimal
                 */
                decimal sales = decimal.Parse(input);
                // This variable will be used to calculate the bonus
                decimal bonus = 0;
                // This variable will be used to get the number of years user has been in sales
                int years_in_sales = 0;
                /* 
                    This IF/ELSE IF/ELSE statement is used to conditionally
                    test the users input. Various options are available
                    depending on the amount entered by the user. Then, insde of each IF/ELSE IF/ELSE
                    there is a switch conditional statement that displays a message depending
                    on the number of years experience in sales entered by the user. 
                 */
                 if (sales < 1000)
                {
                    bonus += .05m * sales;
                    Console.WriteLine("Your 5% bonus for the Sales Amount " + String.Format("{0:C}",sales) + " is: " + String.Format("{0:C}", bonus));
                    // Now get the number of years the user has been in sales
                    Console.WriteLine("How many years have you been in Sales?");
                    // Assign the number of years the user has input to the years_in_sales variable
                    years_in_sales = int.Parse(Console.ReadLine());
                    /* Execute the conditional switch statement to output different messages 
                       depending on the integer value entered for years in sales
                    */
                    switch (years_in_sales)
                    {
                        case 0:
                            Console.WriteLine("Wow! Pretty good for a rookie!");
                            Console.WriteLine("Press any key to exit the program ...");
                            // Console.ReadKey(true) pauses the program until the user presses a key
                            Console.ReadKey(true);
                            break;
                        case 1:
                            Console.WriteLine("Not bad for one year of sales experience!");
                            Console.WriteLine("Press any key to exit the program ...");
                            Console.ReadKey(true);
                            break;
                        case 2:
                            Console.WriteLine("Not bad for two years of sales experience!");
                            Console.WriteLine("Press any key to exit the program ...");
                            Console.ReadKey(true);
                            break;
                        default:
                            Console.WriteLine("You have many years of sales experience. Keep up the good work!");
                            Console.WriteLine("However, if are here because you did not type an integer value for the number of years - Please enter an integer value next time ...");
                            Console.WriteLine("Press any key to exit the program ...");
                            Console.ReadKey(true);
                            break;
                    } // end of switch              
                }
                else if ((sales > 1000) && (sales < 3000))
                {
                    bonus += .06m * sales;
                    Console.WriteLine("Your 6% bonus for the Sales Amount " + String.Format("{0:C}", sales) + " is: " + String.Format("{0:C}", bonus));
                    Console.WriteLine("How many years have you been in Sales?");
                    // Assign the number of years the user has input to the years_in_sales variable
                    years_in_sales = int.Parse(Console.ReadLine());
                    /* Execute the conditional switch statement to output different messages 
                       depending on the integer value entered for years in sales
                    */
                    switch (years_in_sales)
                    {
                        case 0:
                            Console.WriteLine("Wow! Pretty good for a rookie!");
                            Console.WriteLine("Press any key to exit the program ...");
                            // Console.ReadKey(true) pauses the program until the user presses a key
                            Console.ReadKey(true);
                            break;
                        case 1:
                            Console.WriteLine("Not bad for one year of sales experience!");
                            Console.WriteLine("Press any key to exit the program ...");
                            Console.ReadKey(true);
                            break;
                        case 2:
                            Console.WriteLine("Not bad for two years of sales experience!");
                            Console.WriteLine("Press any key to exit the program ...");
                            Console.ReadKey(true);
                            break;
                        default:
                            Console.WriteLine("You have many years of sales experience. Keep up the good work!");
                            Console.WriteLine("However, if are here because you did not type an integer value for the number of years - Please enter an integer value next time ...");
                            Console.WriteLine("Press any key to exit the program ...");
                            Console.ReadKey(true);
                            break;
                    } // end of switch 
                }
                else
                {
                    bonus += .07m * sales;
                    Console.WriteLine("Your 7% bonus for the Sales Amount " + String.Format("{0:C}", sales) + " is: " + String.Format("{0:C}", bonus));
                    Console.WriteLine("How many years have you been in Sales?");
                    // Assign the number of years the user has input to the years_in_sales variable
                    years_in_sales = int.Parse(Console.ReadLine());
                    /* Execute the conditional switch statement to output different messages 
                       depending on the integer value entered for years in sales
                    */
                    switch (years_in_sales)
                    {
                        case 0:
                            Console.WriteLine("Wow! Pretty good for a rookie!");
                            Console.WriteLine("Press any key to exit the program ...");
                            // Console.ReadKey(true) pauses the program until the user presses a key
                            Console.ReadKey(true);
                            break;
                        case 1:
                            Console.WriteLine("Not bad for one year of sales experience!");
                            Console.WriteLine("Press any key to exit the program ...");
                            Console.ReadKey(true);
                            break;
                        case 2:
                            Console.WriteLine("Not bad for two years of sales experience!");
                            Console.WriteLine("Press any key to exit the program ...");
                            Console.ReadKey(true);
                            break;
                        default:
                            Console.WriteLine("You have many years of sales experience. Keep up the good work!");
                            Console.WriteLine("Press any key to exit the program ...");
                            Console.ReadKey(true);
                            break;
                    } // end of switch 
                }
            } // end of try
            catch
            {
                Console.WriteLine("Please use a decimal data type for your sales amount next time...");
                Console.WriteLine("--- OR ---");
                Console.WriteLine("Please use an integer data type for your number of years in sales next time ...");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            } // end of catch     
        } // end of Main
    } // end of class
} // end of namespace
