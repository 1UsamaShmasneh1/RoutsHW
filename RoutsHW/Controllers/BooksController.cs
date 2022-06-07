using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoutsHW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route("{id}:min(5)")]
        public string GetIntNumber(int id)
        {
            return "hello from int";
        }

        [Route("{id:regex(book(zoom|boom))}")]
        public string GetIntString(string id)
        {
            return "hello from string";
        }

    }
}
