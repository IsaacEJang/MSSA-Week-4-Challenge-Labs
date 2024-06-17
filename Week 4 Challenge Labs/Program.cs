using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week_4_Challenge_Labs
{
    internal class Program
    {
        static void Introduction()
        {
            // HEADER
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Week 4 Challenge Labs");
            Console.WriteLine("Name: Isaac Jang\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------PART 1---------------\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Transition()
        {
            // TRANSITION
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPress any key to continue!\n");
            Console.ReadKey();
        }

        static void Part(int i)
        {
            // PART 2
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n---------------PART {i}---------------\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void ClosingMessage()
        {
            // CLOSING MESSAGE
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nHave a great day!");
        }

        static void TryAgain()
        {
        TryAgain:
        StartPoint1:
            try
            {
                while (true)
                {
                    // ask user if they want to try again
                    Console.WriteLine("\nWant to try again? (Y / N)");
                    char answer = char.Parse(Console.ReadLine().ToUpper());

                    // wants to continue
                    if (answer == 'Y')
                    {
                        goto StartPoint1;
                    }

                    // does not want to continue
                    else if (answer == 'N')
                    {
                        break;
                    }

                    // invaid entry
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nEnter valid character");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvaild Answer Choice\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto TryAgain;
            }

        }


        static void Main(string[] args)
        {
            #region Part1
            Introduction(); StartPoint1:
            /*Write a program in C# Sharp to calculate and print the Electricity bill of a given customer. 
             * The customer id., name and unit consumed by the user should be taken from the 
             * user and display the total amount to pay to the customer. 
             * The charge are as follows: (you may change the charge sheet values)

            Unit                                  Charge/unit
            upto 199                                    @1.20
            200 and above but less than 400             @1.50
            400 and above but less than 600             @1.80
            600 and above                               @2.00
            If bill exceeds $ 400 then a surcharge of 15% will be charged.

            Test Data :
            1001
            James
            800

            Expected Output :
            Customer IDNO :1001
            Customer Name :James
            unit Consumed :800
            Amount Charges @$ 2.00 per unit : 1600.00
            Surcharge Amount : 240.00
            Net Amount Paid By the Customer : 1840.00
             */

            Console.WriteLine("\nI will calculate your Electricity bill\n");
            Console.Write("Enter your Customer ID: ");
            int customerId = int.Parse(Console.ReadLine());

            Console.Write("Enter your name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter units consumed: ");
            int unitsConsumed = int.Parse(Console.ReadLine());

            float eletricityBill = 0;
            float surcharge = 0;
            float rate = 0;

            if (unitsConsumed < 199)
            {
                rate = 1.20f;
                eletricityBill = unitsConsumed * rate;
            }
            else if (200 <= unitsConsumed && unitsConsumed < 400)
            {
                rate = 1.50f;
                eletricityBill = unitsConsumed * rate;
            }
            else if (400 <= unitsConsumed && unitsConsumed < 600)
            {
                rate = 1.80f;
                eletricityBill = unitsConsumed * rate;
            }
            else if (unitsConsumed >= 600)
            {
                rate = 2.0f;
                eletricityBill = unitsConsumed * rate;
            }

            if (eletricityBill > 400) { surcharge = eletricityBill * 0.15f; }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nHow your bill is calculated:\n" +
                "Unit Consumed                                   Charge/unit\r\n" +
                "upto 199                                              @1.20\r\n" +
                "200 and above but less than 400                       @1.50\r\n" +
                "400 and above but less than 600                       @1.80\r\n" +
                "600 and above                                         @2.00\r\n" +
                "If bill exceeds $ 400 then a surcharge of 15% will be charged\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n" +
                $"Customer IDNO: {customerId}\n" +
                $"Customer Name: {customerName}\n" +
                $"Unit Consumed: {unitsConsumed}\n" +
                $"Amount Charges @${rate.ToString("0.00")} per unit: {eletricityBill}\n" +
                $"Surchage Amount: ${surcharge.ToString("0.00")}\n" +
                $"Net Amount Paid By the Customer: ${(surcharge + eletricityBill).ToString("0.00")}\n");
            Console.ForegroundColor = ConsoleColor.White;

        TryAgain:
            try
            {
                while (true)
                {
                    // ask user if they want to try again
                    Console.WriteLine("\nWant to try again? (Y / N)");
                    char answer = char.Parse(Console.ReadLine().ToUpper());

                    // wants to continue
                    if (answer == 'Y')
                    {
                        goto StartPoint1;
                    }

                    // does not want to continue
                    else if (answer == 'N')
                    {
                        break;
                    }

                    // invaid entry
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nEnter valid character");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvaild Answer Choice\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto TryAgain;
            }
            #endregion

            #region Part2
            Transition(); Part(2); StartPoint2:

            /* Write a program in C# Sharp to count the frequency of each element of an array.
            Test Data :
            Input the number of elements to be stored in the array :3
            Input 3 elements in the array :
            element - 0 : 25
            element - 1 : 12
            element - 2 : 43
            Expected Output :
            Frequency of all elements of array :
            25 occurs 1 times
            12 occurs 1 times
            43 occurs 1 times

            You may consider another array to store the frequencies.*/


            Console.Write("\nInput the number of elements to be stored in the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element - {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Dictionary<int, int> frequency = new Dictionary<int, int>();

            for (int i = 0; i < size; i++)
            {
                if (frequency.ContainsKey(array[i]))
                {
                    frequency[array[i]]++; // increment frequency
                }
                else
                {
                    frequency[array[i]] = 1; // if it doesn't exits, initializes with 1
                }
            }


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nFrequency of all elements of array:");
            foreach (var num in frequency)
            {
                Console.WriteLine($"{num.Key} occures {num.Value} times.");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

        TryAgain2:
            try
            {
                while (true)
                {
                    // ask user if they want to try again
                    Console.WriteLine("\nWant to try again? (Y / N)");
                    char answer = char.Parse(Console.ReadLine().ToUpper());

                    // wants to continue
                    if (answer == 'Y')
                    {
                        goto StartPoint2;
                    }

                    // does not want to continue
                    else if (answer == 'N')
                    {
                        break;
                    }

                    // invaid entry
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nEnter valid character");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvaild Answer Choice\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto TryAgain2;
            }
            #endregion

            Transition(); Part(3); StartPoint3:
            /*

            3. Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

            An input string is valid if:

            Open brackets must be closed by the same type of brackets.
            Open brackets must be closed in the correct order.
            Every close bracket has a corresponding open bracket of the same type.
            
            Example 1:
            Input: s = "()"
            Output: true

            Example 2:
            Input: s = "()[]{}"
            Output: true

            Example 3:
            Input: s = "(]"
            Output: false*/

            Console.WriteLine("\nGiven an input containing just the characters '(', ')', '{', '}', '[' and ']', \nI will tell you if the string has a opening and closing bracket");

            Console.Write("Enter Brackets: ");
            string s = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine(bracketCheck(s));
            Console.ForegroundColor = ConsoleColor.White;

            TryAgain3:
            try
            {
                while (true)
                {
                    // ask user if they want to try again
                    Console.WriteLine("\nWant to try again? (Y / N)");
                    char answer = char.Parse(Console.ReadLine().ToUpper());

                    // wants to continue
                    if (answer == 'Y')
                    {
                        goto StartPoint3;
                    }

                    // does not want to continue
                    else if (answer == 'N')
                    {
                        break;
                    }

                    // invaid entry
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nEnter valid character");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvaild Answer Choice\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto TryAgain3;
            }
            ClosingMessage(); Console.ReadKey();
        }

        static bool bracketCheck(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> closeToOpen = new Dictionary<char, char> {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
            };

            foreach (char c in s)
            {
                if (closeToOpen.ContainsKey(c))
                {
                    if (stack.Count > 0 && stack.Peek() == closeToOpen[c])
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }

            return stack.Count == 0;
        }
    }
}

