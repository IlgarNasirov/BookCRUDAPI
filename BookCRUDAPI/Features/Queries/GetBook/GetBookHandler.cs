using MediatR;

namespace BookCRUDAPI.Features.Queries.GetBook
{
    public class GetBookHandler : IRequestHandler<GetBookRequest, GetBookResponse>
    {
        public Task<GetBookResponse> Handle(GetBookRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new GetBookResponse { Book= Data.Books.Where(b=>b.Id==request.Id).FirstOrDefault()});
        }
    }
}
