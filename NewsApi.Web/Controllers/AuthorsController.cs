using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NewsApi.Core.DTOs;
using NewsApi.Core.Entities;
using NewsApi.Core.Interfaces;
using System.Threading.Tasks;

namespace NewsApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IBaseService<Authors> _authorsService;
        private readonly IMapper _mapper;

        public AuthorsController(IBaseService<Authors> authorsService, IMapper mapper)
        {
            _authorsService = authorsService;
            _mapper = mapper;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var news = await _authorsService.GetAll();
            var newsDtoList = news.Select(n => _mapper.Map<AuthorsDto>(n)).ToList();
            return Ok(newsDtoList);
        }

        [HttpPost("GetById")]
        public async Task<IActionResult> GetById(int Id)
        {
            var news = await _authorsService.Get(Id);
            var newsDto = _mapper.Map<AuthorsDto>(news);
            return Ok(newsDto);
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(AuthorsDto model)
        {
            await _authorsService.Insert(model);
            return Ok();
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update(AuthorsDto model, int id)
        {
            await _authorsService.Update(model, id);
            return Ok();
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int Id)
        {
            await _authorsService.Delete(Id);
            return Ok();
        }

    }
}
