using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initial_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "Ahmad";
            int age = 25;

            Console.WriteLine($"My name is {name} and I am {age} years old");
            //------------------------------------------------------------------------------------------------

            Console.Write("Enter a number: ");
            // ReadLine returns a string, so we must parse it into an integer
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }

            //------------------------------------------------------------------------------------------------
            //-Create console application that read string from user and print the same string

            Console.Write("Type something and press Enter: ");
            string userInput = Console.ReadLine();

            Console.WriteLine($"You typed: {userInput}");

            //------------------------------------------------------------------------------------------------
            //Write a C# program that checks if a number is positive, negative, or zero using if.

            Console.Write("Enter a number: ");
            int numberx = int.Parse(Console.ReadLine());

            if (numberx > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (numberx < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            //------------------------------------------------------------------------------------------------
            //Write a program that checks if a year is a leap year using if

            Console.Write("Enter a year (e.g., 2024): ");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }

            //------------------------------------------------------------------------------------------------
            //Create a program that takes a student's grade and prints "Pass" or "Fail" using if.

            Console.Write("Enter student grade: ");
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 50)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            //------------------------------------------------------------------------------------------------
            //Write a program that finds the أكبر رقم بين رقمين باستخدام if.

            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"The largest number is: {num1}");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"The largest number is: {num2}");
            }
            else
            {
                Console.WriteLine("Both numbers are equal.");
            }

            //------------------------------------------------------------------------------------------------
            //Write a program that checks if a number is divisible by 5 and 3 using if.

            Console.Write("Enter a number: ");
            int numberd = int.Parse(Console.ReadLine());

            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine($"{numberd} is divisible by both 3 and 5.");
            }
            else
            {
                Console.WriteLine($"{numberd} is NOT divisible by both 3 and 5.");
            }

            //------------------------------------------------------------------------------------------------
            //Create a program that checks if a character is a vowel or consonant using if.

            Console.Write("Enter a single letter: ");
            // Read the input, convert it to lowercase, and parse it as a char
            char ch = char.Parse(Console.ReadLine().ToLower());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine($"{ch} is a vowel.");
            }
            else
            {
                Console.WriteLine($"{ch} is a consonant.");
            }

            //------------------------------------------------------------------------------------------------
            //Write a program that takes age as input and determines if the person is a child, teenager, or adult using if.

            Console.Write("Enter the age: ");
            int uage = int.Parse(Console.ReadLine());

            if (uage >= 0 && uage <= 12)
            {
                Console.WriteLine("This person is a Child.");
            }
            else if (uage >= 13 && uage <= 19)
            {
                Console.WriteLine("This person is a Teenager.");
            }
            else if (uage >= 20)
            {
                Console.WriteLine("This person is an Adult.");
            }
            else
            {
                Console.WriteLine("Invalid age entered.");
            }

            //------------------------------------------------------------------------------------------------
            //Write a C# program that uses switch to print the day name based on a number (1–7).

            Console.Write("Enter a number (1-7): ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    // The default block runs if none of the cases match
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                    break;
            }

            //------------------------------------------------------------------------------------------------
            //Create a program using switch to display the month name based on user input(1–12).

       Console.Write("Enter a month number (1-12): ");

            // Reading the input from the console and parsing it into an integer
       int monthNumber = int.Parse(Console.ReadLine());

            if (monthNumber > 0 && monthNumber <= 12)
            {
                switch (monthNumber)
                {
                    case 1:
                        Console.WriteLine("January");
                        break;
                    case 2:
                        Console.WriteLine("February");
                        break;
                    case 3:
                        Console.WriteLine("March");
                        break;
                    case 4:
                        Console.WriteLine("April");
                        break;
                    case 5:
                        Console.WriteLine("May");
                        break;
                    case 6:
                        Console.WriteLine("June");
                        break;
                    case 7:
                        Console.WriteLine("July");
                        break;
                    case 8:
                        Console.WriteLine("March");
                        break;
                    case 9:
                        Console.WriteLine("September");
                        break;
                    case 10:
                        Console.WriteLine("October");
                        break;
                    case 11:
                        Console.WriteLine("Novmeber");
                        break;
                    case 12:
                        Console.WriteLine("December");
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }

            //------------------------------------------------------------------------------------------------
            //Write a program that uses switch to perform basic calculator operations(+, -, *, /).

            Console.Write("Enter first number: ");
            double numa = double.Parse(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            char op = char.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double numb = double.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine($"Result: {numa + numb}");
                    break;
                case '-':
                    Console.WriteLine($"Result: {numa - numb}");
                    break;
                case '*':
                    Console.WriteLine($"Result: {numa * numb}");
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Result: {numa / numb}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }

            //------------------------------------------------------------------------------------------------
            //Create a program that uses switch to categorize a grade(A, B, C, D, F).
            Console.Write("Enter grade (A, B, C, D, F): ");
            char uGrade = char.ToUpper(char.Parse(Console.ReadLine()));

            switch (uGrade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Pass");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid grade entered.");
                    break;
            }

            //------------------------------------------------------------------------------------------------
            //Write a program that takes a number(1–3) and prints a message using switch.

            Console.Write("Choose a path (1, 2, or 3): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose the forest path.");
                    break;
                case 2:
                    Console.WriteLine("You chose the mountain trail.");
                    break;
                case 3:
                    Console.WriteLine("You chose the river boat.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                    break;
            }

            //------------------------------------------------------------------------------------------------
            //Convert an if condition(even / odd check) into a switch statement.

            Console.Write("Enter a number: ");
            int numbe = int.Parse(Console.ReadLine());

            // Math.Abs ensures we only deal with 0 or 1, even if the number is negative
            switch (numbe % 2)
            {
                case 0:
                    Console.WriteLine("The number is even.");
                    break;
                case 1:
                    Console.WriteLine("The number is odd.");
                    break;
            }

            //------------------------------------------------------------------------------------------------
            //Write a program that checks login role(Admin, User, Guest) using switch.

            Console.Write("Enter your role (Admin, User, Guest): ");
            string role = Console.ReadLine().ToLower();

            switch (role)
            {
                case "admin":
                    Console.WriteLine("Welcome, Admin. You have full system access.");
                    break;
                case "user":
                    Console.WriteLine("Welcome, User. You have standard access.");
                    break;
                case "guest":
                    Console.WriteLine("Welcome, Guest. You have read-only access.");
                    break;
                default:
                    Console.WriteLine("Unknown role.");
                    break;
            }

            //------------------------------------------------------------------------------------------------
            //Create a menu - driven program using switch that lets the user choose different options.

            //Console.WriteLine("--- Main Menu ---");
            //Console.WriteLine("1. View Profile");
            //Console.WriteLine("2. Edit Settings");
            //Console.WriteLine("3. Logout");
            Dictionary<int, string> menu = new Dictionary<int, string>()
        {
            { 1, "View Profile" },
            { 2, "Edit Settings" },
            { 3, "Logout" }
        };

            Console.WriteLine("--- Main Menu ---");

            // 2. Use a foreach loop to display the dictionary contents dynamically
            foreach (KeyValuePair<int, string> item in menu)
            {
                
                Console.WriteLine($"{item.Key}. {item.Value}");
            }

            Console.Write("Please select an option (1-3): ");
            int uChoice = int.Parse(Console.ReadLine());

            switch (uChoice)
            {
                case 1:
                    Console.WriteLine("Displaying user profile...");
                    break;
                case 2:
                    Console.WriteLine("Opening settings menu...");
                    break;
                case 3:
                    Console.WriteLine("Logging out... Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid selection. Returning to main menu.");
                    break;
            }


            //------------------------------------------------------------------------------------------------
            //------------------------------------------------------------------------------------------------
            //A company gives bonuses based on employee performance rating:

            Console.Write("Enter employee performance rating (0-100): ");

            // Read the user input and convert it to an integer
            int rating = int.Parse(Console.ReadLine());

            // Check the rating against the defined ranges
            if (rating >= 90 && rating <= 100)
            {
                Console.WriteLine("Performance Level: Excellent");
                Console.WriteLine("Bonus: 20%");
            }
            else if (rating >= 75 && rating <= 89)
            {
                Console.WriteLine("Performance Level: Very Good");
                Console.WriteLine("Bonus: 15%");
            }
            else if (rating >= 60 && rating <= 74)
            {
                Console.WriteLine("Performance Level: Good");
                Console.WriteLine("Bonus: 10%");
            }
            else if (rating >= 0 && rating < 60)
            {
                Console.WriteLine("Performance Level: Needs Improvement");
                Console.WriteLine("Bonus: No bonus");
            }
            else
            {
                Console.WriteLine("Invalid rating entered. Please enter a number between 0 and 100.");
            }

            //------------------------------------------------------------------------------------------------
            //A student is eligible for university admission if:

            Console.Write("Enter GPA: ");
            double gpa = double.Parse(Console.ReadLine());

            Console.Write("Passed English test? (true/false): ");
            bool passedEnglish = bool.Parse(Console.ReadLine());

            Console.Write("Has special recommendation? (true/false): ");
            bool hasRecommendation = bool.Parse(Console.ReadLine());

            // The student needs (GPA >= 85 AND English) OR (Recommendation)
            if ((gpa >= 85 && passedEnglish) || hasRecommendation)
            {
                Console.WriteLine("Eligible for admission.");
            }
            else
            {
                Console.WriteLine("Not eligible for admission.");
            }

            //------------------------------------------------------------------------------------------------
            //A shipping company calculates delivery cost:

            Console.Write("Enter package weight in kg: ");
            double weight = double.Parse(Console.ReadLine());

            if (weight <= 1)
            {
                Console.WriteLine("Shipping cost: $5");
            }
            else if (weight <= 5)
            {
                Console.WriteLine("Shipping cost: $10");
            }
            else if (weight <= 10)
            {
                Console.WriteLine("Shipping cost: $20");
            }
            else if (weight > 10)
            {
                Console.WriteLine("Shipping cost: $50");
                Console.WriteLine("Warning: Heavy package!");
            }
            else
            {
                Console.WriteLine("Invalid weight.");
            }
            //------------------------------------------------------------------------------------------------
            //A login system checks:


            //List<string> users = new List<string>();
            //users.Add("ds");

            List<User> users = new List<User>()  //User class
            {
                new User {Username = "Ahmad", Password= "123"},
                new User {Username = "Abd", Password = "321"},
                new User {Username = "Mohammed", Password= "213"},
                new User {Username = "Hamed", Password = "231"},

            };

            int attempts = 0;
            bool loginSuccess = false;
            Console.WriteLine("Enter your username");
            string nameInput = Console.ReadLine();

            Console.WriteLine("Enter your password");
            string passwordInput = Console.ReadLine();

            foreach (User u in users)
            {
                if (u.Username == nameInput && u.Password == passwordInput)
                {
                    loginSuccess = true;
                    break;
                }
            }
            if (loginSuccess)  Console.WriteLine("Login successful! Welcome to the system.");
            
            else  Console.WriteLine("Invalid username or password.");
            
        }


        class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }



    }
}
