using MediatR;

namespace BookCRUDAPI.Features.Queries.GetAllBooks
{
    public class GetAllBooksRequest:IRequest<GetAllBooksResponse>
    {
        public string? Title { get; set; }
    }
}
