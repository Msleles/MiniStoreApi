using System.Text.Json;

namespace MiniStore.Domain.Pagination
{
    public static class PaginationHelper
    {
        public static string GetPaginationMetadataJson<T>(PagedList<T> pagedList)
        {
            var metadata = new
            {
                pagedList.TotalCount,
                pagedList.PageSize,
                pagedList.CurrentPage,
                pagedList.TotalPages,
                pagedList.HasNext,
                pagedList.HasPrevious
            };

            var jsonOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            return JsonSerializer.Serialize(metadata, jsonOptions);
        }
    }
}
