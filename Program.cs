using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LoopsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Loops in C#

            //for
            //do-while
            //while
            //foreach
            //for(initial value; condition; changevalue) {Body of loop}

            //break;
            //continue;

            /*for (int i = 1; i <= 100; i++)
            {
                if(i%5==0) { break;
                }
                Console.WriteLine(i+"\t");
            }*/

            /*for(int i=1; i<=100;i++)
            {
                if (i % 5 == 0) { continue; }
                Console.WriteLine(i + "\t");
            }*/

            // Table of any number

            /*int num;
            string choice;
            do
            {
                Console.WriteLine("Enter number to find out table of the number");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine($"Table of {num} as follows");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{num}*{i}=\t{(num * i)}");
                }
                Console.WriteLine("Do you wanna learn more \n If yes press y \n To Exit press any other key");
                choice = Console.ReadLine().ToLower();

            }
            while (choice == "y");*/

            //Practice exercise 

            /* Create C# Console App

             Take user name and user's password and print "invalid user' if user name is not admin1256 and password admin@1256@1256.

             If username password is not given then it will print "please provide username and password",

             If correct then print 'Sign Success".

             Write the code for all three scenario.

             Share: Code in Chat!!! using if else*/

            /* Console.WriteLine("Enter username: ");
             string username = Console.ReadLine();

             Console.WriteLine("Enter password: ");
             string password = Console.ReadLine();

             if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
             {
                 Console.WriteLine("Please provide a username and password.");
             }
             else if (username == "admin1256" && password == "admin@1256@1256")
             {
                 Console.WriteLine("Sign-in success");
             }
             else
             {
                 Console.WriteLine("Invalid user.");
             }

             Console.ReadLine();
            */

            /*var myNum = 12;
            var myString = "Sam";
            var status = true;
            var grade = 'A';
            Console.WriteLine("Value store in myNum is: " + myNum + "\n Data Type:" + myNum.GetType());
            Console.WriteLine("Value store in myString is: " + myString + "\n Data Type:" + myString.GetType());
            Console.WriteLine("Value store in Status is: " + status + "\n Data Type:" + status.GetType());
            Console.WriteLine("Value store in Grade is: " + grade + "\n Data Type:" + grade.GetType());
            Console.ReadKey();
            */
            //var myNum = 12;
            //dynamic myDynamic = 45;
            //Console.WriteLine("Value stored in myDynamic is: " + myDynamic + "\n Datatype Store is:\t" + myDynamic.GetType());
            //myDynamic = "I am Sam";
            //Console.WriteLine("Value stored in myDynamic is: " + myDynamic + "\n Datatype Store is:\t" + myDynamic.GetType());
            //myDynamic = 'A';
            //Console.WriteLine("Value stored in myDynamic is: " + myDynamic + "\n Datatype Store is:\t" + myDynamic.GetType());
            //Console.WriteLine("Value stored in myNum is: " + myNum + "\n Datatype Store is:\t" + myNum.GetType());
            //Console.ReadKey();

            //try
            //{
            //    double num1, num2, result;
            //    Console.WriteLine("Enter First Number");
            //    num1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Second Number");
            //    num2 = int.Parse(Console.ReadLine());
            //    result = num1 / num2;
            //    Console.WriteLine($"Result after dividing{num1} by {num2}is =\t{result}");

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error!!!"+ex.Message);
            //}
            //finally
            //{
            //    Console.ReadKey();
            //}


            //try parse example

            //try
            //{
            //    Console.WriteLine("Please Enter a Number");
            //    string input = Console.ReadLine();

            //    if(int.TryParse(input,out int result))
            //    {
            //        Console.WriteLine("Parsed Number using intTryParse is: \t" + result);

            //    }
            //    else
            //    {
            //        Console.WriteLine("Failed to Parse");
            //    }

            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Error!!!"+ex.Message);
            //}
            //finally
            //{
            //    Console.ReadKey();
            //}

            //double num1, num2, result;
            //Console.WriteLine("Enter First number");
            //double.TryParse(Console.ReadLine(), out num1);
            //Console.WriteLine("Enter Second number");
            //double.TryParse(Console.ReadLine(), out num2);
            //result = num1 / num2;
            //Console.WriteLine($"Result after dividing{num1} by {num2} is=\t {result}");
            //Console.ReadKey();

            try
            {
                string input = null;
                int tryParsedInt;
                int.TryParse(input,out tryParsedInt);
                // int parsedNumber = int.Parse(input);
                // Console.WriteLine("Parsed Number is: \t"+parsedNumber);

                //int convertedNumber = Convert.ToInt32(input);
                //Console.WriteLine("Convert Number is: \t"+convertedNumber);
                //Console.WriteLine("TryParsed Number is" +tryParsedInt);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!!"+ex.Message);

            }
            finally
            {
                Console.ReadKey();
            }


        }
    }
}
