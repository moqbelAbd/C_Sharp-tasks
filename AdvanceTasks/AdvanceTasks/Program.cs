using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrNums = { 1,2,3,4,5,6,7 };

            //mostRepeat(arrNums);
            //rotationPuzzle(arrNums, 13);
            //if (checkPalindrome(new int[] { 1, 2, 3,3, 2, 1 })) Console.WriteLine("Is Palindrome"); else Console.WriteLine("Is not Palindrome");
            //Console.WriteLine(missinNumber(new int[] { 1,2,3,4,5}) );
            //BalancedSplit(arrNums);
            //Console.WriteLine (string.Join (", ", LongestSequance(new int[] { 7, 8, 9, 0, 1, 2, 3, 5, 6, 7, 8, 9 })) );
            //Console.WriteLine(ShortestDuplicateDistance(arrNums));
            //Console.WriteLine(string.Join(", ", EvenOddArr(arrNums)));
            //Console.WriteLine(string.Join(", ", PeaksFinder(arrNums)));
            //TwoSum(arrNums, 2);
            //Console.WriteLine(string.Join(", ", ShiftZeros(new int[] { 0,7, 8, 9, 0, 1, 2, 3, 5, 6, 0, 7, 8, 9, 0 })));
            //Console.WriteLine(string.Join(", ", AlternatingMerge(new int[] {1,3,5,7,9 } , new int[] { 2,4,6,8 })));
            //CountFrequencies(arrNums);
            //SecondMaximum(arrNums);
            //Console.WriteLine(string.Join(", ", SubarraySum(arrNums, 20)));
            //Console.WriteLine(string.Join(", ", ReversePartArr(arrNums, 2,5)));
            //Console.WriteLine(SwapstoSort(new int[] { 1, 4, 3, 2, 5 ,10 ,8 }));
            //Console.WriteLine(string.Join(", ", TrickyReordering(arrNums)));
            //Console.WriteLine(string.Join(", ", LongestRepeatingPattern(new int[] { 1,2,3,4,2,3,5,6,7,5,6,7,2,3 })));
            Console.WriteLine(string.Join(", ", RemoveItem(arrNums, 2)));

        }

        static void mostRepeat(int[] arrNums)
        {

            Dictionary<int, int> numbersCount = new Dictionary<int, int>();

            //Find the number that appears the most using loops
            foreach (var item in arrNums)
            {
                if (numbersCount.ContainsKey(item))
                    numbersCount[item]++;

                else numbersCount.Add(item, 1);
            }

            int maxCount = 1;
            int maxCountNumber = 0;
            foreach (var item in numbersCount)
            {
                if (item.Value > maxCount)
                {
                    maxCount = item.Value;
                    maxCountNumber = item.Key;
                }
            }
            Console.WriteLine($"most repeated number is {maxCountNumber} with {maxCount} times");

        }


        //You have an array, and you need to rotate it to the right by N steps.
        static void rotationPuzzle(int[] arr,int steps)
        {
            int[] rotatedArr = new int[arr.Length];

            if (steps != arr.Length)
            {

                int index = 0;

                for (int i = steps; i < arr.Length; i++)
                {
                    rotatedArr[i] = arr[index];
                    index++;
                }

                index = arr.Length - 1;

                for (int i = 0; i < steps; i++)
                {
                    rotatedArr[i] = arr[index];
                    index--;
                }
            }

            else rotatedArr = arr;

            Console.WriteLine(string.Join("", rotatedArr));
        }

        //Check if a list is symmetric(Palindrome).
        static bool checkPalindrome(int[] arr)
        { 

            for (int i = 0 , reverseIndex = arr.Length - 1; i < arr.Length; i++ , reverseIndex--)
            {
                if (arr[i] != arr[reverseIndex])
                    return false;
            }
            return true;
        }

        //You have an array containing numbers from 1 to N, but one number is missing.
        static int missinNumber (int[] arr)
        {
            int missng = 0;

            for (int i = 0; i < arr.Length -1; i++)
            {
                if (arr[i] != arr[i + 1] - 1)
                    return missng = arr[i] + 1;
            }
            return missng;
        }
        //------------------------------------------------------------------------
        static int MissingNumber(int[] arr)
        {
            int n = arr.Length + 1;

            int expectedSum = n * (n + 1) / 2;

            int actualSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                actualSum += arr[i];
            }
            return expectedSum - actualSum;
        }


        //Split a list into two parts such that the difference between their sums is minimal.
        static void BalancedSplit (int[] arr)
        {
            int minDiffrence = 1000;
            int splitIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j <= i; j++)
                {
                    leftSum += arr[j];
                }


                for (int j = arr.Length -1 ; j > i; j--)
                {
                    rightSum += arr[j];
                }

                int currentDiffrence = Math.Abs(leftSum - rightSum);
                if (currentDiffrence < minDiffrence){
                    minDiffrence = currentDiffrence;
                     splitIndex = i;
                    }
            }
            Console.WriteLine($"The minium Diffrence is {minDiffrence} when splitting at index {splitIndex}");
        }


        //Find the longest increasing continuous sequence.
        static int [] LongestSequance (int[] arr)
        {
            if (arr.Length == 0) return new int[0];

            int longestStreak = 1;
            int currentStreak = 1;

            int bestStartIndex = 0; 
            int currentStartIndex = 0;

            for (int i = 0; i < arr.Length -1; i++)
            {
                if (arr[i] + 1 == arr[i + 1])
                    currentStreak++;

                else
                {

                    if (currentStreak > longestStreak) { 
                        longestStreak = currentStreak;
                        bestStartIndex = currentStartIndex;
                      }

                    currentStreak = 1;
                    currentStartIndex = i + 1;
                }
            }

            if (currentStreak > longestStreak)
            {
                longestStreak = currentStreak;
                bestStartIndex = currentStartIndex;
            }

            int[] result = new int[longestStreak];

            for (int i = 0; i < longestStreak; i++)
            {
                result[i] = arr[bestStartIndex];
                bestStartIndex++;

            }            return result;
        }

        //Find the shortest distance between two identical numbers.
        static int ShortestDuplicateDistance(int[] arr)
        {
            Dictionary<int, int> lastSeen = new Dictionary<int, int>();

            int minDistance = 20;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];

                if (lastSeen.ContainsKey(currentNumber))
                {
                    int distance = i - lastSeen[currentNumber];

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                    }
                }

                lastSeen[currentNumber] = i; //update value or create one
            }

            return minDistance == int.MaxValue ? -1 : minDistance;
        }

        //Reorder by Rule :order even numbers then odd numbers 
        static List<int> EvenOddArr (int[]  arr )
        {

            List <int> reOrderedArr = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    reOrderedArr.Add(arr[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                    reOrderedArr.Add(arr[i]);
            }

            return reOrderedArr;
        }

        //Find all elements that are greater than their neighbors.
        static List<int> PeaksFinder(int[] arr)
        {

            List<int> peakArr = new List<int>();

            for (int i = 1; i < arr.Length -1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                    peakArr.Add(arr[i]);
            }

            return peakArr;
        }


        //Find two numbers whose sum equals a target with one loop.
        static void twoSum(int[] arr, int target)
        {

            int firstNum = 0;
            int secondNum = 0;

            for (int i = 0; i < arr.Length ; i++)
            {
                int secondNumFounder = target - arr[i];
                int foundIndex = Array.IndexOf(arr, secondNumFounder);
                if (firstNum == 0 && foundIndex != i && arr.Contains(secondNumFounder))
                    firstNum = arr[i];               //foundIndex != -1 insted of contains(better)


                else if ((firstNum != 0 && (firstNum + arr[i] == target) ))
                    secondNum = arr[i];
            }

            Console.WriteLine($"First number is {firstNum} and second number is {secondNum}");
        }

        static void TwoSum(int[] arr, int target)
        {
            HashSet<int> seenNumbers = new HashSet<int>();

            foreach (int currentNum in arr)
            {
                int neededNum = target - currentNum;

                if (seenNumbers.Contains(neededNum))
                {
                    Console.WriteLine($"First number is {neededNum} and second number is {currentNum}");
                    return; 
                }

                seenNumbers.Add(currentNum);
            }

            Console.WriteLine("No matching pair found.");
        }

        //Move all zeros to the end of the list
        static List<int> ShiftZeros (int[] arr)
        {

            List<int> shiftedArr = new List<int>(arr);
            for (int i = 0; i < shiftedArr.Count; i++)
            {
                if (shiftedArr[i] == 0)
                {
                    int tempValue = shiftedArr[i];
                    shiftedArr.RemoveAt(i);
                    shiftedArr.Add(tempValue);
                }
            }

            return shiftedArr;
        }

        //Merge two arrays alternately
        static int[] AlternatingMerge (int[] arr1 , int[] arr2)
        {
            int[] mergedArr = new int[arr1.Length + arr2.Length];

            bool isFirst = true;
            int firstCounter = 0;
            int secondCounter = 0;

            for (int i = 0; i < mergedArr.Length; i++)
            {
                if (isFirst)
                {
                    mergedArr[i] = arr1[firstCounter];
                    firstCounter++;
                }
                else
                {
                    mergedArr[i] = arr2[secondCounter];
                    secondCounter++;
                }
                isFirst = !isFirst;
            }
            return mergedArr;
        }

        //Count Frequencies Without Dictionary
        static void CountFrequencies (int[] arr)
        {
            List<int> listArr = new List<int>(arr);
            List<int> countedNums = new List<int>();

            foreach (var item in listArr)
            {
                if (!countedNums.Contains(item)) {
                    Console.WriteLine(listArr.Where(x => x == item).Count() );
                    countedNums.Add(item);
                }
            }
        }
        static void CountFrequenciesSorted(int[] arr)
        {
            if (arr.Length == 0) return;

            Array.Sort(arr);

            int count = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                    count++;
                else
                {
                    Console.WriteLine($"Number: {arr[i - 1]} appears {count} times");
                    count = 1;
                }
            }

            Console.WriteLine($"Number: {arr[arr.Length - 1]} appears {count} times");
        }


        //Find second largest number
        static void SecondMaximum (int[] arr)
        {

            int maximum = 0;
            int secondMaximum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maximum)
                    maximum = arr[i];

                if (arr[i] != maximum && arr[i]> secondMaximum)
                    secondMaximum = arr[i];
            }

            Console.WriteLine($" The maximum number is {maximum} and the second maximum is {secondMaximum}");
        }


        //Find if there is a continuous subarray whose sum equals a target
        static int[] SubarraySum (int[] arr, int target)
        {
            int sumSubArr = 0;
            int startIndex = 0;
            int[] subArray = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                sumSubArr += arr[i];
                if (sumSubArr == target){
                    Array.Copy(arr, startIndex, subArray, 0, i - startIndex +1);
                    return subArray;
                }
                else if (sumSubArr > target)
                {
                    sumSubArr = 0;
                    startIndex = i +1;
                }
            }

            return subArray;
        }

        //Reverse part of array between two indices
        static int[] ReversePartArr (int[] arr, int firstIndex, int secondIndex)
        {

            int[] newArr = new int[arr.Length];

            Array.Copy(arr, 0, newArr, 0, firstIndex);
            Array.Copy(arr.Reverse().ToArray(), firstIndex, newArr, firstIndex, secondIndex - firstIndex + 1);
            Array.Copy(arr, secondIndex + 1, newArr, secondIndex +1, arr.Length - secondIndex -1);
            //Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length)

            //int[] newArr = (int[])arr.Clone();
            //int lengthToReverse = secondIndex - firstIndex + 1;
            //Array.Reverse(newArr, firstIndex, lengthToReverse);  Use the built-in chunk reverser

            return newArr;
        }

        //Find minimum number of swaps required to sort array
        static int SwapstoSort(int[] arr)
        {
            int[] sortedArr = arr.OrderBy(x => x).ToArray();
            int sortCounter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != sortedArr[i])
                    sortCounter++;
            }
            return sortCounter / 2;
        }

        //Rearrange: smallest largest second smallest second largest...
        static int[] TrickyReordering(int[] arr)
        {
            Array.Sort(arr);
            int [] reArranged = new int [arr.Length] ; 
            int left = 0;
            int index = 0;
            int right = arr.Length -1;

            while ( left < right)
            {
                reArranged[index] = arr[left];
                reArranged[index + 1] = arr[right];

                index += 2;
                left++;
                right--;
            }

            if (left == right)
            {
                reArranged[reArranged.Length -1] = arr[left];
            }

            return reArranged;
        }


        //Find longest repeating pattern in array
        public static int[] LongestRepeatingPattern(int[] arr)
        {
            int n = arr.Length;

            // dp[i, j] stores the length of the matching pattern 
            // ending at index i-1 and index j-1.
            // We make it size (n + 1) to handle the 0-index boundary easily.
            int[,] dp = new int[n + 1, n + 1];

            int maxLength = 0;
            int endIndex = 0;

            // Loop through the array, comparing it against itself
            for (int i = 1; i <= n; i++)
            {
                // j starts at i + 1 so we are comparing different parts of the array
                for (int j = i + 1; j <= n; j++)
                {
                    // If the current elements match
                    if (arr[i - 1] == arr[j - 1])
                    {
                        // Add 1 to whatever the previous matching streak was
                        dp[i, j] = dp[i - 1, j - 1] + 1;

                        // Did we just find a new record?
                        if (dp[i, j] > maxLength)
                        {
                            maxLength = dp[i, j];
                            endIndex = i; // Remember where this pattern ends
                        }
                    }
                    else
                    {
                        // If they don't match, the streak is broken
                        dp[i, j] = 0;
                    }
                }
            }

            // If no repeating pattern was found, return an empty array
            if (maxLength == 0)
            {
                return new int[0];
            }

            // Extract the longest pattern using Array.Copy for memory efficiency
            int[] result = new int[maxLength];

            // Starting index is the End Index minus the Length of the pattern
            int startIndex = endIndex - maxLength;
            Array.Copy(arr, startIndex, result, 0, maxLength);

            return result;
        }

        //Build Your Own Remove
        static int[] RemoveItem(int[] arr, int value)
        {
            List<int> newArr = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != value)
                    newArr.Add(arr[i]);
            }

            return newArr.ToArray();
        }
    }
}
