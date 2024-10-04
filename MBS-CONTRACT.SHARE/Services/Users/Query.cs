using MBS_CONTRACT.SHARE.Abstractions.Messages;
using MBS_CONTRACT.SHARE.Enumerations;

namespace MBS_CONTRACT.SHARE.Services.Users;

public static class Query
{
    public record GetProductQuery(string? SearchTerm, string? SortColumn, SortOrder? SortOrder, IDictionary<string, SortOrder>? SortColumnAndOrder) : IQuery<List<Response.ProductResponse>>;

    public record GetProductById(Guid Id) : IQuery<List<Response.ProductResponse>>;
}
