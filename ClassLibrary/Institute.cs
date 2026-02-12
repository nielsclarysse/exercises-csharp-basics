namespace ClassLibrary;

public class Institute
{
    public string Name { get; set; }
    public List<Group> Groups { get; set; } = new List<Group>();

    public Institute(string name) => Name = name;

    public void ShowInfo()
    {
        Console.WriteLine($"--- {Name} Overview ---");
        foreach (var group in Groups)
        {
            Console.WriteLine(group.ToString());
            Console.WriteLine(new string('-', 20));
        }
    }
}