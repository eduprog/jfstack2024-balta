using System.Text.Json.Serialization;

namespace Fina.Core.Responses;

public abstract class PagedResponse<TDataResponse> : Response<TDataResponse>
{
    public int PageSize { get; set; } = Configuration.DefaultPageSize;
    public int PageNumber { get; set; } = Configuration.DefaultPageNumber;
    public int CurrentPage { get; set; }
    public int TotalCount { get; set; }
    public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
}