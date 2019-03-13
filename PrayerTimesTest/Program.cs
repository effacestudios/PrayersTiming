using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PrayerTimesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string CityName;
            Console.Write("Enter Your City Name: ");
            CityName = Console.ReadLine();

            string CountryName;
            Console.Write("Enter Your Country Name: ");
            CountryName = Console.ReadLine();

            var client = new WebClient();


            var text = client.DownloadString("http://api.aladhan.com/v1/timingsByCity?city="+CityName+"&country="+CountryName);


            RootObject result = JsonConvert.DeserializeObject<RootObject>(text);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Prayers Timing for " + CityName + ", " + CountryName + ":");

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Fajr Time: " + result.data.timings.Fajr);
            Console.WriteLine("Sunrise Time: " + result.data.timings.Sunrise);
            Console.WriteLine("Duhr Time: " + result.data.timings.Dhuhr);
            Console.WriteLine("Asr Time: " + result.data.timings.Asr);
            Console.WriteLine("Sunset Time: " + result.data.timings.Sunset);
            Console.WriteLine("Maghrib Time: " + result.data.timings.Maghrib);
            Console.WriteLine("Isha Time: " + result.data.timings.Isha);
            Console.WriteLine("Imsak Time: " + result.data.timings.Imsak);
            Console.WriteLine("Midnight Time: " + result.data.timings.Midnight);

            Console.ReadKey();
        }
        }
}
