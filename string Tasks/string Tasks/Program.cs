using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(adjacentOpposites("aAbBcC"));
            //compressor("banana");
            //alternateCase("banana");
            //Console.WriteLine(substringPattern("10100110"));
            //reverseLetters("a-bC-dEf-ghIj");
            //repeatingBlock("aaabbccccd");
            //charactersShifter("ABCD zab@dZ");
            //Console.WriteLine(almostPalindrome("abfa"));
            //patternDistance("ahmadha");
            Console.WriteLine(patternCounter("LRrllLrR") );
        }

        //Remove Adjacent Opposites (same letter diffrent case )
        static string adjacentOpposites(string letters)
        {
            string newString;
            List<char> stringArr = new List<char>();

            for (int i = 0; i < letters.Length; i++)
            {
                if (i == letters.Length - 1)
                {
                    stringArr.Add(letters[i]);
                    break;
                }

                char first = char.ToLower(letters[i]);
                char second = char.ToLower(letters[i + 1]);

                if (first != second || (char.IsUpper(letters[i]) && char.IsUpper(letters[i + 1])) || (char.IsLower(letters[i]) && char.IsLower(letters[i + 1])))
                {
                    stringArr.Add(letters[i]);
                }
                else i++;
            }

            return newString = new string(stringArr.ToArray());

        }

        //-------------------------------------------------------------------------------------------
        //Compress But Keep Order

        static void compressor(string word)
        {

            List<string> newString = new List<string>();
            Dictionary<char, int> letters = new Dictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                if (!letters.ContainsKey(word[i]))
                    letters.Add(word[i], 1);

                else

                    letters[word[i]]++;
            }


            foreach (var chr in letters)
            {
                newString.Add(chr.Key.ToString());
                newString.Add(chr.Value.ToString());
            }

            Console.WriteLine(string.Join("", newString));
        }

        //-------------------------------------------------------------------------------------------
        //change letter case every letter 
        static void alternateCase(string word)
        {
            char[] newWord = new char[word.Length];
            bool isLower = true;

            for (int i = 0; i < word.Length; i++)
            {
                if (isLower)
                    newWord[i] = char.ToLower(word[i]);
                else
                    newWord[i] = char.ToUpper(word[i]);

                isLower = !isLower;
            }

            Console.WriteLine(string.Join("", newWord));
        }

        static int substringPattern(string word)
        {
            int patternCounter = 0;

            string[] patternArr = { "0101", "1010", "0110", "1100", "0011,1001", "010101", "101010", "000111", "111000" };

            foreach (var item in patternArr)
            {
                if (word.Contains(item))
                    patternCounter++;
            }

            for (int i = 0; i < word.Length - 1; i++)
            {
                string first = word[i].ToString();
                string second = word[i + 1].ToString();
                string subString = string.Concat(first, second);
                if (subString == "01" || subString == "10")
                    patternCounter++;
            }
            return patternCounter;

        }

        //-------------------------------------------------------------------------------------------
        //Reverse Only Letters

        static void reverseLetters(string word)
        {

            char[] newString = new char[word.Length];
            Stack<char> letters = new Stack<char>();

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLetter(word[i]))
                    letters.Push(word[i]);

                else
                    newString[i] = word[i];
            }

            for (int i = 0; i < newString.Length; i++)
            {
                if (newString[i] == '\0')
                    newString[i] = letters.Pop();
            }

            Console.WriteLine(string.Join("", newString));
        }

        //-------------------------------------------------------------------------------------------
        //Longest Repeating Block

        static void repeatingBlock(string word)
        {
            int repeatingLetter = 1;
            int maxRepeatingLetter = 1;

            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] == word[i + 1])
                {
                    repeatingLetter++;

                    if (repeatingLetter > maxRepeatingLetter)
                        maxRepeatingLetter = repeatingLetter;
                }

                else repeatingLetter = 1;
            }

            Console.WriteLine($"Max times of repeating letter is {maxRepeatingLetter}");
        }

        //-------------------------------------------------------------------------------------------
        //Shift Characters

        static void charactersShifter(string word)
        {

            char[] letters = new char[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'z')
                {
                    letters[i] = 'a';
                }
                else if (word[i] == 'Z')
                {
                    letters[i] = 'A';
                }

                else if (char.IsLetter(word[i]))
                    letters[i] = (char)(word[i] + 1);

                else
                    letters[i] = word[i];

            }

            Console.WriteLine(new string(letters));
        }

        //-------------------------------------------------------------------------------------------
        //Remove One to Make Palindrome

        static bool almostPalindrome(string word)
        {

            int rightPointer = word.Length - 1 ;
            int leftPointer = 0;

            while (leftPointer < rightPointer)
            {
                if (word[rightPointer] == word[leftPointer])
                {
                    rightPointer --;
                    leftPointer ++;
                }

                else
                {
                    
                    return isPalindrome(word, leftPointer + 1, rightPointer) ||
                           isPalindrome(word, leftPointer, rightPointer - 1);
                }
            }

            return true; 
        }

        static bool isPalindrome(string word, int left, int right)
        {
            while (left < right)
            {
                if (word[left] != word[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }


        //-------------------------------------------------------------------------------------------
        // Calculate the distance betweeen repeating letters
        static void patternDistance (string word)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();
            Dictionary<char, int> lettersDistance = new Dictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                  if (!letters.ContainsKey(word[i]) )
                    letters.Add(word[i], i);

                else
                {
                    int distance = i - (letters[word[i]]);
                    if (!lettersDistance.ContainsKey(word[i]))
                    lettersDistance.Add(word[i], distance);
                }
            }

            foreach (var item in lettersDistance)
            {
                Console.WriteLine($"letter {item.Key} distance from first occurence is {item.Value}");
            }
        }


        //-------------------------------------------------------------------------------------------
        // Split the strig into pices of equal number of L's and R's

        static int patternCounter(string word)
        {
            int balance = 0;
            int totalSplits = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (char.ToLower(word[i]) == 'l')
                    balance++;

                else if (char.ToLower(word[i]) == 'r')
                    balance--;

                if (balance == 0)
                    totalSplits++;
            }
            Console.WriteLine($"Total balanced pieces: {totalSplits}");
            return totalSplits;

        }

    }
}
