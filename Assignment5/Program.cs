using System;

// Base class
class Vehicle
{
    // Internal fields
    private string registrationNumber;
    private string brand;
    private string fuelType;
    private int serviceCount;

    // Constructor (called first)
    public Vehicle(string regNo, string brand, string fuel)
    {
        //Console.WriteLine("Vehicle object initialized");
        registrationNumber = regNo;
        this.brand = brand;
        fuelType = fuel;
        serviceCount = 0;
    }

    // Protected method for inspection
    protected void PerformInspection()
    {
        Console.WriteLine("Performing inspection...");
    }

    // Public method to display info
    public void ShowInfo()
    {
        Console.WriteLine("=== Vehicle Info ===");
        Console.WriteLine("Registration Number: {0}", registrationNumber);
        Console.WriteLine(" Brand: {0}", brand);
        Console.WriteLine(" Fuel Type: {0}", fuelType);
    }

    // Private method for updating service
    private void UpdateServiceCount(int count)
    {
        serviceCount += count;
        Console.WriteLine(" Service Count Updated: {0}", serviceCount);
    }

    // Public wrapper for service count update
    public void UpdateService(int count)
    {
        UpdateServiceCount(count); // calls private helper
    }
}

// Derived class
class Car : Vehicle
{
    private string serviceHub;

    // Constructor (calls base)
    public Car(string regNo, string brand, string fuel, string hub)
        : base(regNo, brand, fuel)
    {
        //Console.WriteLine("Car object initialized");
        serviceHub = hub;
    }

    // Public method for the workflow
    public void CarMaintenanceProcess(int count)
    {
        Console.WriteLine("=== Car Maintenance Process ===");
        PerformInspection(); // protected from base
        UpdateService(count); // public from base
        ShowCompletion(); // private in derived
    }

    // Private completion step (not visible outside Car)
    private void ShowCompletion()
    {
        Console.WriteLine("Maintenance Completed at: {0}", serviceHub);
    }
}

class Program
{
    static void Main()
    {
        // Sample values for matching your image
        string regNo = "TN10AB1234";
        string brand = "Toyota";
        string fuel = "Petrol";
        string hub = "GreenTech Service Hub";

        Car myCar = new Car(regNo, brand, fuel, hub);

        myCar.ShowInfo();
        myCar.CarMaintenanceProcess(count: 4);
    }
}
