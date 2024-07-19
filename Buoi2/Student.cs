using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    internal class Student
    {
        private int id;
        private string name;
        private int age;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public Student() { }

        public void Input()
        {
            Console.Write("Nhap id: ");
            id = Console.Read();
            Console.Write("Nhap ten: ");
            name = Console.Read().ToString();
            Console.Write("Nhap tuoi: ");
            age = Console.Read();
        }

        public void Output()
        {
            Console.WriteLine("ID: {0} - Name: {1} - Age: {2}", id, name, age);
        }
    }
}
