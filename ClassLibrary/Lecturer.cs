namespace ClassLibrary;
public class Lecturer : Person
{
    public string EmployerId { get; set; }

    public Lecturer(string firstName, string lastName, string employerId) : base(firstName, lastName)
    {
        EmployerId = employerId;
    }

    public override string ToString() => $"[Lecturer] {base.ToString()} (ID: {EmployerId})";
}