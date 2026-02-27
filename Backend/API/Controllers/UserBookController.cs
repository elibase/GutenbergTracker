using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserBookController : ControllerBase
    {
        private readonly IUserBooksRepository repository;

        public UserBookController(IUserBooksRepository userBooksRepository)
        {
            repository = userBooksRepository;
        }

        [HttpGet("/user/{userId}")]
        public async Task<ActionResult<ICollection<UserBook>>> GetAll()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId == null)
                return Unauthorized();

            var books = await repository.GetuserBooks(userId);

            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserBook>> GetById(int id)
        {
            var book = await repository.GerUserBookById(id);

            if (book == null)
                return NotFound();

            return Ok(book);
        }


        [HttpPost]
        public async Task<ActionResult<UserBook>> AddUserBook(UserBook userBook)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId == null)
                return Unauthorized();

            userBook.UserId = userId;

            var created = await repository.AddUserBook(userBook);

            return CreatedAtAction(nameof(AddUserBook),
                new { id = created.Id },
                created);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<UserBook>> UpdateUserBook(int id, UserBook userBook)
        {
            if (id != userBook.Id)
                return BadRequest();

            var updated = await repository.UpdateUserBook(userBook);

            if (updated == null)
                return NotFound();

            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var deleted = await repository.DeleteUserBook(id);
            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}
