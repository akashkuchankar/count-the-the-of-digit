//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace count_the_the_of_digit
//{
//    internal class sum_of_digit
//    {
//        static void Main(string[] args)
//        {
//            int num, remainder, sum = 0;
//            Console.WriteLine("Enter multiple digit number ");
//            num = Convert.ToInt32(Console.ReadLine());
//            while (num > 0)
//            {
//                remainder = num % 10;
//                sum = sum + remainder;
//                num = num / 10;

//            }
//            Console.WriteLine($"sum of digit is {sum}");
//            Console.ReadKey();

//        }
//    }
//}