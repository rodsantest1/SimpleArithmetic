using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1API.CoreService;
using ClassLibrary1Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClassLibrary1API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArithmeticController : ControllerBase
    {

        [HttpGet("{input1}/{input2}")]

        public async Task<int> Add(string input1, string input2)
        {
            var sum = ArithmeticService.AddNumbers(input1, input2);

            return sum;
        }
    }
}
