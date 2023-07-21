using System;
namespace Starting
{
    class Intro
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("hello world");
            //String fname = Console.ReadLine();
            //String lname = Console.ReadLine();
            //int num1=int.Parse(Console.ReadLine());
            //int num2=int.Parse(Console.ReadLine());
            //int sum = num1 + num2;

            //Console.WriteLine("hello  {0} {1} {2}" ,fname ,lname,sum);
            DateTime dt= DateTime.Now;
            Console.WriteLine("{0:d}", dt);
            Console.WriteLine("{0:D}", dt);
            Console.WriteLine("{0:f}", dt);
            Console.WriteLine("{0:F}", dt);
            Console.WriteLine("{0:g}",dt);
            Console.WriteLine("{0:G}", dt);
            Console.WriteLine("{0:M}", dt);
            Console.WriteLine("{0:t}", dt);
            Console.WriteLine("{0:T}", dt);
            Console.WriteLine("{0:Y}", dt);
            Console.WriteLine("{0:yy}", dt);
        }
    }
}
