using System;
using System.Collections;
using System.Collections.Generic;

//prompt - find the needle in the array and make it say it appears at position 6

namespace FindNeedle
{
    class Program
    {
        static void Main()
        {            
            FindNeedle();
        }
        static void FindNeedle()
        {
            Console.WriteLine("Hello World!");

            List<string> needlelist = new List<string> { "hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk" };

            int needleindex = needlelist.IndexOf("needle");

            if (needleindex != -1)
            {
                Console.WriteLine("Found the needle at position {0}", needleindex +1);
            }


            else { 
                Console.WriteLine("I need not find the needle"); 
            }

            
        }
    }
}
