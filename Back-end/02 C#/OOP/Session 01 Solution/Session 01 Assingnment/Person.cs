﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_01_Assingnment
{
    public struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor to initialize the struct
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
