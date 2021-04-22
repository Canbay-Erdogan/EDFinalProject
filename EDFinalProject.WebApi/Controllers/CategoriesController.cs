using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EDFinalProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryservice;
        public CategoriesController(ICategoryService categoryservice)
        {
            _categoryservice = categoryservice;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return Ok(_categoryservice.GetAll());
        }
    }
}
