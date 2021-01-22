using System;

namespace myDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> cities = new MyDictionary<int, string>();

            cities.Add(1, "Adana");
            cities.Add(6, "Ankara");

            

            cities.List();

            Console.WriteLine("================");
            Console.WriteLine("Is there a city with number 1? : " + cities.ContainsKey(1));
            Console.WriteLine("Number 1 city is " + cities.GetValue(1));
            Console.WriteLine("Is there a city named Denizli in cities? : " + cities.ContainsValue("Denizli"));
            Console.WriteLine("Is there a city named Ankara in cities? : " + cities.ContainsValue("Ankara"));
            Console.WriteLine("Ankara's number:"+ cities.GetKey("Ankara"));
            
        }
    }


}
