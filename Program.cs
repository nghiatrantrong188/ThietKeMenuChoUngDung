// See https://aka.ms/new-console-template for more information
using System;
namespace ThietKeMenuChoUngDung
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            while(choice!=0)
            {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Ve hinh tam giac");
            Console.WriteLine("2. Ve hinh vuong");
            Console.WriteLine("3. Ve hinh chu nhat");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice: ");
            choice = Int32.Parse(Console.ReadLine());
            
                switch (choice)
                {
                case 1:
                    Console.WriteLine("Ve hinh tam giac");
                    Console.WriteLine("******");
                    Console.WriteLine("*****");
                    Console.WriteLine("****");
                    Console.WriteLine("***");
                    Console.WriteLine("**");
                    Console.WriteLine("*");
                    break;
                case 2:
                    Console.WriteLine("Ve hinh vuong");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    break;
                case 3:
                    Console.WriteLine("Ve hinh chu nhat");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("No choice!");
                    break;
                }
            }
        }
    }
}
