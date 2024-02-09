using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NewsApi.Core.DTOs;
using NewsApi.Core.Entities;
using NewsApi.Core.Interfaces;

namespace NewsApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IBaseService<Users> _usersService;
        private readonly IMapper _mapper;

        public UsersController(IBaseService<Users> userService, IMapper mapper)
        {
            _usersService = userService;
            _mapper = mapper;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var news = await _usersService.GetAll();
            var newsDtoList = news.Select(n => _mapper.Map<UsersDto>(n)).ToList();
            return Ok(newsDtoList);
        }

        [HttpPost("GetById")]
        public async Task<IActionResult> GetById(int Id)
        {
            var news = await _usersService.Get(Id);
            var newsDto = _mapper.Map<UsersDto>(news);
            return Ok(newsDto);
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(UsersDto model)
        {
            await _usersService.Insert(model);
            return Ok();
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update(UsersDto model, int id)
        {
            await _usersService.Update(model, id);
            return Ok();
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _usersService.Delete(id);
            return Ok();
        }
    }
}
