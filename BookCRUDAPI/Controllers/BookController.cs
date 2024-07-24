using BookCRUDAPI.Features.Commands.AddBook;
using BookCRUDAPI.Features.Commands.DeleteBook;
using BookCRUDAPI.Features.Commands.UpdateBook;
using BookCRUDAPI.Features.Queries.GetAllBooks;
using BookCRUDAPI.Features.Queries.GetBook;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookCRUDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("GetAllBooks")]
        public async Task<IActionResult>GetAllBooks([FromQuery]GetAllBooksRequest getAllBooksRequest)
        {
            return Ok(await _mediator.Send(getAllBooksRequest));
        }
        [HttpGet("GetBook")]
        public async Task<IActionResult> GetBook([FromQuery] GetBookRequest getBookRequest)
        {
            return Ok(await _mediator.Send(getBookRequest));
        }
        [HttpPost("AddBook")]
        public async Task<IActionResult> AddBook([FromBody] AddBookRequest addBookRequest)
        {
            return Ok(await _mediator.Send(addBookRequest));
        }
        [HttpPut("UpdateBook")]
        public async Task<IActionResult> UpdateBook([FromBody] UpdateBookRequest updateBookRequest)
        {
            return Ok(await _mediator.Send(updateBookRequest));
        }
        [HttpDelete("DeleteBook")]
        public async Task<IActionResult> DeleteBook([FromBody] DeleteBookRequest deleteBookRequest)
        {
            return Ok(await _mediator.Send(deleteBookRequest));
        }
    }
}