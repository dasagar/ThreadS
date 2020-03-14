using System;
using System.Threading;

namespace ThreadTypes
{
    class Program
    {
        // C# program to illustrate the 
        // concept of foreground thread 
        // Foreground thread -If the main thrad ends , then foreground thread continues.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Thread thread = new Thread(ForeGroundThread);
            thread.Start();
            Console.WriteLine("Main Thread Ends");
            Console.ReadLine();
        }

        // Static method 
        static void ForeGroundThread()
        {
            for (int c = 0; c <= 3; c++)
            {

                Console.WriteLine("ForeGroundThread is in progress!!");
                Thread.Sleep(1000);
            }
            Console.WriteLine("ForeGroundThread ends!!");
        }
    }
}
