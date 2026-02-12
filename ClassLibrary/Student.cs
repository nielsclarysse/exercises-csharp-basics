namespace ClassLibrary;

public class Student : Person
{
    public string StudentNumber { get; set; }
    public string Trajectory { get; set; }

    public Student(string firstName, string lastName, string studentNumber, string trajectory) : base(firstName, lastName)
    {
        StudentNumber = studentNumber;
        Trajectory = trajectory;
    }

    public override string ToString() => $"[Student] {base.ToString()} (#{StudentNumber}, {Trajectory})";
}