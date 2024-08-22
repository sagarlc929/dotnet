public class Employee
{
    private int id;
    private String name;
    private float salary;

    public Employee(int i, String n, float s)
    {
        id = i;
        name = n;
        salary = s;
    }

    public void display()
    {
        Console.WriteLine(id + " " + name + " " + salary);
    }
}
