using System.Collections.Generic;

namespace methodChaning_LinQ
{

    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Subject> Subjects { get; set; }
    }

    public class Subject
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
                    {
                        new Student()
                        {
                            ID = 1,
                            FirstName = "ALi",
                            LastName = "Mohammed",
                            Subjects = new List<Subject>()
                            {
                                new Subject() { Code = 22, Name = "EF" },
                                new Subject() { Code = 33, Name = "UML" }
                            }
                        },
                        new Student()
                        {
                            ID = 2,
                            FirstName = "Mona",
                            LastName = "Gala",
                            Subjects = new List<Subject>()
                            {
                                new Subject() { Code = 22, Name = "EF" },
                                new Subject() { Code = 34, Name = "XL" },
                                new Subject() { Code = 25, Name = "35" }
                            }
                        },
                        new Student()
                        {
                            ID = 3,
                            FirstName = "Yara",
                            LastName ="Yousef",
                            Subjects= new List<Subject>()
                            {
                                new Subject(){Code=22,Name="F"},
                                new Subject(){Code=25,Name="15"}
                             }
                         },
                         new Student()
                         {
                             ID=1,
                             FirstName="Ali",
                             LastName="Ali",
                             Subjects=new List<Subject>()
                             {
                                 new Subject(){Code=33,Name="UML"}
                             }
                         }
            };

            var q1 = students.Select((s) => new { s.FirstName, s.LastName , s.Subjects.Count });
            foreach (var s in q1) {
                Console.WriteLine($"name==>{s.FirstName} {s.LastName} noSubjects==> {s.Count}");
            }

            var q2 = students
               .OrderByDescending(s => s.FirstName)
               .ThenByDescending(s => s.LastName)
               .Select(s => new { s.FirstName, s.LastName });
            foreach (var s in q2) { Console.WriteLine(s); }


        }
    }
}