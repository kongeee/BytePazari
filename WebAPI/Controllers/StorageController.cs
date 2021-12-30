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
    public class StorageController : ControllerBase {
        IStorageService _storageService;

        public StorageController(IStorageService storageService) {
            _storageService = storageService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll() {
            var result = _storageService.GetAll();
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
