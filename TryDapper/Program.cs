using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using TryDapper.Models;
using TryDapper.Models.Supports;

namespace TryDapper
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var grades = new List<Grade>();

            using (var db = new MyDbContext())
            {
                db.Database.Connection.Query<Student, Class, Grade, Student>(
                    "select * from members",
                    (s, c, g) =>
                    {
                        if (!grades.Contains(g))
                        {
                            c.Students = new List<Student>() { s };
                            g.Classes = new List<Class>() { c };
                            grades.Add(g);
                            return s;
                        }

                        Grade grade = grades.Single(gl => gl.Equals(g));
                        if (!grade.Classes.Contains(c))
                        {
                            c.Students = new List<Student>() { s };
                            grade.Classes.Add(c);
                            return s;
                        }

                        Class clazz = grade.Classes.Single(cl => cl.Equals(c));
                        clazz.Students.Add(s);

                        return s;
                    },
                    splitOn: "ClassCode,GradeCode");
            }

            foreach (var grade in grades)
            {
                Console.WriteLine("------------");
                Console.WriteLine(grade.GradeName);
                var classes = grade.Classes.Select(c => c);
                foreach (var clazz in classes)
                {
                    Console.WriteLine("--------");
                    Console.WriteLine(clazz.ClassName);
                    var persons = clazz.Students.Select(p => p);
                    foreach (var person in persons)
                    {
                        Console.WriteLine(person.Name);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}