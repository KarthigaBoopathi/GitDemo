using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace access_specifiers
{

   /* public abstract class person
    {

        public abstract void work();

    }
    public class employees : person
    {


        public override void work()
        {
            Console.WriteLine("Emplpoyee");
        }
    }
    public class manager : person
    {


        public override void work()
        {
            Console.WriteLine("Manager");
        }
    }
    public class clerk : person
    {


        public override void work()
        {
            Console.WriteLine("Clerk");
        }
    }

    //q2

    public interface IBank
    {

        void print_balance();
        void calc_interest();
    }
    public class bank : IBank
    {

        public double amount;

        public bank()
        {

            amount = 0;
        }

        public void print_balance()
        {
            Console.WriteLine("Enter amount");
            amount = Convert.ToDouble(Console.ReadLine());
        }
        public void calc_interest()
        {
            int i;
            Console.WriteLine("enter the interest to calculate");
            i = Convert.ToInt32(Console.ReadLine());
            double result = amount * i;
            Console.WriteLine("calc_interest " + result);
            Console.ReadLine();
        }
    }

    //q3

    public interface banks
    {

        void print_balance();
        void calc_interest();
    }
    public class savings : banks
    {

        public double amount;

        public savings()
        {

            amount = 0;
        }

        public void print_balance()
        {
            Console.WriteLine("Enter amount");
            amount = Convert.ToDouble(Console.ReadLine());
        }
        public void calc_interest()
        {
            float r = 0.18f;

            double result = amount * r;
            Console.WriteLine("calc_interest " + result);
        }
    }
    public class current : banks
    {

        public double amount;

        public current()
        {

            amount = 0;
        }

        public void print_balance()
        {
            Console.WriteLine("Enter amount");
            amount = Convert.ToDouble(Console.ReadLine());
        }
        public void calc_interest()
        {
            float r = 0.01f;

            double result = amount * r;
            Console.WriteLine("calc_interest " + result);
        }
    } */

    //q5
    public class banks
    {
        public int x, y;
        public banks()
        {
            x = 8000;
            y = 98000;
        }


    }
    public static class curr
    {

        public static void current(this banks obj)
        {
            Console.WriteLine("Current balance: " + obj.x);
        }
        public static void deposits(this banks obj)
        {
            Console.WriteLine("Enter the amount to be deposited in current account");
            int dep = Convert.ToInt32(Console.ReadLine());
            obj.x = dep + obj.x;
            Console.WriteLine("Amount deposited successfully!!");
        }
        public static void withdraw(this banks obj)
        {
            Console.WriteLine("Enter the amount to be withdrawed in current account");
            int with = Convert.ToInt32(Console.ReadLine());
            if (with < obj.x)
                obj.x = obj.x - with;
            else
            Console.WriteLine("Amount can't be withdrawn!!");
            Console.WriteLine("Amount withdrawn successfully!!");

        }
        public static void total_balc(this banks obj)
        {
            Console.WriteLine("Total balance in current account: " + obj.x);
        }
    }
    public static class sav
    {

        public static void savings(this banks obj)
        {
            Console.WriteLine("saving balance" + obj.y);
        }
        public static void deposits1(this banks obj)
        {
            Console.WriteLine("Enter the amount to be deposited in savings account:");
            int dep = Convert.ToInt32(Console.ReadLine());

            obj.y = dep + obj.y;
            Console.WriteLine("Amount Deposited successfully!!");
        }
        public static void withdraw1(this banks obj)
        {
            Console.WriteLine("Enter the amount to withdraw in savings account:");
            int with = Convert.ToInt32(Console.ReadLine());
            if (with < obj.y)
                obj.y = obj.y - with;
            else
            Console.WriteLine("Amount can't be withdrawn!");
            Console.WriteLine("Amount withdrawn successfully!!");
        }
        public static void total_balc1(this banks obj)
        {
            Console.WriteLine("Total Balance in current account :" + obj.y);
        }
    }
    }

    



