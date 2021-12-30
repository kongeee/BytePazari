using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase {
        IAddressService _addressService;

        public AddressesController(IAddressService addressService) {
            _addressService = addressService;
        }

        [HttpGet("getuseraddresses")]
        public IActionResult GetUserAddresses(int userId) {
            var result = _addressService.GetUserAddresses(userId);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetByid(int addressId) {
            var result = _addressService.Get(addressId);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Address address) {
            var result = _addressService.Add(address);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Address address) {
            var result = _addressService.Update(address);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Address address) {
            var result = _addressService.Delete(address);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
