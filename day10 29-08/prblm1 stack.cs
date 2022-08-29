using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ass_29_08_qns1
{
    internal class Class1
    {
        class MyStack<T>
        {
            int capacity;
            T[] stack;
            int top;

            public MyStack(int MaxElements)

            {

                capacity = MaxElements;

                stack = new T[capacity];



                //initialize top with -1

            }
            public int push(T Element)

            {

                //Check Overflow

                if (top == capacity - 1)

                {

                    // return -1 if over flow is there

                    return -1;

                }

                else

                {

                    // insert elementt into stack

                    top = top + 1;

                    stack[top] = Element;

                }

                return 0;

            }



            public T pop()

            {

                T RemovedElement;

                T temp = default(T);

                //check Underflow

                if (!(top <= 0))

                {

                    RemovedElement = stack[top];

                    top = top - 1;

                    return RemovedElement;

                }

                return temp;



            }



            public T peep(int position)

            {

                T temp = default(T);

                //check if Position is Valid or not

                if (position < capacity && position >= 0)

                {

                    return stack[position];

                }

                return temp;

            }



            public T[] GetAllStackElements()

            {

                T[] Elements = new T[top + 1];

                Array.Copy(stack, 0, Elements, 0, top + 1);

                return Elements;

            }

        }

        static void Main(string[] args)
        {
            int capacity;

            Console.WriteLine("Enter Capacity of Stack :");

            capacity = int.Parse(Console.ReadLine());



            MyStack<string> stack = new MyStack<string>(10);



            while (true)

            {

                Console.WriteLine("1.Push");

                Console.WriteLine("2.Pop");

                Console.WriteLine("3.Peep");

                Console.WriteLine("4.Print Stack Elements:");

                Console.WriteLine("5.Exit");



                Console.WriteLine("Enter your Choice :");


                int choice = int.Parse(Console.ReadLine());
                Console.ReadLine();


                switch (choice)

                {

                    case 1:

                        {

                            Console.WriteLine("Enter String to Push :");

                            string temp = Console.ReadLine();

                            int result = stack.push(temp);
                            Console.ReadLine();


                            if (result != -1)

                            {

                                Console.WriteLine("Element Pushed into Stack !");
                                Console.ReadLine();

                            }

                            else

                            {

                                Console.WriteLine("Stack Overflow !");
                                Console.ReadLine();

                            }

                            break;

                        }

                    case 2:

                        {

                            string Result = stack.pop();

                            if (Result != null)

                            {

                                Console.WriteLine("Delete Element :" + Result);
                                Console.ReadLine();

                            }

                            else

                            {

                                Console.WriteLine("Stack Underflow !");
                                Console.ReadLine();

                            }

                            break;

                        }



                    case 3:

                        {

                            Console.WriteLine("Enter Position of Element to Pop:");

                            int Position = int.Parse(Console.ReadLine());

                            string Result = stack.peep(Position);
                            Console.ReadLine();


                            if (Result != null)

                            {

                                Console.WriteLine("Element at Position" + Position + " is " + Result);
                                Console.ReadLine();
                            }

                            else

                            {

                                Console.WriteLine("Entered Element is Out of Stack Range ");
                                Console.ReadLine();
                            }

                            break;

                        }

                    case 4:

                        {

                            string[] Elements = stack.GetAllStackElements();

                            Console.WriteLine("*****Stack Content *****");

                            foreach (string str in Elements)

                            {

                                Console.WriteLine(str);
                                Console.ReadLine();

                            }

                            break;

                        }

                    case 5:

                        {

                            System.Diagnostics.Process.GetCurrentProcess().Kill();

                            break;

                        }

                    default:

                        {

                            Console.WriteLine("You have Entered Wrong Choice ");
                            Console.ReadLine();
                            break;

                        }

                }
            }
        }
    }
}


        
    


        
    

