using System.Collections.Generic;

namespace Seek.Data
{
    public class PayRange
    {
        //Props for List if Needed
        public string Name { get; set; }
        public string Uri { get; set; }

        //Later Use if Needed.
        public string JobBaseUri = "/jobs?";
        public string SalaryRangeUri = "salaryrange=";
        public string SalaryTypeUri = "salarytype=annual";

        //Props for Controls and Selector.
        public int[] LowerBaseRate = { 0, 30000, 40000, 50000, 60000, 70000, 80000, 100000, 120000, 150000, 200000 };
        public int[] UpperBaseRate = { 30000, 40000, 50000, 60000, 70000, 80000, 100000, 120000, 150000, 200000, 999999 };
        public string[] NameRateList = { "30k", "40k", "50k", "60k", "70k", "80k", "100k", "120k", "150k", "200k", "200k+" };


        //Use Toggle Button and Iterate over Rates to Select.
        public static string CreateUri(int lower, int upper)
        {
            return "/jobs?salarytype=annual&salaryrange=" + lower.ToString() + "-" + upper.ToString();
        }

        public static List<PayRange> CreateList()
        {
            return new List<PayRange>
            {
                new PayRange{ Name = "30k", Uri="/jobs?salarytype=annual&salaryrange=0-30000" },
                new PayRange{ Name = "40k", Uri="/jobs?salarytype=annual&salaryrange=0-40000" },
                new PayRange{ Name = "50k", Uri="/jobs?salarytype=annual&salaryrange=0-50000" },
                new PayRange{ Name = "60k", Uri="/jobs?salarytype=annual&salaryrange=0-60000" },
                new PayRange{ Name = "70k", Uri="/jobs?salarytype=annual&salaryrange=0-70000" },
                new PayRange{ Name = "80k", Uri="/jobs?salarytype=annual&salaryrange=0-80000" },
                new PayRange{ Name = "100k", Uri="/jobs?salarytype=annual&salaryrange=0-100000" },
                new PayRange{ Name = "120k", Uri="/jobs?salarytype=annual&salaryrange=0-120000" },
                new PayRange{ Name = "150k", Uri="/jobs?salarytype=annual&salaryrange=0-150000" },
                new PayRange{ Name = "200k", Uri="/jobs?salarytype=annual&salaryrange=0-200000" }
            };
        }

    }
}
