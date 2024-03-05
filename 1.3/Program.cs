using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Введіть значення D: ");
        int D = int.Parse(Console.ReadLine()); 
        List<int> A = new List<int> { 15, 23, 36, 47, 50, 62, 74, 85, 98, 6, 8, 21, };

        var result = A.Where(num => num > 0 && num % 10 == D) 
                      .Reverse() 
                      .Distinct() 
                      .Reverse(); 

        Console.WriteLine("Результат:");
        foreach (var num in result)
        {
            Console.WriteLine(num);
        }
    }
}