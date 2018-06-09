using System.Collections.Generic;

namespace TryDapper.Models.Supports
{
    public class Grade
    {
        public string GradeCode { get; set; }
        public string GradeName { get; set; }
        public IList<Class> Classes { get; set; }

        public override bool Equals(object obj)
        {
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
}