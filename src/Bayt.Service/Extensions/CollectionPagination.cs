using Bayt.Domain.Configurations;

namespace Bayt.Service.Extensions;

public static class CollectionPagination
{
    public static IQueryable<T> ToPaginate<T>(this IQueryable<T> values, PaginationParams @params)
        => values.Skip((@params.PageIndex - 1) * @params.PageSize).Take(@params.PageSize);
}