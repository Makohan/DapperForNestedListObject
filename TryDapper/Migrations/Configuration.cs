namespace TryDapper.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TryDapper.Models.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<TryDapper.Models.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TryDapper.Models.MyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var members = new List<Member>()
            {
                new Member()
                {
                    Name = "a-ko",
                    ClassCode = "A",
                    ClassName = "A-class",
                    GradeCode = "1",
                    GradeName = "1-year"
                },
                new Member()
                {
                    Name = "b-ko",
                    ClassCode = "A",
                    ClassName = "A-class",
                    GradeCode = "1",
                    GradeName = "1-year"
                },
                new Member()
                {
                    Name = "c-ko",
                    ClassCode = "B",
                    ClassName = "B-class",
                    GradeCode = "1",
                    GradeName = "1-year"
                },
                new Member()
                {
                    Name = "d-ko",
                    ClassCode = "B",
                    ClassName = "B-class",
                    GradeCode = "1",
                    GradeName = "1-year"
                },
                new Member()
                {
                    Name = "e-ko",
                    ClassCode = "A",
                    ClassName = "A-class",
                    GradeCode = "2",
                    GradeName = "2-years"
                },
            };

            context.Members.AddRange(members);
            context.Members.AddOrUpdate();
        }
    }
}
