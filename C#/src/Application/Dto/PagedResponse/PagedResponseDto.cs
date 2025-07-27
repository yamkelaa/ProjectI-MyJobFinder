namespace Application.Dto.PagedResponse;

public class PagedResponseDto<T>
{
    public required List<T> List { get; set; }
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
    public int TotalCount { get; set; }
}
