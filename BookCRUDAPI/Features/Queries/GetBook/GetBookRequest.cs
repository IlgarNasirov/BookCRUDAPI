using MediatR;

namespace BookCRUDAPI.Features.Queries.GetBook
{
    public class GetBookRequest:IRequest<GetBookResponse>
    {
        public long Id { get; set; }
    }
}