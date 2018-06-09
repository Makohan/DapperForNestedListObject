using System.Collections.Generic;

namespace TryDapper.Models.Supports
{
    public class Class
    {
        public string ClassCode { get; set; }
        public string ClassName { get; set; }
        public IList<Student> Students { get; set; }

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
}