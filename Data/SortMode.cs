namespace Seek.Data
{
    public class SortMode
    {
        public static string Uri = "sortmode=";
        public static string Relevance = "KeywordRelevance";
        public static string Date = "ListedDate";

        //true for by date
        public static string CreateUri(bool choice)
        {
            if (choice == true)
            {
                return Uri + Date;
            }
            else
            {
                return Uri + Relevance;
            }
        }

    }
}
