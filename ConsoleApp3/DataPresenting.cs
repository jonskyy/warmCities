using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    /// <summary>
    /// The class prints 20 cities with the responding temperature.
    /// </summary>
    class DataPresenting
    {
        public void ShowData(Dictionary<string, double> cityTemp)
        {
            int counter = 20;
            var sortedDict = (from entry in cityTemp orderby entry.Value descending select entry).Take(counter);

            Console.WriteLine("The warmest city in Poland: ");
            for (int i = 0; i < sortedDict.Count(); i++)
            {
                Console.WriteLine((i+1) + ". " + sortedDict.ElementAt(i).Key.ToString()+ " \t" + sortedDict.ElementAt(i).Value.ToString() + "\t°C");
            }
        }
    }
}
