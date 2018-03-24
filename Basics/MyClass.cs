using System;

// Namespaces are used to declare a scope to group related objects.
// Declareable types: Classes, Interfaces, structs, enums, delegates and other namespaces(nested)
// Namespaces are included by the following syntax: using <namespace>
namespace Basics
{
    // Classes are used to group related objects like
    // Fields, Methods, Properties, Constructors and more.
    // Classes have access modifiers. Default is internal.
    class MyClass
    {
        // Access modifiers are used to control if types or members can be used
        // from other code in your assembly or other assemblies

        // Can be used from everywhere
        public int visibleField = 50;
       
        // Can only be used by code in same class or struct
        private int invisibleField = 50;

        // Properties are special methods called accessors.
        // They are used as public data members.
        // Properties can be declared as read/write, read-only, write-only
        public int InvisibleField
        {
            get { return invisibleField; }
            set { invisibleField = value; }
        }

        // For simple properties use the auto-implemented version
        public string MyClassText { get; set; }

        // The constructor is called when a class is created.
        // A construtor without arguments is called default constructor
        // If no default constructor is declared explicitly, C# will create one by default.
        public MyClass()
        {
            Console.WriteLine("MyClass object created");
        }

        // A constructor can have arguments
        public MyClass(string text)
        {
            Console.WriteLine(text);
        }
    }
}
