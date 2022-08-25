using System;
using System.Text;

namespace PYP_LoopTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task-1
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine($"positive:{i} negative:{i*-1}");
            //}
            //Task-2
            //string revers=Revers("murat");
            //Console.WriteLine(revers);
            #region Task-3
            //for (int i = 10; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine($"{i} eşittir 2 * {i / 2}");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine($"{i} eşittir 3 * {i / 3}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{i} asal sayidir");
            //    }
            //}
            #endregion
            #region Task-4
            int[] arr = new int[0];
            string answer;
            do
            {
            Enter:
                Console.WriteLine("Enter the number input:");
                if (!int.TryParse(Console.ReadLine(), out int input))
                    goto Enter;
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = input;
                Console.WriteLine("Would you like to add a number? y/n");
                answer = Console.ReadLine();
            } while (answer == "y");
            Console.Clear();
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    if (arr[i] > max)
                        max = arr[i];
                    else if (arr[i] < min)
                        min = arr[i];
                }
            }
            Console.WriteLine($"max:{max}-min:{min}");
            Console.WriteLine($"result:{max - min}");
            #endregion
        }
        //Task 2
        static string Revers(string text)
        {
            StringBuilder reversText = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversText.Append(text[i]);
            }
            return reversText.ToString();
        }
       
      
    }
}
