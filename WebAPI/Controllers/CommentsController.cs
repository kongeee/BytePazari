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
    public class CommentsController : ControllerBase {
        ICommentService _commentService;

        public CommentsController(ICommentService commentService) {
            _commentService = commentService;
        }

        [HttpGet("getcommentdetails")]
        public IActionResult GetCommentDetails() {
            var result = _commentService.GetCommentDetails();
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcommentsbyproductid")]
        public IActionResult GetCommentsByProductid(int productId) {
            var result = _commentService.GetCommentsByProductId(productId);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Comment comment) {
            var result = _commentService.Add(comment);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Comment comment) {
            var result = _commentService.Update(comment);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Comment comment) {
            var result = _commentService.Delete(comment);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
