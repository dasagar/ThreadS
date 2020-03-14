using System;
using System.Threading;

namespace BackGroundThread
{
    class Program
    {
        static void Main(string[] args)
        {
            BackgroundTest shortTest = new BackgroundTest(11);
            Thread foregroundThread = new Thread(new ThreadStart(shortTest.RunLoop));
            foregroundThread.Name = "foregroundThread";
            foregroundThread.Start();
            BackgroundTest longTest = new BackgroundTest(100);
            Thread backgroundThread = new Thread(new ThreadStart(longTest.RunLoop));
            backgroundThread.Name = "backgroundThread";
            backgroundThread.IsBackground = true;
            backgroundThread.Start();

            for ( int i=0;i<100; i++)
            {
                Console.WriteLine("Hi From Main Method");
            }
            //Console.ReadLine();
        }

        class BackgroundTest
        {
            int maxIterations;

            public BackgroundTest(int maxIterations)
            {
                this.maxIterations = maxIterations;
            }

            public void RunLoop()
            {
                for (int i = 0; i < maxIterations; i++)
                {
                    Console.WriteLine("{0} count: {1}",
                    Thread.CurrentThread.Name, i);
                    Thread.Sleep(250);
                }
                Console.WriteLine("{0} finished counting.",
                                  Thread.CurrentThread.Name);
            }
        }
    }
}
