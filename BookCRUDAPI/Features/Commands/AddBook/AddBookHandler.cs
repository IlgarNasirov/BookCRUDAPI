using MediatR;

namespace BookCRUDAPI.Features.Commands.AddBook
{
    public class AddBookHandler : IRequestHandler<AddBookRequest, AddBookResponse>
    {
        public Task<AddBookResponse> Handle(AddBookRequest request, CancellationToken cancellationToken)
        {
            Book book = new Book();
            book.BookGenre = request.BookGenre;
            book.Description = request.Description;
            book.Title = request.Title;
            book.Id = new Random().Next();
            book.Created = DateTime.Now;
            Data.Books.Add(book);
            return Task.FromResult(new AddBookResponse { Success=true});
        }
    }
}
