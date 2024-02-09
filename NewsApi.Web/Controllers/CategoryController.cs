using Microsoft.AspNetCore.Mvc;
using NewsApi.Core.Entities;
using NewsApi.Core.Interfaces;
using System.Threading.Tasks;


namespace NewsApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CategoryController : ControllerBase
    {
        //private readonly INewsService<Category> _categorysService;

        //public CategoryController(INewsService<Category> _categoryService)
        //{
        //    _categorysService = _categoryService;
        //}

        //[HttpGet("GetAll")]
        //public async Task<IActionResult> GetAll()
        //{
        //    var category = await _categorysService.GetAll();
        //    return Ok(category);
        //}

        //[HttpPost("GetAll")]
        //public async Task<IActionResult> GetById(int Id)
        //{
        //    var category = await _categorysService.Get(Id);
        //    return Ok(category);
        //}

        //[HttpPost("Insert")]
        //public async Task<IActionResult> Insert(Category model)
        //{
        //    await _categorysService.Insert(model);
        //    return Ok();
        //}

        //[HttpPost("Update")]
        //public async Task<IActionResult> Update(Category model)
        //{
        //    await _categorysService.Update(model);
        //    return Ok();
        //}

        //[HttpDelete("Delete")]
        //public async Task<IActionResult> Delete(int Id)
        //{
        //    await _categorysService.Delete(Id);
        //    return Ok();
        //}
    }

}
