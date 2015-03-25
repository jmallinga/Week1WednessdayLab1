using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1WednessdayLab1
{
    class Program
    {

        //income = x 

        //5% tax is owed on the first 20k of income
        //if income < 20k then tax = 5%

        //10% tax is owed on all income over 20k
        //if income > 20k then tax = 10%

        //20% tax is owed on all income over 50k
        //if income > 50k then tax = 50k

        //35% tax is owed on all income over 75k
        //if income > 75k then tax = 75k


        static void Main(string[] args)
        {

            //Print "Enter your income to determine your tax bracket.

            Console.WriteLine("Enter your income from last year to determine your tax bracket");
            Console.ReadLine();

            //x = customer income;

            int x;

            if (x < 20000)
            {
                //Print your income is less than $20k
                Console.WriteLine("You are in the 5% tax bracket");
            }
             //else if (x < 50000)
            //{//Print your income was over $20k but less than 50k
            //    Console.WriteLine("You are in the 10% tax bracket");

            if ((x < 50000 || x > 20000));
                Console.WriteLine("You are in the 10% tax bracket");

     
            if ((x < 75000 || x > 50000));
        Console.WriteLine("You are in the 20% tax bracket");
    {}    
            if (x > 75000)
            { //Print your income was over $75k
                Console.WriteLine("You are in the 35% tax bracket");
                { }
            }

            //// if X is less than 10,
            //if (x < 10)
            //{
            //    //Print X is less than 10
            //    Console.WriteLine("X is less than 10");
            //}
            //else
            //    //Else Print X is more than 10
            //    Console.WriteLine("X is more than 10");

            //Console.WriteLine("This happens no matter what");

            //Console.ReadLine();
            //x = 15;
            //// if x is less than 10 and greater than 5
            //if ((x < 10 || x > 5))
            //    Console.WriteLine("You're above 50% there!");
            //Console.ReadLine();
            //string message = null;

            //if (message != null && message.Length > 5)
            //    Console.WriteLine(message);

            //DaysOfTheWeek today = DaysOfTheWeek.Wednessday;
            //var something = Console.ReadLine();
            //int value = int.Parse(something);
            //today = (value > -1 && value < 7) ?
            //    (DaysOfTheWeek)value :
            //    DaysOfTheWeek.Wednessday;



            //switch (today)
            //{


            //    case DaysOfTheWeek.Friday:
            //    case DaysOfTheWeek.Saturday:
            //        Console.WriteLine("It's date night!");
            //        break;


            //    case DaysOfTheWeek.Wednessday:
            //        Console.WriteLine("Guess what day it is");
            //        break;
            //    default:
            //        Console.WriteLine("We don't have a message for this day yet");
            //        break;
        }
    }
}

