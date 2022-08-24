using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    internal class prblm8
    {
        static void Main(string[] args)
        {
            try
            {
                int i, j,k;
                Console.WriteLine("Enter first number");
                 i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                 j = Convert.ToInt32(Console.ReadLine());
                k = i / j;
                Console.WriteLine(k);


            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(" Divide by zero exception");
                Console.WriteLine(ex.Message);

            }
            catch (StackOverflowException ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("Printed Anyway");

            }
            Console.ReadLine();
        }
        }
    }
