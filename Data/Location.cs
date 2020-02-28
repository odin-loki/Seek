using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seek.Data
{
    public class Location
    {
        //Pattern /jobs/in-Suburb-City-Region
        //When Postcode. City becomes State.

        public string Uri = "/jobs/in-";
        public string Region { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }


        public static string[] CapitolCityList = {
            "/jobs/in-All-Sydney-NSW",
            "/jobs/in-All-Melbourne-VIC",
            "/jobs/in-All-Brisbane-QLD",
            "/jobs/in-All-Gold-Coast-QLD",
            "/jobs/in-All-Perth-WA",
            "/jobs/in-All-Adelaide-SA",
            "/jobs/in-All-Hobart-TAS",
            "/jobs/in-All-Darwin-NT",
            "/jobs/in-All-Canberra-ACT"
            };


    }
}
