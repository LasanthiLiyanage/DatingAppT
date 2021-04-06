namespace API.Helpers
{
    public class PaginationParams
    {
        private int maxPageSize = 50;
        public int pageNumber { get; set; } = 1;
        private int _pageSize = 10;
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > maxPageSize) ? maxPageSize : value;
        }

    }
}