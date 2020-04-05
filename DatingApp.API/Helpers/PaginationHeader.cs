namespace DatingApp.API.Helpers
{
    // pagination in header
    public class PaginationHeader
    {
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public PaginationHeader(int totalItems, int totalPages, int itemsPerPage, int currentPage)
        {
            this.TotalItems = totalItems;
            this.TotalPages = totalPages;
            this.ItemsPerPage = itemsPerPage;
            this.CurrentPage = currentPage;
        }
    }
}