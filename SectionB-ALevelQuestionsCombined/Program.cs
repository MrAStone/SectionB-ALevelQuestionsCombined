using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionB_ALevelQuestionsCombined
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(B2020());
            }
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
            for(int i = 2; i <= Math.Sqrt(numberFromUser); i++)
            {
                if(numberFromUser%i == 0)
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
            for(int i = 0; i < word1Ar.Length; i++)
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
            for(int i=0; i < word1Ar.Length; i++)
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
            for(int i = 0;i<numDigits;i++)
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
            if (answer.Length > 1) {
                answer = "Data was multimodal";

            }
            return answer;
        }
    }
}
