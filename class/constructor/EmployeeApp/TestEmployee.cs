class TestEmployee
{
    public static void Main(string[] args)
    {
        Employee e1 = new Employee(101, "Ram", 5678f);
        Employee e2 = new Employee(102, "Sita", 4567f);
        e1.display();
        e2.display();
    }
}
