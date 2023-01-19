using System;
using System.Security.Claims;

namespace Homework_Method_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.WriteLine("Arrayin uzunlugunu daxil edin...");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($" Arrayin {i}-ci elementini daxil edin...");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = MinOfNumbers(numbers);
            Console.WriteLine("Arrayin minimum elementi..." + min);
            #endregion

            #region Task 2
            Console.WriteLine("Yazi daxil edin...");
            string word = Console.ReadLine();
            Console.WriteLine("Simvol daxil edin...");
            char symbol = Convert.ToChar(Console.ReadLine());
            int result = CountOfChars(word, symbol);
            Console.WriteLine($"{result} eded {symbol} simvolu var.");
            #endregion

            #region Task 3
            Console.WriteLine("Arrayin uzunlugunu daxil edin...");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[m];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($" Arrayin {i}-ci elementini daxil edin...");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Eded daxil edin...");
            int num = Convert.ToInt32(Console.ReadLine());
            int index = IndexOfNumber(array, num);
            Console.WriteLine("Daxil edilen ededin indexi..." + index);
            #endregion

            #region Task 4
            Console.WriteLine("Yazi daxil edin...");
            string str = Console.ReadLine();
            string newStr = ReverseOfWord(str);
            Console.WriteLine("Eksine cevrilmis yazi..." + newStr);
            #endregion

            #region Task 5
            bool check = CheckNumber("salam123",'3');
            Console.WriteLine(check);
            #endregion
        }

        //Verilmiş ədədlər siyahısındaki ədədlərdən ən kiçiyini tapan metod
        static int MinOfNumbers(int[] numbers)
        {
            int min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        //Verilmiş yazıda verilmiş chardan neçə ədəd olduğunu tapan metod
        static int CountOfChars (string str, char cr) 
        {
            int count = 0;  
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == cr)
                {
                    count++;
                }
            }
            return count;
        }

        //Verilmiş ədədlər siyahısında verilmiş ədədin yerləşdiyi indexi tapan metod,
        //əgər həmin ədəd siyahıda yoxdursa -1 qaytarsın, varsa ilk yerləşdiyi indexi.
        static int IndexOfNumber (int[] numbers, int num)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == num)
                {
                    return i;
                    break;
                }
            }
            return -1;
        }

        //Verilmiş yazını əksinə çevirən metod
        //(misalçün metoda "salam" göndərsəniz metod geriyə "malas" return etməlidir)
        static string ReverseOfWord (string str)
        {
            string reverse = "";
            int Length = 0;
            Length = str.Length - 1;
            while (Length >= 0)
            {
                reverse = reverse + str[Length];
                Length--;
            }
            return reverse; 
        }

        //Verilmiş yazıda rəqəm olub olmadığını tapan metod
        static bool CheckNumber (string str, char num)
        {
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int j = 0; j < numbers.Length; j++)
            {
               
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == numbers[j])
                    {
                        return true;
                    }
                }
                
            }
            return false;
             

        }
    }
}
