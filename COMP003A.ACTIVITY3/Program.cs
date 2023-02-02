/*
 * Author: Xavier Leftridge
 * Course: COMP-003A
 * Purpose: To learn conditional statements
*/

using System.Transactions;

namespace LECTURE3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;


            string Numeric;
            Console.Write("Enter a numeric grade (0-100):");
            Numeric = Console.ReadLine();
            double numericGrade = Convert.ToDouble(Numeric);

            if (numericGrade >= 0 && numericGrade <= 100)
            {
                if (numericGrade >= 90)
                {
                    Console.WriteLine("Letter Grade: A");
                }
                else if (numericGrade >= 80)
                {
                    Console.WriteLine("Letter Grade:B");
                }
                else if (numericGrade >= 70)
                {
                    Console.WriteLine("Letter Grade:C");
                }
                else if (numericGrade >= 60)
                {
                    Console.WriteLine("Letter Grade:D");
                }
                else 
                {
                    Console.WriteLine("Letter Grade:F");
                }


            }

            string Day;
            Console.Write("Enter an integer day of the week (1-7):");
            Day = Console.ReadLine();
            int numericDay = Convert.ToInt32(Day);

            switch (numericDay) 
            {
                case 1:
                    Console.WriteLine("String Day: Monday");
                    break;
                case 2:
                    Console.WriteLine("String Day: Tuesday");
                    break;
                case 3:
                    Console.WriteLine("String Day: Wednesday");
                    break;
                case 4:
                    Console.WriteLine("String Day: Thursday");
                    break;
                case 5:
                    Console.WriteLine("String Day: Friday");
                    break;
                case 6:
                    Console.WriteLine("String Day: Saturday");
                    break;
                case 7:
                    Console.WriteLine("String Day: Sunday");
                    break;
            }





        }
    }
}
