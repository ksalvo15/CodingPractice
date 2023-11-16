using System;


//Given a month as an integer from 1 to 12, return to which quarter of the year it belongs as an integer number.
//For example: month 2(February), is part of the first quarter; month 6(June), is part of the second quarter; and month 11 (November), is part of the fourth quarter.
//Constraint:
//1 <= month <= 12

namespace YearsQuarter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input the number of what month it is");            
            int userinput = Convert.ToInt32(Console.ReadLine());
            if (userinput <= 3)
            {
                Console.WriteLine("It is quarter 1");
            }

            else if (3 < userinput && userinput <= 6)
            {
                Console.WriteLine("It is quarter 2");
            }

            else if (6 < userinput && userinput <= 9)
            {
                Console.WriteLine("It is quarter 3");
            }

            else if (9 < userinput && userinput <= 12)
            {
                Console.WriteLine("It is quarter 4");
            }
            else
            {
                Console.WriteLine("that wa not a positive whole integer please try again");
            }

               
        }
    }
}
