using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gpaCalculator_AttaUllahKhan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter No of Subjects: ");
            int TS = int.Parse(Console.ReadLine());
            Console.Write("Enter No of Labs: ");
            int TL = int.Parse(Console.ReadLine());
            string[] Subject = new string[TS];
            string[] Labs = new string[TL];
            double[] Marks = new double[TS + TL];
            double[] credithours = new double[TS + TL];
            double[] TGPA = new double[TS + TL];

            for (int i = 0; i < TS; i++)
            {
                Console.Write("Enter Subject " + (i + 1) + " : ");
                Subject[i] = Console.ReadLine();
                Console.Write("Enter " + Subject[i] + " Marks: ");
                Marks[i] = double.Parse(Console.ReadLine());
                Console.Write("Enter " + Subject[i] + " Credit Hours: ");
                credithours[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < TL; i++)
            {
                Console.Write("Enter LAB " + (i + 1) + " : ");
                Labs[i] = Console.ReadLine();
                Console.Write("Enter " + Labs[i] + " Lab Marks: ");
                Marks[i + TS] = double.Parse(Console.ReadLine());
                credithours[i + TS] = 1;
            }

            for (int i = 0; i < (TS + TL); i++)
            {
                if (Marks[i] >= 85 && Marks[i] <= 100)
                {
                    TGPA[i] = 4 * credithours[i];
                }
                else if (Marks[i] >= 80 && Marks[i] <= 84)
                {
                    TGPA[i] = 3.7 * credithours[i];
                }
                else if (Marks[i] >= 75 && Marks[i] <= 79)
                {
                    TGPA[i] = 3.3 * credithours[i];
                }
                else if (Marks[i] >= 70 && Marks[i] <= 74)
                {
                    TGPA[i] = 3 * credithours[i];
                }
                else if (Marks[i] >= 65 && Marks[i] <= 69)
                {
                    TGPA[i] = 2.7 * credithours[i];
                }
                else if (Marks[i] >= 61 && Marks[i] <= 64)
                {
                    TGPA[i] = 2.3 * credithours[i];
                }
                else if (Marks[i] >= 58 && Marks[i] <= 60)
                {
                    TGPA[i] = 2 * credithours[i];
                }
                else if (Marks[i] >= 55 && Marks[i] <= 57)
                {
                    TGPA[i] = 1.7 * credithours[i];
                }
                else if (Marks[i] > 50 && Marks[i] <= 54)
                {
                    TGPA[i] = 1.5 * credithours[i];
                }
                else
                {

                }

            }
            double GPA = 0;
            double TC = 0;
            for (int i = 0; i < TS + TL; i++)
            {
                GPA = GPA + TGPA[i];
                TC = TC + credithours[i];
            }
            double ClassGpa = GPA / TC;
            Console.WriteLine();
            Console.WriteLine("         **********         ");
            Console.WriteLine("Your Current GPA is: " + ClassGpa);
            Console.ReadLine();
        }
    }
}

