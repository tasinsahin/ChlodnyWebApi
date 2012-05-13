namespace ChlodnyWebApi.Models
{
    public class SearchValues
    {
        public string WhichSearch { get; set; }

        public string SearchType { get; set; }

        public int MaxRowsReturn { get; set; }

        public string Term { get; set; }
    }
}

