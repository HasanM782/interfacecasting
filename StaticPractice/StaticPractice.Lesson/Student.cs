using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticPractice.Lesson
{
    internal class Student
    {
      public string Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Id: {Id}");
        }

    }
}
