using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    /// <summary>
    /// The consoleApp prints twenty the warmest city with temperature.
    /// Data loads from https://danepubliczne.imgw.pl/api/data/synop
    /// </summary>
    class Program 
    {
        static void Main(string[] args)
        {
            HttpProvider http = new HttpProvider();
            string wynik = http.LoadData();

            DataProcessing dataProcess = new DataProcessing();
            Dictionary<string, double> cityTemp = dataProcess.OnlyCityTemp(wynik);

            DataPresenting dataPresent = new DataPresenting();
            dataPresent.ShowData(cityTemp);
        }
    }
}
