using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PascalsTriangle.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PascalsTriangle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PascalsTriangleController : ControllerBase
    {
        [HttpGet("pascal/{depth}")]
        public ActionResult GetPascalsTriangle(long depth)
        {

            IDisplayPascalsTriangle pascalTriangle = new DisplayPascalsTriangle();

            var result = pascalTriangle.Pascal(depth);

            return Ok(result);

        }
    }
}
