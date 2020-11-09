using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Dal.Repositories;
using Blog.Dal.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BlogController : Controller
    {
        private readonly IUserBlogRepository _userBlogRepository;
        public BlogController(IUserBlogRepository userBlogRepository)
        {
            _userBlogRepository = userBlogRepository;
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UserBlogUpdateDto blog)
        {
            await _userBlogRepository.Update(blog);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] UserBlogUpdateDto blog)
        {
            var newBlog = await _userBlogRepository.Add(blog);
            return Ok(newBlog);
 
        }

    }
}
