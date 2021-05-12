using System;
using System.Collections;
using System.Collections.Generic;
using Demo.Pages;

namespace Demo
{
    class Runner
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<Type, string>();

            dict.Add(typeof(MainPage), "MainPage");
            dict.Add(typeof(Page1Ai), "Dynamico");
            dict.Add(typeof(Page1B), "Dynamico2");
            
            Console.WriteLine();

            //new DemoProgram().Run();
        }
    }
}
