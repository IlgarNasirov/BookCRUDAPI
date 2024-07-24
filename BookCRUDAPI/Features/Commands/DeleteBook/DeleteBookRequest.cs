using MediatR;

namespace BookCRUDAPI.Features.Commands.DeleteBook
{
    public class DeleteBookRequest:IRequest<DeleteBookResponse>
    {
        public long Id { get; set; }
    }
}
