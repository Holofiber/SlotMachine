using System;

namespace ConsoleApp1.Zuzu
{


    public class Program2
    {
        private static string text = "asd";


        public static void Run()
        {
            Func2();
        }

        public static void PrintFun(Dog someDog)
        {

            Console.WriteLine($"<<<{someDog.Name}>>>");
        }



        static Dog  tuzik = new Dog();

        public static void Func2()
        {
            Dog rex = new Dog();

            rex.Name = "Rex";
            tuzik.Name = "Tuzik";

            PrintFun(rex);
            PrintFun(tuzik);
            PrintFun(rex);
            
        }

        private static string text2 = "asd";


        public static void Func3()
        {

        }

        private static string text3 = "asd";
    }
}
