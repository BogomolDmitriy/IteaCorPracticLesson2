using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IteaCorPracticLesson2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private static List<Book> BookshelfList { get; set; }
        private readonly ILogger<BooksController> _logger;

        static BooksController()
        {
            BookshelfList = new List<Book>();
            BookshelfList.Add(new Book()
            {
                Id = Guid.NewGuid(),
                Title = "Name book",
                Author = "Test",
                Pages = 10500
            });
        }

        public BooksController(ILogger<BooksController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return BookshelfList;
        }
    }
}
