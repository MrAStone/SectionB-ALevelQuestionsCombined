using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SectionB_ALevelQuestionsCombined
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

        }
        static string B2018()
        {
            string answer = "Is prime";

            int numberFromUser;
            Console.Write("Enter a number: ");
            numberFromUser = Convert.ToInt32(Console.ReadLine());
            if (numberFromUser <= 1)
            {
                answer = "Not greater than 1";
                return answer;
            }
            for (int i = 2; i <= Math.Sqrt(numberFromUser); i++)
            {
                if (numberFromUser % i == 0)
                {
                    answer = "Is not prime";
                    return answer;
                }
            }

            return answer;
        }
        static string B2019()
        {
            string answer = "";
            string input1;
            string input2;
            Console.Write("Enter a word: ");
            input1 = Console.ReadLine();
            Console.Write("Enter another word: ");
            input2 = Console.ReadLine();
            char[] word1Ar = input1.ToCharArray();
            char[] word2Ar = input2.ToCharArray();
            for (int i = 0; i < word1Ar.Length; i++)
            {
                for (int j = 0; j < word2Ar.Length; j++)
                {
                    if (word1Ar[i] == word2Ar[j])
                    {
                        word1Ar[i] = '-';
                        word2Ar[j] = '-';
                    }
                }
            }
            int count = 0;
            for (int i = 0; i < word1Ar.Length; i++)
            {
                if (word1Ar[i] != '-')
                {
                    count++;
                }
            }

            if (count == 0)
            {
                answer = $"{input1} can be made from {input2}";
            }
            else
            {
                answer = $"{input1} can not be made from {input2}";
            }
            return answer;
        }
        static string B2020()
        {
            string answer = "";
            int numDigits;
            Console.Write("How many numeric digits would you like to enter: ");
            numDigits = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[10];
            for (int i = 0; i < numDigits; i++)
            {
                Console.Write("Enter a number:");
                int num = Convert.ToInt32(Console.ReadLine());
                nums[num]++;
            }
            int maxCount = nums.Max();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == maxCount)
                {
                    answer += i.ToString();
                }
            }
            if (answer.Length > 1)
            {
                answer = "Data was multimodal";

            }
            return answer;
        }
        static int B2021()
        {
            int answer = 0;
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int num = 0;
            int count = 0;
            while (count < n)
            {
                int total = 0;
                num += 1;
                foreach (char c in num.ToString())
                {

                    total += Convert.ToInt32(c) - 48;
                    // converting a character to integer gets its ASCII value so as '0' is 48, subtract to get integer value

                }

                if (num % total == 0)
                {

                    count++;
                }
            }
            answer = num;
            return answer;
        }
        static string B2022()
        {
            string answer = "";
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            char[] inputAr = input.ToCharArray();
            Stack<char> inputVowels = new Stack<char>();
            for (int i = 0; i < inputAr.Length; i++)
            {
                if (vowels.Contains(inputAr[i]))
                {
                    inputVowels.Push(inputAr[i]);
                    inputAr[i] = '_';
                }
            }
            for (int i = 0; i < inputAr.Length; i++)
            {
                if (inputAr[i] == '_')
                {
                    inputAr[i] = inputVowels.Pop();
                }
            }
            foreach (char c in inputAr)
            {
                answer += c;
            }

            return answer;
        }
        static string B2023()
        {
            string input="";
            
            bool valid = false;
            while (!valid)
            {
                valid = true;
                Console.Write("Enter a string: ");
                input = Console.ReadLine();
                if (input.Length < 5 || input.Length > 7) //not between 5 and 7 chars
                {
                    valid = false;
                }
                if (input.ToUpper() != input) // not uppercase
                {
                    valid = false;
                }
                int asciiSum = 0;
                for (int i = 0; i < input.Length; i++)//loop through string
                {
                    asciiSum += input[i]; //add ascii value
                    if (input.Substring(i + 1).Contains(input[i])) // check for repeating chars
                    {
                        valid = false;
                    }
                }
                if (asciiSum < 420 || asciiSum > 600)//not between 420 and 600
                {
                    valid = false;
                }
                if(!valid)
                {
                    Console.WriteLine("Not valid string");
                }
            }
            Console.WriteLine("Valid string");
            return input;
        }
        static string B2024()
        {
            string answer="";
            int input = 0;
            while (input <= 0)
            {
                Console.Write("Enter a number: ");
                input = Convert.ToInt32(Console.ReadLine());
            }
            string num = input.ToString();
            int incCount = 0;
            int decCount = 0;
            int sameCount = 0;
            
            for(int i = 0;i< num.Length-1;i++)
            {
                int n = num[i] - '0';
                int next = num[i + 1] - '0';
                if (next >= n) // counts increase
                {
                    incCount++;
                }
                if(next <= n) // Counts decrease
                {
                    decCount++;
                }
                if (next == n) // checks if all numbers are the same 
                {
                    sameCount++;
                }
            }
            
            if(incCount>0 && decCount > 0)
            {
                if (incCount == decCount && sameCount !=num.Length-1)
                {
                    answer = "Perfectly bouncy number";
                }
                else
                {
                    answer = "Bouncy number";
                }
            }
            else
            {
                answer = "Not bouncy";
            }
            Console.WriteLine(answer);
            return answer;
        }
    }

}
