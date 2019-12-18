using System;
using System.Collections.Generic;
using MediumApi.Models;
using MediumApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace MediumApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetPosts()
        {
            return new OkObjectResult(_postService.GetPosts());
        }
    }
}
