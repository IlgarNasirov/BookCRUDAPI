using MediatR;

namespace BookCRUDAPI.Features.Commands.DeleteBook
{
    public class DeleteBookHandler : IRequestHandler<DeleteBookRequest, DeleteBookResponse>
    {
        public Task<DeleteBookResponse> Handle(DeleteBookRequest request, CancellationToken cancellationToken)
        {
            var book= Data.Books.Where(b=>b.Id==request.Id).FirstOrDefault();
            if (book != null)
            {
                Data.Books.Remove(book);
                return Task.FromResult(new DeleteBookResponse { Success = true });
            }
            return Task.FromResult(new DeleteBookResponse { Success = false });
        }
    }
}
