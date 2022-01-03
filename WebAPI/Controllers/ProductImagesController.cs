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
    public class ProductImagesController : ControllerBase {
        IProductImageService _productImageService;
        public ProductImagesController(IProductImageService productImageService) {
            _productImageService = productImageService;
        }
        [HttpPost("add")]
        public IActionResult Add([FromForm] IFormFile file, [FromForm] ProductImage productImage) {
            var result = _productImageService.Add(file, productImage);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(ProductImage productImage) {
            var result = _productImageService.Delete(productImage);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update([FromForm] IFormFile file, [FromForm] ProductImage productImage) {
            var result = _productImageService.Update(file, productImage);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll() {
            var result = _productImageService.GetAll();
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyproductid")]
        public IActionResult GetByProductId(int productId) {
            var result = _productImageService.GetByProductId(productId);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyimageid")]
        public IActionResult GetByImageId(int imageId) {
            var result = _productImageService.GetByImageId(imageId);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}