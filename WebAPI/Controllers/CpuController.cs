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
    public class CpuController : ControllerBase {
        ICpuService _cpuService;

        public CpuController(ICpuService cpuService) {
            _cpuService = cpuService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll() {
            var result = _cpuService.GetAll();
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
