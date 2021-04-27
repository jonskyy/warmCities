using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    /// <summary>
    /// The class processes data to extract temperatures for 50 cities.
    /// string -> JSON -> Dictionary<city, temp>
    /// </summary>
    public class DataProcessing
    {
        public Dictionary<string, double> OnlyCityTemp(string data)
        { 
            var getData = JsonConvert.DeserializeObject<List<Model>>(data);
            var serializedJSON = JsonConvert.SerializeObject(getData);
            JArray entriesArray = JArray.Parse(serializedJSON);
            // Console.WriteLine("**** JSON STATION AND TEMPERATURE **** \n" + entriesArray);

            var cityDates = (from s in entriesArray
                                 select s["stacja"]).ToList();

            var tempData = (from s in entriesArray
                            select s["temperatura"]).ToList();

            Dictionary<string, double> cityTemp = new Dictionary<string, double>();

            int numberOfCity = 50;           //  value(1..cityTemp.count -1)
            for (int i = 0; i < numberOfCity; i++)
            {
                cityTemp.Add(cityDates[i].ToString(), (double)tempData[i]);
            }
           
            return cityTemp;
        }
    }
}
