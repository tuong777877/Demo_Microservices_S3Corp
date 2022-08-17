using StoreCar_Microservice.Repository.Constracts;
using Microsoft.AspNetCore.Mvc;
using StoreCar_Microservice.Model;

namespace StoreCar_Microservice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryCarRepositoryController : Controller
    {
        private readonly ICategoryCarRepository _categoryCarRepository;
        public CategoryCarRepositoryController(ICategoryCarRepository cateCarRepository)
        {
            _categoryCarRepository = cateCarRepository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_categoryCarRepository.GetAll());
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var cateCar = _categoryCarRepository.GetById(id);
                if (cateCar != null)
                {
                    return Ok(cateCar);
                }
                return NotFound();
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public IActionResult Create(CategoryCarModel model)
        {
            try
            {
                return Ok(_categoryCarRepository.Add(model));
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, CategoryCarVM catecarVM)
        {
            if (id != catecarVM.Id)
            {
                return BadRequest();
            }
            try
            {
                _categoryCarRepository.Update(catecarVM);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _categoryCarRepository.Delete(id);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
