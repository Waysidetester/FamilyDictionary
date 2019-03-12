using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> MyFamily = new Dictionary<string, Dictionary<string, string>>();
            MyFamily.Add("sister", new Dictionary<string, string>() { { "name", "Anastasia" }, { "age", "19" } });

            foreach (var (key, value) in MyFamily)
            {
                Console.WriteLine($"{MyFamily[key]["name"]} is my {key} and is {MyFamily[key]["age"]} years old.");
            }
            Console.ReadKey();
        }
    }
}
