using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyOtherClass myOtherClass = new MyOtherClass();
            MyClass myClass = new MyClass();

            MyClass mySecondClass = new MyClass();
            mySecondClass.visibleField = 100;

            MyClass myThirdClass = new MyClass("Created MyClass object with argument");

            myOtherClass.PrintObjectReference(myClass);
            
            myOtherClass.PrintVisibleField(myClass);
            myOtherClass.PrintVisibleField(mySecondClass);

            Console.WriteLine(StaticClass.Text);


            Console.Read();
        }
    }
}
