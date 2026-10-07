public class Employee
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Position { get; set; } = "";
    public decimal Salary { get; set; }

    public void IncreaseSalary(decimal amount)
    {
        Salary += amount;
    }
}
