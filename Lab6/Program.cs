namespace Lab6;

using System;

class Car
{
  public string model;
  public string color;
  public int year;

  // Example method to display car details. You can use this as an example for the other methods.
  public void Display()
  {
    Console.WriteLine("Car Details:");
    Console.WriteLine("Model: " + model);
    Console.WriteLine("Color: " + color);
    Console.WriteLine("Year: " + year);
  }
}

class Program
{
  static void Main()
  {
    // Creating a Car object and assigning values to its properties
    Car myCar = new Car();
    myCar.model = "Civic";
    myCar.color = "Black";
    myCar.year = 2020;

    myCar.Display(); // Calling the Display method
    
    //Problem 1: Add a Method with No Parameters
    myCar.Start();   // Calling the Start method
    
    //Problem 2: Add a Method with Parameters
    myCar.Drive(50); // Calling the Drive method with a parameter
    
    //Problem 3: Add a Method with a Return Value
    string description = myCar.GetDescription();
    Console.WriteLine(description);
    
    //Problem 4: Add a Method that Updates a Field
    myCar.Repaint("Red"); // Calling the Repaint method
    Console.WriteLine($"The car has been repainted to {myCar.color}.");
  }
}

