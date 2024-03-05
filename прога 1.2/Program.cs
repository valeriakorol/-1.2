using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>
        {
            { "01", "січень" },
            { "02", "лютий" },
            { "03", "березень" },
            { "04", "квітень" },
            { "05", "травень" },
            { "06", "червень" },
            { "07", "липень" },
            { "08", "серпень" },
            { "09", "вересень" },
            { "10", "жовтень"},
            { "11", "листопад" },
            { "12", "грудень" }
        };

        Console.Write("Введіть значення ключа: ");
        string key = Console.ReadLine();

        Dictionary<string, string> filteredDictionary = new Dictionary<string, string>();

        foreach (KeyValuePair<string, string> entry in dictionary)
        {
            if (string.Compare(entry.Key, key) >= 0)
            {
                filteredDictionary.Add(entry.Key, entry.Value);
            }
        }

        if (filteredDictionary.Count > 0)
        {
            string json = JsonConvert.SerializeObject(filteredDictionary);
            Console.WriteLine("Результат:");
            Console.WriteLine(json);
            File.WriteAllText("result.json", json);
        }
        else
        {
            Console.WriteLine("null");
        }
    }
}
