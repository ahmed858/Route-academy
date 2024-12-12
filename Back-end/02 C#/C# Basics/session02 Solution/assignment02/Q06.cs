using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment02
{

    public class Q06
    {
        //Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

        public static void solve()
        {

            Person person = new Person();
            Console.WriteLine(person.age);
            Console.WriteLine(person.name);

            Person person2 = person;

            person2.name = "ZEZO";
            Console.WriteLine(person.age);
            Console.WriteLine(person.name);
            /*two object refer to same place in heap*/
        }
    }
}
