using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NewsApi.Core.DTOs;
using NewsApi.Core.Entities;
using NewsApi.Core.Interfaces;


namespace NewsApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CategoryController : ControllerBase
    {
        private readonly IBaseService<Category> _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(IBaseService<Category> categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var news = await _categoryService.GetAll();
            var newsDtoList = news.Select(n => _mapper.Map<CategoryDto>(n)).ToList();
            return Ok(newsDtoList);
        }

        [HttpPost("GetById")]
        public async Task<IActionResult> GetById(int Id)
        {
            var news = await _categoryService.Get(Id);
            var newsDto = _mapper.Map<CategoryDto>(news);
            return Ok(newsDto);
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(CategoryDto model)
        {
            await _categoryService.Insert(model);
            return Ok();
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update(CategoryDto model, int id)
        {
            await _categoryService.Update(model, id);
            return Ok();
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int Id)
        {
            await _categoryService.Delete(Id);
            return Ok();
        }
    }

}
