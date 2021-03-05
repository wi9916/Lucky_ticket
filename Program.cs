using System;
using System.Collections.Generic;

namespace Lucky_ticket
{
    
    class Program
    {     
        static void Main(string[] args)
        {
            while(true)
                Ticket();
        }      
        static void Ticket()
        {

            int number = 0;
            List<short> num = new List<short>();
            double leftNumber = 0, rightNumber = 0;
            bool CorrectNumber = false;

            while(!CorrectNumber)
            {
                Console.Write("Enter you number: ");
                var consoleRead = Console.ReadLine();
                if (consoleRead.Length < 9 && consoleRead.Length > 3) 
                {   try
                    { number = Convert.ToInt32(consoleRead); CorrectNumber = true; }
                    catch { Console.WriteLine("Incorrect input"); }
                }
                else { Console.WriteLine("Incorrect input"); }
            }

            while (number > 0)
            {
                num.Add((short)(number % 10));
                number = (int)(number / 10);
            }

            if (num.Count % 2 != 0) { num.Add(0); }
            num.Reverse();
            Console.Write("You number is: ");
            foreach (var n in num)
                Console.Write(n);

            for(int i = 0; i < num.Count; i++)
            {
                if (i < num.Count / 2) { leftNumber += num[i]; }
                else { rightNumber += num[i]; }
            }

           // Console.WriteLine("   {0}/{1}", leftNumber,rightNumber);

            if (leftNumber == rightNumber)
            { Console.WriteLine("\nIt's luccky ticket"); }
            else { Console.WriteLine("\nIt's unluccky ticket"); }

            Console.ReadKey();
            Console.Clear();
        }       
    }
}
