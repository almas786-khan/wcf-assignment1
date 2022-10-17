using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            
            string newString="",choice="", s1 = "", s2="";
            int number,result;
            while (!choice.Equals("6"))
            {
                Console.WriteLine("\n\t\tWCF Assignment 1");
                Console.WriteLine("1. Prime Number.");
                Console.WriteLine("2. Sum of Digits.");
                Console.WriteLine("3. Reverse a string.");
                Console.WriteLine("4. Print HTML Tags.");
                Console.WriteLine("5. Sort 5 numbers");
                Console.WriteLine("6. Exit");
                Console.WriteLine("\t Enter your choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter a number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        result = client.CheckPrime(number);
                        if (result == 0)
                        {
                            Console.WriteLine("{0} is not a prime number", number);
                        }
                        else
                        {
                            Console.WriteLine("{0} is  a prime number", number);
                        }
                       
                        break;

                    case "2":
                        Console.Write("Enter the Number : ");
                        number = Convert.ToInt32(Console.ReadLine());
                        result = client.Sum(number);
                        Console.WriteLine($"The Sum of Digits is : {result}");
                        break;

                    case "3":
                        Console.Write("Enter a String : ");
                        string originalString = Console.ReadLine();
                        string reverseString = client.ReverseString(originalString);
                        Console.Write($"Reverse String is : {reverseString} ");
                        break;

                    case "4":
                        Console.Write("Input Tag : ");
                        string tag = Console.ReadLine();
                        Console.WriteLine("Enter a string : ");
                        s1 = Console.ReadLine();
                        newString = client.HTMLTag(tag, s1);
                        Console.Write($"Output is : {newString} ");
                        break;

                    case "5":
                        Console.WriteLine("Enter sorting order(asce or desc) : ");
                        string sortOrder = Console.ReadLine();
                        Console.Write("Enter the 5 numbers to be Sorted : ");
                        s2 = Console.ReadLine();
                        int[] numberArray = s2.Split(',').Select(str => int.Parse(str)).ToArray();
                        int[] sortedNumber=client.SortNum(numberArray, sortOrder);
                        //Display the sorted values one by one  
                        Console.Write("\nSorted numbers :\n");
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write("{0}, ", sortedNumber[i]);
                        }
                        Console.Write("\n\n");
                        break;

                    case "6":
                        Environment.Exit(0);
                        break;
                }

            }
        }
    } }