using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NewsApi.Core.DTOs;
using NewsApi.Core.Entities;
using NewsApi.Core.Interfaces;

namespace NewsApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IBaseService<Roles> _rolesService;
        private readonly IMapper _mapper;

        public RolesController(IBaseService<Roles> _roleService, IMapper mapper)
        {
            _rolesService = _roleService;
            _mapper = mapper;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var news = await _rolesService.GetAll();
            var newsDtoList = news.Select(n => _mapper.Map<RolesDto>(n)).ToList();
            return Ok(newsDtoList);
        }

        [HttpPost("GetById")]
        public async Task<IActionResult> GetById(int Id)
        {
            var news = await _rolesService.Get(Id);
            var newsDto = _mapper.Map<RolesDto>(news);
            return Ok(newsDto);
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(RolesDto model)
        {
            await _rolesService.Insert(model);
            return Ok();
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update(RolesDto model, int id)
        {
            await _rolesService.Update(model, id);
            return Ok();
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _rolesService.Delete(id);
            return Ok();
        }

    }
}
