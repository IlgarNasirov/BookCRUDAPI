using MediatR;

namespace BookCRUDAPI.Features.Commands.UpdateBook
{
    public class UpdateBookHandler : IRequestHandler<UpdateBookRequest, UpdateBookResponse>
    {
        public Task<UpdateBookResponse> Handle(UpdateBookRequest request, CancellationToken cancellationToken)
        {
            var book = Data.Books.Where(b=>b.Id==request.Id).FirstOrDefault();
            if (book != null)
            {
                book.Description= request.Description;
                book.Title = request.Title;
                book.BookGenre = request.BookGenre;
                book.Updated= DateTime.Now;
                return Task.FromResult(new UpdateBookResponse { Success = true });
            }
            return Task.FromResult(new UpdateBookResponse { Success=false });
        }
    }
}