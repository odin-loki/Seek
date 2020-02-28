namespace Seek.Data
{
    public class TimeRange
    {
        public string Name { get; set; }
        public string Uri = "/jobs?daterange=";

        public int[] RangeList = { 1, 3, 7, 14, 30, 999 };
        public string[] NameList = { "Today", "Last 3 Days", "Last 7 Days", "Last 14 Days", "Last 30 Days", "Anytime" };

        public string MakeDataRangeUri(int choice)
        {
            return Uri + choice.ToString();
        }
    }
}
