using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NewsApi.Core.DTOs;
using NewsApi.Core.Entities;
using NewsApi.Core.Interfaces;

namespace NewsApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IBaseService<Statistics> _statisticsService;
        private readonly IMapper _mapper;

        public StatisticsController(IBaseService<Statistics> statisticsService, IMapper mapper)
        {
            _statisticsService = statisticsService;
            _mapper = mapper;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var news = await _statisticsService.GetAll();
            var newsDtoList = news.Select(n => _mapper.Map<StatisticsDto>(n)).ToList();
            return Ok(newsDtoList);
        }

        [HttpPost("GetById")]
        public async Task<IActionResult> GetById(int Id)
        {
            var news = await _statisticsService.Get(Id);
            var newsDto = _mapper.Map<StatisticsDto>(news);
            return Ok(newsDto);
        }
        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(StatisticsDto model)
        {
            await _statisticsService.Insert(model);
            return Ok();
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update(StatisticsDto model, int id)
        {
            await _statisticsService.Update(model, id);
            return Ok();
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int Id)
        {
            await _statisticsService.Delete(Id);
            return Ok();
        }

    }
}
