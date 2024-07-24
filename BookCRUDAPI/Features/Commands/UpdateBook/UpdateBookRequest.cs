using MediatR;

namespace BookCRUDAPI.Features.Commands.UpdateBook
{
    public class UpdateBookRequest:IRequest<UpdateBookResponse>
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public BookGenre BookGenre { get; set; }
    }
}
