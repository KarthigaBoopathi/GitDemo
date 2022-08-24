using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //q1 
            /*int a, b, minimum, maximum;
            Console.Write("Enter the value of a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of b: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
                maximum = a;
            else
                maximum = b;
            if (a < b)
                minimum = a;
            else
                minimum = b;
            Console.WriteLine("Using if-else...");
            Console.WriteLine("Minimum number = {0}", minimum);
            Console.WriteLine("Maximum number = {0}", maximum);
            Console.ReadLine();*/


            //q2
            /*int num1, num2, num3;
            Console.Write("Input the number 1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the number 2 :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the number 3:");
            num3 = Convert.ToInt32(Console.ReadLine());
                        if (num1 > num2)
                        {
                            if (num1 > num3)
                            {
                                Console.Write("The 1st Number is the greatest among three. \n\n");
                            }
                            else
                            {
                                Console.Write("The 3rd Number is the greatest among three. \n\n");
                            }
                        }
                        else if (num2 > num3)
                            Console.Write("The 2nd Number is the greatest among three \n\n");
                        else
                            Console.Write("The 3rd Number is the greatest among three \n\n");
                        Console.ReadLine();*/


            //q3
            /* char ch1;
             char ch2;
             Console.Write("Enter a character: ");
             ch1 = Console.ReadLine()[0];
             Console.Write("Enter another character: ");
             ch2 = Console.ReadLine()[0];
             if (ch1 == ch2)
                 Console.WriteLine("Input characters are the same");
             else
                 Console.WriteLine("Input characters are not the same");
                 Console.ReadLine();*/


            //q4
            /*string s1;
            string s2;

            Console.WriteLine("Enter the first string:");
            s1 = Console.ReadLine();
            Console.WriteLine("Enter the second string : ");
            s2 = Console.ReadLine();

            if (s1.Equals(s2))

                Console.WriteLine("Both string are equal");
            else
                Console.WriteLine("string are not equal");
                Console.ReadLine();*/

            //q5

            /* int num1, num2;
             Console.WriteLine("Enter first number:");
             num1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter second number:");
             num2 = Convert.ToInt32(Console.ReadLine());
             if (num1 > num2)
                 Console.WriteLine("First number is bigger than second number", num1);
             else
                 Console.WriteLine("Second number is bigger than first number",num2);
             Console.ReadLine();*/

            //q6
            /*int year;
            Console.WriteLine("Enter Year : ");
             year = int.Parse(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0)) Console.WriteLine("{0} is a Leap Year.", year);
            else Console.WriteLine("{0} is not a Leap Year.", year);
            Console.ReadLine();*/

            //q7

            /* int a, b, c;
             Console.WriteLine("Enter the First subject mark:");
             a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter the second subject mark:");
             b = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter the Third subject mark:");
             c = Convert.ToInt32(Console.ReadLine());
             int Totalmark = a + b + c;
             Console.WriteLine("total_marks=" + " " + Totalmark);
             float per = Totalmark / 3;
             if (per < 35)
             {
                 Console.WriteLine("fail");
                 Console.ReadLine();
             }
             else if (per > 35 && per < 45)
             {
                 Console.WriteLine("Third ");
                 Console.ReadLine();
             }
             else if (per > 45 && per < 60)
             {
                 Console.WriteLine("Second ");
                 Console.ReadLine();
             }
             else
             {
                 Console.WriteLine("First");
             }
             Console.ReadLine(); */


            //q8
            /* int rows;
             Console.Write("Enter number of rows :");
             rows = Convert.ToInt32(Console.ReadLine());
             for (int i = 1; i <= rows; i++)
             {
               for (int j = 1; j <= i; j++)
               {
                Console.Write("*");
                 }
             Console.WriteLine("\n");
              }
             Console.ReadLine(); */

            //q9
            /* int i, n, sum = 0;
             Console.Write("Display the sum of n odd natural number:\n");
             Console.Write("\n\n");

             Console.Write("Input number of terms : ");
             n = Convert.ToInt32(Console.ReadLine());
             Console.Write("\nThe odd numbers are :");
             for (i = 1; i <= n; i++)
             {
                 Console.Write("{0} ", 2 * i - 1);
                 sum += 2 * i - 1;
             }
             Console.Write("\nThe Sum of odd Natural Number upto {0} terms : {1} \n", n, sum);
             Console.ReadLine(); */

            //q10

            /* int num, r, sum = 0, s;
            Console.Write("Reverse order:\n");
            Console.Write("\n\n");


            Console.Write("Input a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (s = num; s != 0; s= s / 10)
            {
                r = s % 10;
                sum = sum * 10 + r;
            }
            Console.Write("The number in reverse order is : {0} \n", sum);
            Console.ReadLine();*/

            //q11

            /* int sum = 0;
             for (int i = 100; i <= 200; i++)
             {

                 sum = sum + i;
             }
             Console.Write(sum);
             Console.ReadLine(); */

            //q12
            /* int i, sum = 0;
             Console.Write("Numbers between 100 and 200, divisible by 9 : \n");
             for (i = 101; i < 200; i++)
             {
                 if (i % 9 == 0)
                 {
                     Console.Write("{0}  ", i);
                     sum += i;
                 }
             }
             Console.Write("\n\nThe sum : {0} \n", sum);
             Console.ReadLine(); */


            //q13

             /* int num;
              Console.WriteLine("Enter the number:");
              num= Convert.ToInt32(Console.ReadLine());
              if (num== 0)
              {
                  Console.WriteLine("IT IS ZERO");
              }
              else if (num > 100)
              {
                  Console.WriteLine("Too large");
              }
              else if (num / 10 == 0)
              {
                  Console.WriteLine("multiple of 10");
              }
              else if (num%2 == 0)
              {
                  Console.WriteLine("it is even");
              }
              else
              {
                  Console.WriteLine("it is odd");
              }
              Console.ReadLine(); */

            //q14
           /* int num;
            Console.WriteLine("Enter the number:");
            num= Convert.ToInt32(Console.ReadLine());
            switch (num == 0)
            {
                case true:
                    Console.WriteLine("given inuput is zero");
                    break;
                case false:
                    if (num % 2 == 0)
                    {
                        Console.WriteLine("given input is even");
                    }
                    else
                    {
                        Console.WriteLine("given input is odd");
                    }
                    break;
            }
            Console.ReadLine(); */

            //q15

            /* int a, b;
             for ( a = 0, b = 25; a <= 25 & b >= 0; a++, b--)
             {
                 if (a > b)
                 {
                     Console.WriteLine("It's crossed");
                     break;

                 }
                 else
                 {
                     Console.Write(a);
                     Console.WriteLine(b);
                 }
             }
             Console.ReadLine(); */

            //q16
            int score = 100,i;
            string input;
            Console.WriteLine("Enter given input hit or miss:");
            for (i = 0; i <= 3; i++)
            {
                input = Console.ReadLine();
                if (input == "hit")
                {
                    score = score + 10;
                }
                else if (input == "miss")
                {
                    score = score - 20;
                }
            }
            Console.WriteLine(score);
            Console.ReadLine();








        }
    }
}
