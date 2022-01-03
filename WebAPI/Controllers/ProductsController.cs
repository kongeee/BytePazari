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
    public class ProductsController : ControllerBase {

        IProductService _productService;

        public ProductsController(IProductService productService) {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll() {
            var result = _productService.GetAll();

            if (result.Success) {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int productId) {
            var result = _productService.Get(productId);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(Product product) {
            var result = _productService.Add(product);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Product product) {
            var result = _productService.Update(product);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Product product) {
            var result = _productService.Delete(product);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallwithdetails")]
        public IActionResult GetAllWithDetails() {
            var result = _productService.GetProductDetails();
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallwithdetailsbyid")]
        public IActionResult GetAllWithDetailsById(int productId) {
            var result = _productService.GetProductDetailsById(productId);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallbybrandid")]
        public IActionResult GetAllByBrandId(int brandId) {
            var result = _productService.GetAllByBrandId(brandId);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }



    }
}
