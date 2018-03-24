using System;

namespace Basics
{
    class MyOtherClass
    {
        // Create an instance of a class by using the new keyword
        // Instances of classes are also called objects
        // You can make multiple objects of a class
        MyClass myClassObject = new MyClass();
        MyClass anotherObject = new MyClass();

        private string text = "Text";

        // Methods have access modifiers
        private void EditObject()
        {
            // Use objects to access members or methods of a class
            myClassObject.visibleField = 100;
        }

        public void SetText(string text)
        {
            // use "this" to point to a member of a class
            this.text = text;
        }

        public void PrintObjectReference(MyClass myClass)
        {
            Console.WriteLine(myClass);
        }

        public void PrintVisibleField(MyClass myClass)
        {
            Console.WriteLine(myClass.visibleField);
        }
    }
}
