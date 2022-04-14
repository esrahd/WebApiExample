using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExample.Models;

namespace WebApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpGet(Name ="GetBooks")]
        public IActionResult GetBooks()
        {
            var books = new List<Books>();

            var book = new Books();
            book.BookdId = 1;
            book.BookName = "ilk kitap";
            book.BookDescription = "bu bnm ilk kitabım";

            books.Add(book);


            return Ok(books);
        }
    }
}
