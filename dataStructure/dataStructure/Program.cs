using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrrNums = { 8, 3, 5, 6, 2,8, 1, 3, 9, 5 };
            List<int> listNumbers = new List<int>(arrrNums );

            //You have a list of numbers. You need to extract only even numbers.
            List<int> evenNumbers = new List<int>(arrrNums.Where(n=> n%2 ==0) ) ;
            Console.WriteLine(string.Join("",evenNumbers ));


            //A list of Unique Values Only.
            List<int> specialNumbers = new List<int>(arrrNums.Distinct());
            Console.WriteLine(string.Join("", specialNumbers));
            List<int> specialNums = new List<int>(new HashSet<int>(arrrNums));
            Console.WriteLine(string.Join("", specialNums));


            //You want to find the highest number in a list.
            Console.WriteLine(specialNums.Max() );


            //Reverse the order of elements.
            Console.WriteLine(string.Join("", arrrNums.Reverse()));

            //Display thr Sum of elements.
            Console.WriteLine( arrrNums.Sum() );


            //Sort the order of elements with linq.
            Console.WriteLine(string.Join("", arrrNums.OrderBy(n => n ) ));

            //Sort numbers from highest to lowest
            Console.WriteLine(string.Join("", arrrNums.OrderByDescending(n => n)));

            //Count Numbers Greater Than X
            Console.WriteLine(string.Join("", arrrNums.Count(n => n> 5)));

            //First Number Greater Than 5
            Console.WriteLine(string.Join("", arrrNums.First(n => n > 5)));

            //Extract odd numbers
            Console.WriteLine(string.Join("", arrrNums.Where(n => n % 2 == 1)));

            //Multiply all numbers by 2
            Console.WriteLine(string.Join("", arrrNums.Select(n => n * 2 )));



            // Dictionary : Store student names with their scores then print them .
            Dictionary<string, int> studentMark = new Dictionary<string, int>();
            studentMark.Add("Ahmad", 86); studentMark.Add("Mohammed", 94); studentMark.Add("Hamed", 72); studentMark.Add("Mahmmoud", 81);
           
            foreach (var item in studentMark)
                Console.WriteLine($"{item.Key} has marked {item.Value}");

            //User enters a name → return the score.
            if (studentMark.ContainsKey("Ahmad"))
                Console.WriteLine(studentMark[("Ahmad")]);

            //    Sum of Values : Calculate total scores.
            Console.WriteLine(studentMark.Values.Sum());

            //    Avg of Values : Calculate average of scores.
            Console.WriteLine(studentMark.Values.Average());

            //Find student with highest score
            int topMark = studentMark.Values.Max();
            Console.WriteLine("Highest mark student is " +
                             string.Join(", ", studentMark.Where(s => s.Value == topMark).Select(s => s.Key) ));

            //Remove students with score< 50
            foreach (var item in studentMark.Where(n => n.Value > 90))
                Console.WriteLine($"{item.Key} has marked {item.Value}");

            Dictionary<string, int> goodStudents = studentMark.Where(n => n.Value >= 90).
                                                                ToDictionary(n => n.Key, n => n.Value);


            //Find common numbers between two lists
            foreach (var item in specialNumbers)
            {
                if (listNumbers.Contains(item))
                    Console.Write(item+ " Matches/ ");
            }

            //Merge Two Lists Combine two lists into one
            List<int> mergedList = listNumbers.Concat(specialNumbers).ToList();

            //Filter Dictionary Keep only items where value > 100
            studentMark = studentMark.Where(n => n.Value > 70).ToDictionary(n => n.Key, n => n.Value);

            //Extract all values from Dictionary into List
            List<int> listStudentMarks = studentMark.Values.ToList();
            foreach (var mark in listStudentMarks)
                Console.Write($" marked: {mark}");

            int highestMark = studentMark.Values.Max();
            int secondHighestMark = 0;
            foreach (var item in studentMark)
            {

                //Find Second Largest Number
                if ( item.Value > secondHighestMark && item.Value != highestMark)
                    secondHighestMark = item.Value;
                
            }
            Console.WriteLine($" Highest mark is {highestMark} and second highest is {secondHighestMark}");


            //LinkedList 
            //declaration
            LinkedList<string> student = new LinkedList<string>();

            //adding nodes first & last
            student.AddFirst("Ahmad");
            student.AddLast("Abd");
            student.AddFirst("Amjad");

            //finding specific node by value
            LinkedListNode<string> ahmadNode = student.Find("Ahmad");

            //adding before and after specific node /finding next node
            student.AddAfter(ahmadNode, "Hamed");
            student.AddBefore(ahmadNode.Next , "Hamada");

            //removing node 

            //student.RemoveFirst();
            //student.RemoveLast();
            //student.Remove("Hamada");

            //printing a node
            Console.WriteLine("Here is First node " + student.First());
            Console.WriteLine("Here is Ahmad node " + ahmadNode.Value);
            Console.WriteLine("Here is Abd node "+ student.Find("Abd").Value);

            //iterrating on nodes / printing all nodes

            foreach (var item in student)
            {
                Console.WriteLine(item);
            }

            //The node-traversal loop
            LinkedListNode<string> currentNode = student.First;

            while(currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }


        }
    }
}
