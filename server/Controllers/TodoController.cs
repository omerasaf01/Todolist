using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Data.Sqlite;
using server.Models;

namespace server.Controllers
{
    [ApiController]
    [Route("api/todo")]
    public class TodoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Statu = 1 });
        }

        [HttpPost]
        public IActionResult Create()
        {
            return Ok(new { Statu = 1 });
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok(new { Statu = 1 });
        }
    }
}