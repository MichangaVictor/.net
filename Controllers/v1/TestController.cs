using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Controllers.v1
{ 

    [ApiVersion("1.0")]
    [ApiVersion("1.2")]
    [ApiVersion("1.8")]
    [ApiVersion("2.0")]
    [Route("api/[controller]")]
    //[Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        
        [HttpGet("get-test-data"), MapToApiVersion("1.0")]
        public IActionResult Getv1()
        {
            return Ok("This is test Controller Version 1.0");
        }
        [HttpGet("get-test-data"), MapToApiVersion("1.2")]
        public IActionResult Getv12()
        {
            return Ok("This is test Controller Version 1.2");
        }
        [HttpGet("get-test-data"),MapToApiVersion("1.8")]
        public IActionResult Getv18()
        {
            return Ok("This is test Controller Version 1.8");
        }
        [HttpGet("get-test-data"), MapToApiVersion("2.0")]
        public IActionResult Getv20()
        {
            return Ok("This is test Controller Version 2.0");
        }
    }
}
