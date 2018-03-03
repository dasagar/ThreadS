﻿using System;
using System.Diagnostics;
using System.Threading;

public class Example
{
    public static void Main()
    {
        //initialize a thread class object 
        //And pass your custom method name to the constructor parameter

        Thread thread = new Thread(Speak);

        //start running your thread
        //dont forget to pass your parameter for the Speak method (ParameterizedThreadStart delegate) in start method

        thread.Start("Hello World!");

        Console.WriteLine("Press Enter to terminate!");
        Console.ReadLine();
    }

    private static void Speak(object s)
    {
        //your code here that you want to run parallel
        //most of the cases it will be a CPU bound operation

        string say = s as string;
        Console.WriteLine(say);

    }
}