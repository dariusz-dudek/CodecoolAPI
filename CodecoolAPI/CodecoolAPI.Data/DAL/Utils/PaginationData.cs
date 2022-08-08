namespace CodecoolAPI.Data.DAL.Utils
{
    public class PaginationData
    {
        public int PageNumber { get; set; }

        public int PageSize { get; set; }
        public string? SearchPhrase { get; set; }

        public bool Ascending { get; set; }

        public string Property { get; set; }
    }
}
