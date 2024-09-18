using System;

// Create an interface called IQuittable
interface IQuittable
{
    void Quit();
}

// Modify the Employee class to inherit from the IQuittable interface
class Employee : IQuittable
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Implement the Quit() method defined in the IQuittable interface
    public void Quit()
    {
        Console.WriteLine("Employee quitting...");
        // Add any additional logic or actions you want to perform when an employee quits
    }
}

class Program
{
    static void Main()
    {
        // Create an object of type IQuittable using polymorphism
        IQuittable quittable = new Employee();

        // Call the Quit() method on the IQuittable object
        quittable.Quit();
    }
}
