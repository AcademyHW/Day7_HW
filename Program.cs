using System;
using System.Collections.Generic;

namespace Day7_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffeeMachine = new Dictionary<int, string>();

            for (int i = 0; i < 10; i++) //Fill
            {
                coffeeMachine.Add((i+1)*100, $"Drink {i+1}");
            }

            Console.WriteLine("Coffee Machine have a: "); //Show assortment
            foreach (KeyValuePair<int, string> keyValuePair in coffeeMachine)
            {
                Console.WriteLine("{0} -\t{1}$", 
                    keyValuePair.Value, keyValuePair.Key
                    );
            }

            Console.WriteLine("How much money do you have ?"); //Question
            string userChoise;
            coffeeMachine.TryGetValue(Convert.ToInt32(Console.ReadLine()), out userChoise);
            Console.WriteLine(
                userChoise != null ? userChoise : "Not found"
                );
        }
    }
}
