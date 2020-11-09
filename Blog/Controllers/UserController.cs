using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Dal.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _userRepository.GetTopTen();
            return Ok(users);
        }
        [HttpGet("{name}")]
        public async Task<IActionResult> Search(string name)
        {
            var users = await _userRepository.Search(name);
            return Ok(users);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _userRepository.GetById(id);
            return Ok(user);
        }
    }
}
