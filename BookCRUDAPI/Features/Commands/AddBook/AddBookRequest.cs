using MediatR;

namespace BookCRUDAPI.Features.Commands.AddBook
{
    public class AddBookRequest:IRequest<AddBookResponse>
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public BookGenre BookGenre { get; set; }
    }
}
