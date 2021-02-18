using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TesteApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        public MessageController()
        {
        }

        [HttpGet("list")]
        public IEnumerable<Message> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Message
            {
                Text = index.ToString()
            })
            .ToArray();
        }
    }
}

