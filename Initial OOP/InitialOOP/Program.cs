using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InitialOOP
{
    internal class Program
    {

        class Person
        {
            public string Name { get; set; }

            public int Age { get; set; }


            public virtual void printInfo()
            {

                Console.WriteLine($"Person name:{Name} and age is:{Age}");
            }

        }

        sealed class Student: Person {

            public int StudentId
            {
                get
                {
                    return studentId; // When someone reads s.StudentId, give them the field
                }
                set
                {
                    // 'value' is a magic keyword in C# representing what the user typed after the '=' sign
                    if (value > 0)
                    {
                        studentId = value; // Only update the field if the ID is positive!
                    }
                    else
                    {
                        Console.WriteLine("Error: ID must be positive!");
                    }
                }
            }

            public int studentId;

            public static int studentCount=0;

            public Student(int studentId)
            {
                this.studentId = studentId;
                studentCount++;
            }

            public override void printInfo()
            {

                Console.WriteLine($"Student name: {Name}, Age: {Age}, ID: {studentId}");
            }


        }





        static void Main(string[] args)
        {
            Person pn = new Person();
            pn.Name = "Abd";
            pn.Age = 21;
            pn.printInfo();

            Person p = new Student(20222);
            p.Age = 12;
            p.Name = "Ahmad";
            p.printInfo();

            Student s = new Student(80502);
            s.Age = p.Age;
            s.Name = "Omar";
            s.printInfo();

            s.StudentId = 9846132;
            Console.WriteLine(s.Name + " " + s.StudentId);  //diffrent


            Console.WriteLine(pn.Name);
            Console.WriteLine($"Total students created: {Student.studentCount}");
        }
    }
}
