using System;
using System.Collections.Generic;
using System.Text;

namespace StudentLibrary
{
    internal class Student
    {
        private int id;
        private string name;
        private int age;
        private static int studentCount = 0;


        public int Id { 
            get { return id; } 
            private set { id = value;}
        }
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public int Age {
            get { return age; }
            set { age = value; }
        }
        public int StudentCount { 
            get {return studentCount;}
        }

        public Student() {
            id = studentCount++;
            this.name = "name";
            this.age = 1;
            
        }

        public Student(string name, int age)
        {
            id = studentCount++;
            this.name = name;
            this.age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Id: {id}, Name: {name}, Age: {age}");
        }

        public int GetOlder(int age)
        {
            age++;
            return age;
        }




    }
}
