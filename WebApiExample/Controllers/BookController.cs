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
            var books = new List<Books>() 
            { 
                new Books() { BookdId = 1, BookDescription = "bu bnm ilk kitabım", BookName = "ilk kitap" }, 
                new Books() { BookdId = 2, BookDescription = "bu bnm 2 kitabım", BookName = "2 kitap" }, 
                new Books() { BookdId = 3, BookDescription = "bu bnm 3 kitabım", BookName = "3 kitap" } 
            };

            return Ok(books);
        }
    }
}
