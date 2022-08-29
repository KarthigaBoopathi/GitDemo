using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_26_08_qn3
{
    internal class Program
    {
        
    public static void Main()
            {
                List<string> products = new List<string>();
                products.Add("dairymilk");
                products.Add("kitkat");
                products.Add("milkybar");
                products.Add("tobbleron");

                Console.WriteLine("Products Available:----");

                foreach (string p in products)
                {

                    Console.WriteLine(p);

                }
                Console.WriteLine("count is " + products.Count);
                Console.WriteLine("---------------------------------------");

                products.Add("munch");

                foreach (string l in products)
                {

                    Console.WriteLine(l);
                }
                Console.WriteLine("count after adding is " + products.Count);
                Console.WriteLine("---------------------------------------");

                products.Remove("munch");
                products.Remove("dairymilk");
                Console.WriteLine("count after deleting is " + products.Count);

                Console.WriteLine("products :");

                foreach (string l in products)
                {

                    Console.WriteLine(l);
                }
                Console.Read();
            }
        }
    }

