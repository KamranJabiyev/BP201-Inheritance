using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMethod
{
    class Teacher:Person
    {
        public int experience; 
        public Teacher(string name,string surname,int age,int experience):base(name,surname,age)
        {
            this.experience = experience;
        }

        public override void Detail()
        {
            Console.WriteLine($"teacher - {Name} {Surname} {Age} {experience}");
        }
    }
}
