using System;

class Program
{
    static void Main()
    {
        Task1();
        Task2();
        Task3();
    }

    // завдання 1
    static void Task1()
    {
        Console.WriteLine("Завдання 1");

        Product product = new Product();
        product.Name = "Ноутбук";
        product.Price = 25000;
        product.Quantity = 3;

        decimal total = product.GetTotalPrice();
        Console.WriteLine(product.Name + ": " + product.Quantity + " шт. x " + product.Price + " грн = " + total + " грн");
    }

    // завдання 2
    static void Task2()
    {
        Console.WriteLine("Завдання 2");

        Employee employee = new Employee();
        employee.FirstName = "Олексій";
        employee.LastName = "Кирик";
        employee.Position = "Розробник";
        employee.Salary = 20000;

        Console.WriteLine(employee.FirstName + " " + employee.LastName + " (" + employee.Position + "), зарплата: " + employee.Salary + " грн");

        employee.IncreaseSalary(5000);
        Console.WriteLine("Після підвищення: " + employee.Salary + " грн");
    }

    // завдання 3
    static void Task3()
    {
        Console.WriteLine("Завдання 3");

        BankAccount account1 = new BankAccount();
        account1.AccountId = "UA001";
        account1.OwnerName = "Олексій Кирик";
        account1.Deposit(1000);

        BankAccount account2 = new BankAccount();
        account2.AccountId = "UA002";
        account2.OwnerName = "Марія Іванова";
        account2.Deposit(200);

        Console.WriteLine(account1.AccountId + " (" + account1.OwnerName + "): " + account1.Balance + " грн");
        Console.WriteLine(account2.AccountId + " (" + account2.OwnerName + "): " + account2.Balance + " грн");

        account1.Withdraw(300);
        Console.WriteLine("Після зняття 300 грн з " + account1.AccountId + ": " + account1.Balance + " грн");

        account1.Transfer(500, account2);
        Console.WriteLine("Після переказу 500 грн на " + account2.AccountId + ":");
        Console.WriteLine(account1.AccountId + ": " + account1.Balance + " грн");
        Console.WriteLine(account2.AccountId + ": " + account2.Balance + " грн");

        account2.Withdraw(10000);
    }
}
