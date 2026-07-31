using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace arrayTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"[{string.Join(",", nonRepeatingSub(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 2, 8, 5 }))}]");
            //Console.WriteLine($"[{string.Join(",", nonRepeatingSubArray(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 2, 8, 5 }))}]");
            //Console.WriteLine($"[{string.Join(",", equalDistanceArr(new int[] { 1, 2, 8, 1, 2, 5 }))}]");

            //var splitArrays = arraySplitter(new int[] { 1, 1, 8, 2, 2, 2, 5 });
            //Console.WriteLine($"[{string.Join(", ", splitArrays.Select(innerArray => $"[{string.Join(",", innerArray)}]"))}]");

            //if (almostSorted(new int[] { 1, 2, 8, 1, 2, 5 })) Console.WriteLine("yes"); else Console.WriteLine("No");

            //Console.WriteLine($"[{string.Join(",", stableSegment(new int[] { 1, 2, 2, 3, 1, 2 }))}]");
            //Console.WriteLine($"[{string.Join(",", duplicateWindow(new int[] { 1, 2, 8, 1, 2, 5 }))}]");
            //Console.WriteLine($"[{string.Join(",", arrayConverter(new int[] { 5, 7, 10 }))}]");
            //Rearranger (new int[] { -5, 7,-1, 10 ,4,5,-6,0,-1,-9 }) ;
            //equalPoint(new int[] { 1, 1, 1,2, 3 });
            Console.WriteLine(increasingSequence(new int[] { 3, 1, 2, 5, 4, 6 }));
            Console.WriteLine(increasingSequencc(new int[] { 3, 1, 2, 5, 4, 6 }));
        }

        //--------------------------------------------------------------------
        //First Non-Repeating Subarray

        static int[] nonRepeatingSub(int[] arr)
        {
            List<int> subArr = new List<int>();

            HashSet<int> newSet = new HashSet<int>();
            int[] finalArray = { };

            for (int i = 0; i < arr.Length - 2; i++)
            {

                for (int j = i; j <= i + 2; j++)
                {
                    newSet.Add(arr[j]);
                }

                int thirdNum = arr[i + 2];

                if (newSet.Count == 3)
                {
                    finalArray = newSet.ToArray();
                    return finalArray;
                }

                else if (newSet.Count == 2)
                {
                    if (newSet.ElementAt(1) != thirdNum)
                    {
                        finalArray = newSet.ToArray();
                        return finalArray;
                    }
                }

                newSet.Clear();
            }
            return finalArray;
        }

        //--------------------------------------------------------------------
        static int[] nonRepeatingSubArray(int[] arr)
        {
            HashSet<int> newSet = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                newSet.Clear();

                for (int j = i; j < arr.Length; j++)
                {
                    bool isAdded = newSet.Add(arr[j]);

                    if (isAdded == false)
                    {
                        break;
                    }

                    if (newSet.Count >= 2)
                    {
                        return newSet.ToArray();
                    }
                }
            }
            return new int[] { };
        }

        //--------------------------------------------------------------------
        //Find elements that appear with equal distance between occurrences.

        static int[] equalDistanceArr(int[] arr)
        {
            List<int> newArr = new List<int>();
            int[] newr = { };


            for (int i = 0; i < arr.Length; i++)
            {
                if (i + 2 < arr.Length)
                {

                    int firstNum = arr[i];
                    int secondNum = arr[i + 1];

                    for (int j = i + 2; j < arr.Length; j++)
                    {
                        if (arr[j] == firstNum && arr[j + 1] == secondNum)
                        {
                            Console.WriteLine("Match");

                            for (int k = i; k <= j + 1; k++)
                            {
                                newArr.Add(arr[k]);

                            }
                            newr = newArr.ToArray();
                        }
                    }
                }
            }


            return newr = newArr.ToArray();
        }

        //--------------------------------------------------------------------
        //Split array into chunks where values change.

        static List<int[]> arraySplitter(int[] arr)
        {

            List<int[]> arrayList = new List<int[]>();
            List<int> splitList = new List<int>();

            splitList.Add(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    arrayList.Add(splitList.ToArray());
                    splitList.Clear();
                }

                splitList.Add(arr[i]);
            }

            arrayList.Add(splitList.ToArray());
            return arrayList;
        }

        //--------------------------------------------------------------------
        //Check if array can be sorted by swapping only one pair.

        static bool almostSorted(int[] arr)
        {
            int[] sortedArr = (int[])arr.Clone();
            Array.Sort(sortedArr);
            int replaceCounter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != sortedArr[i])
                {
                    if (replaceCounter > 1)
                        return false;

                    replaceCounter++;
                }
            }

            return true;
        }

        //--------------------------------------------------------------------
        //Find longest subarray where difference between max and min ≤ 1

        static int[] stableSegment(int[] arr)
        {
            List<int> subArr = new List<int>();

            int min = arr[0];
            int max = 0;
            int newArrIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];

                if (arr[i] > max)
                    max = arr[i];


                if (max - min > 1)
                {
                    newArrIndex = i;
                    break;
                }

            }

            for (int i = 0; i <= newArrIndex; i++)
            {
                subArr.Add(arr[i]);
            }
            return subArr.ToArray();
        }


        //--------------------------------------------------------------------

        //Find smallest window that contains duplicate elements.
        static List<int> duplicateWindow(int[] arr)
        {

            List<int> newArr = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        Console.WriteLine("Match");

                        for (int k = i; k <= j; k++)
                        {
                            newArr.Add(arr[k]);

                        }
                        return newArr;
                    }
                }
            }

            return newArr;
        }


        //--------------------------------------------------------------------
        //Create new array: new[i] = arr[i] - arr[i - 1]

        static int[] arrayConverter(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            newArr[0] = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                newArr[i] = (arr[i] - arr[i - 1]);
            }

            return newArr;
        }

        //--------------------------------------------------------------------
        //Rearrange so positives and negatives alternate.

        static void Rearranger (int[] arr) {

            int[] newArr = new int[arr.Length];

            List<int> posArr = new List<int>();
            List<int> negArr = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    negArr.Add(arr[i]);

                else
                    posArr.Add(arr[i]);
            }
            posArr.Sort();
            negArr.OrderBy(n => n).ToList().Reverse();

            bool isNeg = false;

            for (int i = 0; i < arr.Length; i++)
            {

                if ( (!isNeg && posArr.Count > 0 ) || negArr.Count == 0)
                {
                    newArr[i] = posArr[0];
                    posArr.RemoveAt(0);
                }
                else
                {
                    newArr[i]= negArr[0];
                    negArr.RemoveAt(0);
                }

                isNeg = !isNeg;
            }
            Console.WriteLine($"[{string.Join(",", newArr)}]");

        }


        //--------------------------------------------------------------------
        //Find index where prefix sum equals suffix sum.

        static void equalPoint (int[] arr)
        {
           int midPoint = 0;
            int mid;

            for (int i = 1; i < arr.Length; i++)
            {
                int preixSum = 0;
                int suffixSum = 0;

                for (int j = 0; j < i ; j++)
                {
                    preixSum += arr[j];
                }

                for (int k = i + 1; k < arr.Length; k++)
                {
                    suffixSum += arr[k];

                }

                if (suffixSum == preixSum) { 
                    midPoint = i;
                    mid = arr[i];
                    break;
                }
            }

            if (midPoint != 0)
                Console.WriteLine($" index is {midPoint} and value is {arr[midPoint]}");

            else
                Console.WriteLine("There is no equal point");

        }

        //--------------------------------------------------------------------
        //Find longest increasing sequence(not necessarily in order)

        static int increasingSequence(int[] arr) { // Not accurate

            int sequanceLength = 1;



            for (int i = 0; i < arr.Length - 1; i++)

            {

                if (arr[i] < arr[i + 1]) sequanceLength++;

            }

            return sequanceLength;
        }

            //--------------------------------------------------------------------
            static int increasingSequencc (int[] arr)  { //someThingi swrong

            if (arr.Length == 0) return 0;


            int currentLength = 1;
            int maxLength = 1;

            for (int i = 0; i < arr.Length -1; i++)
            {
                if (arr[i] < arr[i + 1]) currentLength++;
                else
                {
                    if (maxLength < currentLength) 
                        maxLength = currentLength;

                    currentLength = 1;
                }
            }

            if (currentLength > maxLength)
                maxLength = currentLength;

            return maxLength;
        }

    }
}
