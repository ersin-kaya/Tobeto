using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]         //domainKismi/api/controllerAdi -> domainKismi/api/products
    [ApiController]
    public class CoursesController : ControllerBase
    {
        ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        //[HttpGet("getall")]
        //public List<Course> GetAll()
        //{
        //    return _courseService.GetAll().Data;
        //}

        //[HttpGet("getall")]
        //public IDataResult<List<Course>> GetAll()
        //{
        //    return _courseService.GetAll();
        //}

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _courseService.GetAll();

            if (result.Success)
            {
                return Ok(result);         //http status kodlarına göre veri döner
            }
            return BadRequest(result);     //http status kodlarına göre veri döner
            //return NotFound(result);     //örn: burada "status: 404 Not Found" olacaktı
        }

        [HttpPost("add")]
        public IActionResult Add(Course course)
        {
            var result = _courseService.Add(course);
            
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Course course)
        {
            var result = _courseService.Update(course);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Course course)
        {
            var result = _courseService.Delete(course);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcoursedetails")]
        public IActionResult GetCourseDetails(int id)
        {
            var result = _courseService.GetCourseDetails(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
