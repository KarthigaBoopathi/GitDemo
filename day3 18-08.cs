using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_day3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //q1
            /*int no1, no2, temp;
            Console.Write("Input the First Number : ");
            no1 = int.Parse(Console.ReadLine());
            Console.Write("\n Input the Second Number : ");
            no2 = int.Parse(Console.ReadLine());
            temp = no1;
            no1 = no2;
            no2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + no1);
            Console.Write("\nSecond Number : " + no2);

            //q2

            /*int num1, num2, num3;

            Console.Write("Input the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            int result = num1 * num2 * num3;
            Console.WriteLine("Output: {0} x {1} x {2} = {3}",
            num1, num2, num3, result);

            //q3
            /*int num1=25;
            int num2=4;
            int result;
            result = num1 + num2;
            Console.WriteLine("Value is", result);
            result = num1 - num2;
            Console.WriteLine("Value is", result);
            result = num1 * num2;
            Console.WriteLine("Value is", result);
            result = num1 / num2;
            Console.WriteLine("Value is ", result);
            result = num1 % num2;
            Console.WriteLine("Value is ", result);
            result = num1++;
            Console.WriteLine("Value is", result);
            result = num1--;
            Console.WriteLine("Value is ", result);
            Console.ReadLine();

            //q4
            /*double num1, num2, num3, num4;

            Console.Write("Enter First number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Third number: ");
            num3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Fourth number: ");
            num4 = Convert.ToDouble(Console.ReadLine());

            double result = (num1 + num2 + num3 + num4) / 4;
            result = Convert.ToDouble(result);
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
            num1, num2, num3, num4, result);


            Console.ReadLine();

            //q5

            /*int num1, num2, num3;

            Console.Write("Enter first number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number:");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Result {0}, {1} and {2}, (x+y)·z is {3} and x·y + y·z is {4}\n\n",
            num1, num2, num3, ((num1 + num2) * num3), (num1 * num2 + num2 * num3));

            Console.ReadLine();

            //q6

            /*int age;
             Console.Write("Enter age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("You look younger than {0} ", age);
            Console.ReadLine();

            //q7
           /* int x;
            Console.WriteLine("Enter number:");
            x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 2; i++)
            {
             for (int j = 0; j < 4; j++)
            {
             Console.Write("{0} ", x);
            }
            Console.Write("\n");
            for (int j = 0; j < 4; j++)
            {
              Console.Write("{0}", x);
            }
              Console.Write("\n");
            }
            Console.ReadLine();*/



            //q8
            /*int x;
             Console.Write("Enter number: ");
             x = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("{0}{0}{0}", x);
             Console.WriteLine("{0} {0}", x);
             Console.WriteLine("{0} {0}", x);
             Console.WriteLine("{0} {0}", x);
             Console.WriteLine("{0}{0}{0}", x);
             Console.ReadLine();*/

            //q9
            /* int celsius;
            Console.Write("Enter value of Celsius: ");
            celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
            Console.ReadLine();*/

            //q10
            /*int x, y;
           Console.WriteLine("Input first integer:");
           x = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Input second integer:");
           y = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Check if one is negative and one is positive:");
           Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
           Console.ReadLine();*/

            //q11
            /*int x, y;
            Console.WriteLine("Input first integer:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check if both are positive:");
            Console.WriteLine(x > 0 && y > 0);
            Console.ReadLine();*/

            //q12

            /* string s1 = "Hello world!!";
             string s2 = "";
             bool b1 = string.IsNullOrEmpty(s1);
             Console.WriteLine(b1);
             Console.WriteLine(s2);
             Console.ReadLine();*/

            //q13
            /*  double m1 = 200;
              Console.WriteLine("Meter:Kilometer");
              double k1 = ConvertDistance.CMtK(m1);
              Console.WriteLine("{0}:{1}", m1, k1);
              double m4 = 3107;
              double k4 = ConvertDistance.CMtK(m4);
              Console.WriteLine("{0}:{1}", m4, k4);
              double k3 = 5.1;
              Console.WriteLine();
              Console.WriteLine("Kilometer:Meter");
              double m3 = ConvertDistance.CKtM(k3);
              Console.WriteLine("{0}:{1}", k3, m3);
              double k2 = 3.219;
              double m2 = ConvertDistance.CKtM(k2);
              Console.WriteLine("{0}:{1}", k2, m2);
              Console.ReadLine();

          }
      }
  }       


      public static class ConvertDistance
      {
          public static double CMtK(double meters)
          {
              return meters / 1000;
          }

          public static double CKtM(double kilometers)
          {
              return kilometers * 1000;*/

            //q14
            /*double fahrenheit;

             double celsius = 36;
             Console.WriteLine("Celsius: " + celsius);

             fahrenheit = (celsius * 9) / 5 + 32;
             Console.WriteLine("Fahrenheit: " + fahrenheit);

             Console.ReadLine();

             //q15
             double usd = 0;
             double inr = 0;
             double value = 0;

             Console.Write("Enter amount in USD: ");
             usd = double.Parse(Console.ReadLine());

             Console.Write("Enter the USD value :");
             value = double.Parse(Console.ReadLine());

             inr = usd * value;
             Console.WriteLine("USD " + usd + "-> INR " + inr);
             Console.ReadLine();*/

            //q16
            string first_name, last_name, userid, password;
            Console.WriteLine("Enter the Firstname:");
            first_name = Console.ReadLine();
            Console.WriteLine("Enter the Lastname:");
            last_name = Console.ReadLine();
            if (first_name == "userid" && last_name == "password")
            {
                Console.WriteLine("Successfully logged in!!!");
                Console.WriteLine("Welcome to my app");
            }
            else
            {
                Console.WriteLine("Unsucccessful. Please check userid or password");
            }
            Console.ReadLine();

        }
    }
}






    


              






