namespace DVLD_Enterprise_System.Application.Common;

public sealed class PagedResult<T>
{
    public IReadOnlyList<T> Items { get; }

    public int TotalCount { get; }

    public int PageNumber { get; }

    public int PageSize { get; }

    public int TotalPages =>
        TotalCount == 0
            ? 0
            : (int)Math.Ceiling(
                TotalCount / (double)PageSize);

    public PagedResult(
        IReadOnlyList<T> items,
        int totalCount,
        int pageNumber,
        int pageSize)
    {
        Items = items;
        TotalCount = Math.Max(0, totalCount);
        PageNumber = Math.Max(1, pageNumber);
        PageSize = Math.Max(1, pageSize);
    }
}
