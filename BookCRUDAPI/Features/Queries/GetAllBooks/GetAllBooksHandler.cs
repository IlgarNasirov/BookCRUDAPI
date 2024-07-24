using MediatR;

namespace BookCRUDAPI.Features.Queries.GetAllBooks
{
    public class GetAllBooksHandler : IRequestHandler<GetAllBooksRequest, GetAllBooksResponse>
    {
        public Task<GetAllBooksResponse> Handle(GetAllBooksRequest request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(request.Title))
            {
                return Task.FromResult(new GetAllBooksResponse { Books = Data.Books });
            }
            return Task.FromResult(new GetAllBooksResponse { Books = Data.Books.Where(b=>b.Title!.Contains(request.Title)).ToList()});
        }
    }
}
