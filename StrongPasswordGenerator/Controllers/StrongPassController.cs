using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StrongPasswordGenerator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StrongPassController : ControllerBase
    {

        private readonly ILogger<StrongPassController> _logger;

        public StrongPassController(ILogger<StrongPassController> logger)
        {
            _logger = logger;
        }

        //Creates a random 12 character length string from valid password characters
        private string CreateStrongPassword()
        {
            string str = "";
            int num = 12;
            string[] chars = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", ".", "!", "@", "#", "$", "%", "^", "&", "*", "?", "_", "~", "(", ")", "{", "}", "-", "+", "=", " " };
            Random random = new Random();
            for (int i = 0; i < num; i++)
                str += chars[random.Next(chars.Length)];
            return str;
        }

        //Overload of previous function that takes int parameter
        private string CreateStrongPassword(int num)
        {
            string str = "";
            string[] chars = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", ".", "!", "@", "#", "$", "%", "^", "&", "*", "?", "_", "~", "(", ")", "{", "}", "-", "+", "=", " " };
            Random random = new Random();
            for (int i = 0; i < num; i++)
                str += chars[random.Next(chars.Length)];
            return str;
        }

        // GET: /strongpass
        [HttpGet]
        public IEnumerable<string> Get()
        {
            List<string> results = new List<string>();
            for (int i = 0; i <= 10; i++)
                results.Add(CreateStrongPassword());
            return results;
        }

        // GET /strongpass/[Password Length]
        [HttpGet("{num:int}")]
        public ActionResult<string> Get(int num)
        {
            return CreateStrongPassword(num);
        }
    }
}
