using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary2<string> City = new MyDictionary2<string>();

            
            MyDictionary2<int> Plate = new MyDictionary2<int>();
            City.Add("Bayburt");
            Plate.Add(69);
            City.Add("Isparta");
            Plate.Add(32);
            Console.WriteLine(City.Count);
            Console.WriteLine( Plate.Count );


            
        }
    }
}
