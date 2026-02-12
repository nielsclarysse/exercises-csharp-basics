using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary;

public class Group
{
    public string GroupName { get; set; }
    public Lecturer PrincipalLecturer { get; set; }
    public List<Student> Students { get; set; } = new List<Student>();

    public Group(string name, Lecturer principal)
    {
        GroupName = name;
        PrincipalLecturer = principal;
    }

    public override string ToString()
    {
        string studentList = string.Join("\n  - ", Students);
        return $"Group: {GroupName}\nPrincipal: {PrincipalLecturer}\nStudents:\n  - {studentList}";
    }
}