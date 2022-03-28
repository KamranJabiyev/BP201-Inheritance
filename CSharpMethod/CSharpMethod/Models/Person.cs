using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMethod
{
    class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public Person father;

        public Person()
        {

        }
        public Person(string name,string surname,int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public virtual void Detail()
        {
            Console.WriteLine($"person-{Name} {Surname} {Age}");
        }
    }
}
