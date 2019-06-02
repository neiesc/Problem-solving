using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public Student(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }

    public string Name { get; set; }
    public int Grade { get; set; }
}

public class GradeSchool
{


    private List<Student> students = new List<Student>();


    public void Add(string student, int grade)
    {
        students.Add(new Student(student, grade));
    }

    public IEnumerable<string> Roster()
    {
        return students
        .OrderBy(x => x.Grade)
        .ThenBy(x => x.Name)
        .Select(x => x.Name);
    }

    public IEnumerable<string> Grade(int grade)
    {
        return students
            .Where(x => x.Grade == grade)
            .OrderBy(x => x.Name)
            .Select(x => x.Name);
    }
}