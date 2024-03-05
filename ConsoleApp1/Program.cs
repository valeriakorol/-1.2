using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        Console.Write("Введіть число X: ");
        int x = int.Parse(Console.ReadLine());

        
        int indexX = numbers.IndexOf(x);

        if (indexX != -1) 
        {
            
            for (int i = 0; i < indexX / 2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[indexX - i - 1];
                numbers[indexX - i - 1] = temp;
            }

           
            for (int i = indexX + 1; i < (numbers.Count + indexX + 1) / 2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Count - i + indexX];
                numbers[numbers.Count - i + indexX] = temp;
            }


            Console.WriteLine("Результат:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }
        else
        {
            Console.WriteLine("Елемент X не знайдено у списку.");
        }
    }
}
