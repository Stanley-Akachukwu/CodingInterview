class EncapsulatedClass 
{
    private string location;
    private string name;
    public string Location
    {
        get
        {
            return location;
        }
        set
        {
            location = value;
        }
    }
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
}

static class Test
{
    static void Main(string [] args)
    {
        EncapsulatedClass u = new EncapsulatedClass();
        // set accessor will invoke
        u.Name = "Peter Obi";
        // set accessor will invoke
        u.Location = "LabourParty";
        // get accessor will invoke
        Console.WriteLine("Name: " + u.Name);
        // get accessor will invoke
        Console.WriteLine("Location: " + u.Location);
        Console.WriteLine("\nPress Enter Key to Exit..");
        Console.ReadLine();
    }
}
