namespace CodecoolAPI.API.DTO.Pagination
{
    public class PaginationDTO
    {
        private const int maxPageSize = 10;

        [Required]
        [Range(1, int.MaxValue)]
        public int PageNumber { get; set; }

        [Required]
        [Range(1, maxPageSize)]
        public int PageSize { get; set; }
        public string? SearchPhrase { get; set; }

        [Required]
        public SortFieldDTO SortField { get; set; }

        [Required]
        public OrderDTO Order { get; set; }
    }
}
