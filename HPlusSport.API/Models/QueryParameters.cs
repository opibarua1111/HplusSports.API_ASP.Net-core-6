namespace HPlusSport.API.Models
{
    public class QueryParameters
    {
        const int _MaxSize = 100;
        private int _Size = 50;
        public int Page { get; set; } = 1;
        public int Size { 
            get { return _Size; } 
            set { _Size = Math.Min( _MaxSize, value);} 
        }
        public string SortBy { get; set; } = "Id";
        private string _sortOrder = "asc";
        public string SortOrder
        {
            get { return _sortOrder; }
            set
            {
                if (value == "asc" || value == "desc")
                {
                    _sortOrder = value;
                }
            }
        }
    }
}
