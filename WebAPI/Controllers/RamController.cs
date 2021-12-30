using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class RamController : ControllerBase {
        IRamService _ramService;

        public RamController(IRamService ramService) {
            _ramService = ramService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll() {
            var result = _ramService.GetAll();
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
