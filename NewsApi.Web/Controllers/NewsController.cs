using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NewsApi.Core.DTOs;
using NewsApi.Core.Entities;
using NewsApi.Core.Interfaces;

namespace NewsApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly IBaseService<News> _newsService;
        private readonly IMapper _mapper;
        public NewsController(IBaseService<News> newsService, IMapper mapper)
        {
            _newsService = newsService;
            _mapper = mapper;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var news = await _newsService.GetAll();
            var newsDtoList = news.Select(n => _mapper.Map<NewsDto>(n)).ToList();
            return Ok(newsDtoList);
        }

        [HttpPost("GetById")]
        public async Task<IActionResult> GetById(int Id)
        {
            var news = await _newsService.Get(Id);
            var newsDto = _mapper.Map<NewsDto>(news);
            return Ok(newsDto);
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(NewsInsertDto model)
        {
            await _newsService.Insert(model);
            return Ok();
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update(NewsInsertDto model, int id)
        {
            await _newsService.Update(model, id);
            return Ok();
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int Id)
        {
            await _newsService.Delete(Id);
            return Ok();
        }
    }
}