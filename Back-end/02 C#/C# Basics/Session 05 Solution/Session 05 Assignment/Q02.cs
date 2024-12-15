using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05_Assignment
{
    class MyClass
    {
        public int Value;
    }
    internal class Q02
    {
        static void ModifyByValue(MyClass obj)
        {
            obj.Value = 20; // Changes the object's property
            obj = new MyClass { Value = 50 }; // Reassignment does not affect the original object
        }

        static void ModifyByReference(ref MyClass obj)
        {
            obj.Value = 30; // Changes the object's property
            obj = new MyClass { Value = 50 }; // Reassignment affects the original object
        }
        public static void solve()
        {
            MyClass myObj = new MyClass { Value = 10 };

            Console.WriteLine("Original Value: " + myObj.Value);

            ModifyByValue(myObj);
            Console.WriteLine("After ModifyByValue: " + myObj.Value); // Property changes, but reference stays

            ModifyByReference(ref myObj);
            Console.WriteLine("After ModifyByReference: " + myObj.Value); // Reference and property change
        }

    }
}
