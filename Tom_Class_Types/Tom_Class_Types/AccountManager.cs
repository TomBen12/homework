using System;
namespace Tom_Class_Types
{//Question 8
    public static class AccountManager
    {
        static string Type { get; set; }

        static AccountManager()
        {
            Type = "Im Static Class";
            Console.WriteLine("Im static class");
        }

        public static void Foo()
        {
            Console.WriteLine("Foo");
        }

        public static void Goo()
        {
            Console.WriteLine("goo");
        }

    }

    
}
