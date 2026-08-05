using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPMasteryTasks
{
    // TASK 1: Static Class (MathUtilities)
    public static class MathUtilities
    {
        public static double Square(double number) => number * number;
        public static double SquareRoot(double number) => Math.Sqrt(number);
        public static double Max(double a, double b) => Math.Max(a, b);
    }


    //----------------------------------
    // TASK 2: Static Method in a Regular Class (Converter)
    public class Converter
    {
        // Static methods belong to the class, not the object.
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double KilometersToMiles(double kilometers)
        {
            return kilometers * 0.621371;
        }
    }


    //----------------------------------
    // TASK 3: Static Field (VisitorCounter)
    public class VisitorCounter
    {
        public static int TotalVisitors = 0; // Shared across all instances 

        public VisitorCounter()
        {
            TotalVisitors++;
        }
    }


    //----------------------------------
    // TASK 4: Static Property 
    public class Company
    {
        public static string CompanyName { get; set; } // Shared by ALL employees

        public string EmployeeName { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"Employee: {EmployeeName}, Company: {CompanyName}");
        }
    }


    //----------------------------------
    // TASK 5: Polymorphism  - Method Overloading 
    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Add(int a, int b, int c) => a + b + c;
        public decimal Add(decimal a, decimal b) => a + b;
    }


    //----------------------------------
    // TASK 6: Polymorphism - Method Overriding 
    public class Animal
    {
       
        public virtual void MakeSound()   // 'virtual' allows overriding
        {
            Console.WriteLine("Animal makes a generic sound.");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound() => Console.WriteLine("Dog says: Woof!");
    }

    public class Cat : Animal
    {
        public override void MakeSound() => Console.WriteLine("Cat says: Meow!");
    }


    //----------------------------------
    // TASK 7 & TASK 10: Encapsulation 
    public class BankAccount
    {
        private decimal balance;

        public decimal Balance     // Read-only property (No set )
        {
            get { return balance; }
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: ${amount}. New Balance: ${balance}");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                Console.WriteLine($"Withdrawal Failed: Insufficient funds. Balance is ${balance}");
            }
            else if (amount > 0)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew: ${amount}. Remaining Balance: ${balance}");
            }
        }
    }

    public class Person
    {
        // Encapsulation: Private field protected by a public property
        private string socialSecurityNumber;

        public string SSN
        {
            get { return "XXX-XX-" + socialSecurityNumber.Substring(socialSecurityNumber.Length - 4); }
            set { socialSecurityNumber = value; }
        }
    }


    //----------------------------------
    // TASK 8: Abstraction 
    public abstract class Appliance
    {
        public string Brand { get; set; }

        public abstract void TurnOn();
        public abstract void TurnOff();

        public void checkBrand()   //method with body
        {
            Console.WriteLine($"Brand is {Brand}");
        }

        }

        public class WashingMachine : Appliance
    {
        public override void TurnOn() => Console.WriteLine($"[{Brand}] Washing Machine: Locking door and filling with water.");
        public override void TurnOff() => Console.WriteLine($"[{Brand}] Washing Machine: Draining water and unlocking door.");
    }

    public class AirConditioner : Appliance
    {
        public override void TurnOn() => Console.WriteLine($"[{Brand}] AC: Compressor ON, starting cooling mode.");
        public override void TurnOff() => Console.WriteLine($"[{Brand}] AC: Compressor OFF, shutting down.");
    }


    //----------------------------------
    // TASK 9: Abstract Class
    public abstract class Employee
    {
        public string Name { get; set; }
        public abstract decimal CalculateSalary();
    }

    public class FullTimeEmployee : Employee
    {
        public decimal MonthlySalary { get; set; }
        public override decimal CalculateSalary() => MonthlySalary; //overrides with a method
    }

    public class PartTimeEmployee : Employee
    {
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }
        public override decimal CalculateSalary() => HourlyRate * HoursWorked;
    }



    //----------------------------------

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- TASK 1: MathUtilities (Static Class) ---");
            Console.WriteLine($"Square of 5: {MathUtilities.Square(5)}");
            Console.WriteLine($"Square Root of 16: {MathUtilities.SquareRoot(16)}");
            Console.WriteLine($"Max of 10 and 20: {MathUtilities.Max(10, 20)}\n");

            Console.WriteLine("--- TASK 2: Converter (Static Methods) ---");
            Console.WriteLine($"25 Celsius is {Converter.CelsiusToFahrenheit(25)} Fahrenheit");
            Console.WriteLine($"10 Kilometers is {Converter.KilometersToMiles(10):F2} Miles\n");

            Console.WriteLine("--- TASK 3: VisitorCounter (Static Field) ---");
            new VisitorCounter();
            new VisitorCounter();
            new VisitorCounter();
            Console.WriteLine($"Total Visitors after 3 objects created: {VisitorCounter.TotalVisitors}\n");

            Console.WriteLine("--- TASK 4: Company (Static Property) ---");
            Company.CompanyName = "TechCorp"; // Set once for everyone
            Company emp1 = new Company { EmployeeName = "Alice" };
            Company emp2 = new Company ();
                                     emp2.EmployeeName = "John";
            emp1.PrintDetails();
            emp2.PrintDetails();
            Console.WriteLine();

            Console.WriteLine("--- TASK 5: Calculator (Method Overloading) ---");
            Calculator calc = new Calculator();
            Console.WriteLine($"Add 2 ints: {calc.Add(5, 10)}");
            Console.WriteLine($"Add 3 ints: {calc.Add(5, 10, 15)}");
            Console.WriteLine($"Add 2 decimals: {calc.Add(5.5m, 10.2m)}\n");

            Console.WriteLine("--- TASK 6: Animal (Method Overriding) ---");
            Animal myDog = new Dog();
            Animal myCat = new Cat();
            myDog.MakeSound();
            myCat.MakeSound();
            Console.WriteLine();

            Console.WriteLine("--- TASK 7: BankAccount (Encapsulation) ---");
            BankAccount account = new BankAccount();
            account.Deposit(100);
            account.Withdraw(150); // Should fail safely
            account.Withdraw(40);  // Should succeed
            Console.WriteLine($"Final Checked Balance: ${account.Balance}\n");

            Console.WriteLine("--- TASK 8: Appliance (Abstraction) ---");
            Appliance washer = new WashingMachine { Brand = "LG" };
            Appliance ac = new AirConditioner { Brand = "Samsung" };
            washer.TurnOn();
            washer.TurnOff();
            ac.TurnOn();
            ac.TurnOff();
            Console.WriteLine();

            Console.WriteLine("--- TASK 9: Employees (Abstract Class) ---");
            Employee ft = new FullTimeEmployee { Name = "Sarah", MonthlySalary = 5000m };
            Employee pt = new PartTimeEmployee { Name = "John", HourlyRate = 20m, HoursWorked = 80 };
            Console.WriteLine($"{ft.Name}'s Salary: ${ft.CalculateSalary()}");
            Console.WriteLine($"{pt.Name}'s Salary: ${pt.CalculateSalary()}");
        }
    }
}
