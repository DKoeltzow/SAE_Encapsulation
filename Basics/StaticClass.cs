using System;

namespace Basics
{
    // If you want to force members to be static, make the class static.
    static class StaticClass
    {
        // Static members belongs to the type, not to a specific object.
        public static string Text = "Static text";

        static StaticClass()
        {
            Console.WriteLine("StaticClass constructor called");
        }
    }
}
