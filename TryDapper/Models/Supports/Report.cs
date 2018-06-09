using System.Collections.Generic;

namespace TryDapper.Models.Supports
{
    public class Report
    {
        public List<Grade> Grades { get; set; }
    }

    public class Grade
    {
        public string GradeCode { get; set; }
        public string GradeName { get; set; }
        public List<Class> Classes { get; set; }

        public override bool Equals(object obj)
        {
            // Check for null values and compare run-time types.
            if (obj == null || GetType() != obj.GetType())
                return false;

            Grade g = (Grade)obj;
            return (GradeCode == g.GradeCode) && (GradeName == g.GradeName);
        }

        public override int GetHashCode()
        {
            var hashCode = 780226712;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GradeCode);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GradeName);
            return hashCode;
        }
    }

    public class Class
    {
        public string ClassCode { get; set; }
        public string ClassName { get; set; }
        public List<Person> Persons { get; set; }

        public override bool Equals(object obj)
        {
            // Check for null values and compare run-time types.
            if (obj == null || GetType() != obj.GetType())
                return false;

            Class c = (Class)obj;
            return (ClassCode == c.ClassCode) && (ClassName == c.ClassName);
        }

        public override int GetHashCode()
        {
            var hashCode = -495706054;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClassCode);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClassName);
            return hashCode;
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}