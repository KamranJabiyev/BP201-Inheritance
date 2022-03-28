using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMethod
{
    class Student:Person
    {
        //constructor - 
        public Student():this("Ibrahim","Isgenderov")
        {
            
            Console.WriteLine("Student created");
        }

        public Student(string name,string surname)
        {
            Surname = surname;
        }
        public Student(string name,string surname,int age):this(name,surname)
        {
            Age = age;
        }
        
    }
}
