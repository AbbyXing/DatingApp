namespace DatingApp.API.Helpers
{
    // user params for pagination
    public class UserParams
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int pageSize = 10; // default page size
        public int PageSize
        {
            get { return pageSize; }
            // page size cannot be setted to more than MaxPageSize
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }
        
    }
}