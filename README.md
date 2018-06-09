# DapperForNestedListObject

## What this?

You have entity like below...

```
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string ClassCode { get; set; }
        public string ClassName { get; set; }
        
        public string GradeCode { get; set; }
        public string GradeName { get; set; }
    }
```

If you want to map to these classes by Dapper

```
    public class Grade
    {
        public string GradeCode { get; set; }
        public string GradeName { get; set; }
        public List<Class> Classes { get; set; }
    }

    public class Class
    {
        public string ClassCode { get; set; }
        public string ClassName { get; set; }
        public List<Person> Persons { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

```

This sample source will be helpfull for you !!
