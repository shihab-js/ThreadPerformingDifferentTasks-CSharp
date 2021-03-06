using System;
using System.Threading;


public class MyThread
{
    public static void Thread1()
    {
        Console.WriteLine("This is task one!");
    }

    public static void Thread2()
    {
        Console.WriteLine("This is task two!");
    }
}

namespace ThreadPerformingDifferentTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //create threads
            Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));
            Thread t2 = new Thread(new ThreadStart(MyThread.Thread2));

            //start all threads
            t1.Start();
            t2.Start();

        }
    }
}
