using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopsTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //zigZag(7);
            //mirror(8);
            //centeredPyramid(5);
            //skipper(4);
            //rowSum(4);
            //rowSummation(5);
            //reverser(4);
            //hollowPyramid(7);
            //crossPattern(7);
            //DiagonalCrossPattern(8);
            //newPattern(4);
            gapPattern(4);
        }


        //Write a program to print numbers in zigzag pattern.
        public static void zigZag(int number)
        {
            int iteration = 1;
            bool isLeft = true;

            for (int j = 0; j < number; j++)
            {

                if (isLeft)
                {
                    for (int i = 1; i <= iteration; i++)
                        Console.Write(i);
                }

                else 
                {
                    for (int i = iteration; i >= 1; i--)
                        Console.Write(i);
                }

                isLeft= !isLeft;
                iteration++;
                Console.WriteLine();
                }
            }

        //--------------------------------------------------------------------
        //Write a program to print mirrored numbers.

        static void mirror(int number)
        {

            int iteration = 1;

            for (int j = 0; j < number; j++)
            {
                string space = new string(' ', number - iteration);


                for (int i = 1; i <= iteration; i++)
                        Console.Write(i);

                Console.Write(space);

                    for (int i = iteration; i >= 1; i--)
                        Console.Write(i);

                iteration++;
                Console.WriteLine();
            }
        }


        //------------------------------------------------------------------------------------------------
        //Write a program to print centered pyramid with numbers increasing then decreasing.

        static void centeredPyramid(int number)
        {

            int iteration = 1;

            for (int j = 0; j < number; j++)
            {
                string space = new string(' ', number - iteration);
                Console.Write(space);


                for (int i = 1; i <= iteration; i++)
                    Console.Write(i);


                for (int i = iteration-1 ; i >= 1; i--)
                    Console.Write(i);

                iteration++;
                Console.WriteLine();
            }
        }

        //------------------------------------------------------------------------------------------------
        //Print pattern skipping numbers.

        static void skipper(int number)
        {
            for (int i = 0; i <= number; i++) {

                int printNumber = 1; 

                for (int j = 1; j <= i + 1; j += 1)
                {
                    Console.Write(printNumber);
                    printNumber += 2;
                }


            Console.WriteLine();
        }
    }

        //------------------------------------------------------------------------------------------------
        //Each row prints sum of previous row.

        static void rowSum(int number) {

            int printNumber = 1;

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(printNumber + " ");
                }
                Console.WriteLine();

                 printNumber = printNumber*2;

            }
        }

        static void rowSummation(int number)
        {
            int rowSum = 1;
            int printNumber = 1;

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(printNumber + " ");
                    rowSum += printNumber;
                }
                Console.WriteLine();

                printNumber = rowSum;
                rowSum = 0;

            }
        }

        //------------------------------------------------------------------------------------------------
        //Each row reverses direction.

        static void reverser(int number)
        {

            bool isLeft = true;
            int iteration = 1; 

            for (int j = 0; j < number; j++)
            {

                if (isLeft)
                {
                    for (int i = 1; i <= iteration; i++)
                        Console.Write(i);
                }

                else
                {
                    for (int i = iteration; i >= 1; i--)
                        Console.Write(i);
                }

                isLeft = !isLeft;
                iteration++;
                Console.WriteLine();
            }
        }

        //------------------------------------------------------------------------------------------------
        // Hollow Pyramid Numbers Numbers only on borders.
        static void hollowPyramid(int number)
        {

            string space = new string(' ',number - 1);
            Console.WriteLine(space + 1);


            int newSpace = 1;
            for (int i = 1; i < number -1; i++)
            {
                string outerSpace = new string(' ', number-1 - i);
                string innerSpace = new string(' ', newSpace);
                Console.WriteLine(outerSpace + 1 + innerSpace + 1);

                newSpace += 2;
            }
            for (int i = 1;i < number*2 ; i++)
            {
                Console.Write(1);
            }
        }

        //------------------------------------------------------------------------------------------------
        //Print X using numbers.
        public static void crossPattern(int number)
        {
            float middest = (float)number / 2;
            int mid = (int)Math.Ceiling(middest);

            for (int j = 1; j < mid; j++)
            {
                string spaceBetween = new string(' ', number - (j * 2));

                string space = new string(' ', j - 1);

                Console.Write(space);
                Console.Write(j);
                Console.Write(spaceBetween);
                Console.Write(j);
                Console.WriteLine();
            }

            if (number % 2 != 0)
                Console.WriteLine(new string(' ', mid - 1) + mid);
            else
                Console.WriteLine(new string(' ', mid) + mid);


            for (int j = mid + 1; j <= number; j++)
            {
                string spaceBetween = new string(' ', ((j - mid) * 2) - 1);
                string space = new string(' ', number - j);

                Console.Write(space);
                Console.Write(j);
                Console.Write(spaceBetween);
                Console.Write(j);
                Console.WriteLine();

            }

        }

        //------------------------------------------------------------------------------------------------
        public static void DiagonalCrossPattern(int number)
        {
            // Outer loop controls the rows (Y axis)
            for (int row = 1; row <= number; row++)
            {
                // Inner loop controls the columns (X axis)
                for (int col = 1; col <= number; col++)
                {
                    // Check if we are on the \ diagonal OR the / diagonal
                    if (row == col || row + col == number + 1)
                    {
                        Console.Write(row); // Print the row number
                    }
                    else
                    {
                        Console.Write(" "); // Print a space everywhere else
                    }
                }

                // Move to the next line after finishing the row
                Console.WriteLine();
            }
        }


        //------------------------------------------------------------------------------------------------
        //Each row repeats number i times but increments globally.

        static void newPattern(int number)
        {
            int printNumber = 1;
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(printNumber + " ");
                    printNumber++;
                }
                Console.WriteLine();

            }
        }
        //--------------------------------------------------------------------
        //Print pattern with increasing spaces inside.
        static void gapPattern(int number) {

            int newSpace = 1;
            for (int i = 1; i <= number - 1; i++)
            {
                string innerSpace = new string(' ', newSpace);
                Console.WriteLine(1 + innerSpace + 1);

                newSpace++;
            }

            for (int i = 1; i <= number +1; i++)
            {
                Console.Write(1);
            }
        }

    }
}
