using System;

interface IEmployee
{
    //Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //Methods
    public string Fullname();
    public double Pay();
}
class Employee : IEmployee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Employee()
    {
        Id = 0;
        FirstName = string.Empty;
        LastName = string.Empty;
    }
    public Employee(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }
    public string Fullname()
    {
        return FirstName + " " + LastName;
    }
    public virtual double Pay()
    {
        double salary;
        Console.WriteLine($"What is {this.Fullname()}'s weekly salary?");
        salary = double.Parse(Console.ReadLine());
        return salary;
    }

}

class Executive : Employee
{
    public string Title { get; set; }
    public decimal Salary { get; set; }

    public Executive() {
        Title = string.Empty;
        Salary = 0.0M;
    }
    public Executive(int _id, string _fname, string _lname, string _title, decimal _salary)
        : base(_id, _fname, _lname)
    {
        Title = _title;
        Salary = _salary;
    }

    public override double Pay()
    {
        return (double)Salary;
    }
}

class Program
{
    public static void Main()
    {
        Employee emp1 = new Employee(48923, "Jacob", "Ritz");
        Executive exec1 = new Executive(57815, "Richard", "Abberton", "CEO", 1423.83M);

        Console.WriteLine("Employee #{0}", emp1.Id);
        Console.WriteLine("Name: {0}", emp1.Fullname());
        Console.WriteLine("Salary (weekly): {0:C}", emp1.Pay());

        Console.WriteLine("Executive #{0}", exec1.Id);
        Console.WriteLine("Name: {0}", exec1.Fullname());
        Console.WriteLine("Salary (weekly): {0:C}", exec1.Pay());
    }
}