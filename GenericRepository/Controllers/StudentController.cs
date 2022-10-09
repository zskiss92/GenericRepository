using GenericRepository.Models;
using GenericRepository.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepository.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var studentList = _unitOfWork.Student.GetAll();

            return Ok(studentList);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var student = _unitOfWork.Student.GetFirstOrDefault(x => x.Id == id);
            if(student == null)
            {
                return NotFound("Student not found");
            }

            return Ok(student);
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            _unitOfWork.Student.Add(student);
            _unitOfWork.Student.Save();

            return Ok("Successfully saved");
        }

        [HttpPut]
        public IActionResult Update(Student student)
        {
            _unitOfWork.Student.Update(student);
            _unitOfWork.Save();

            return Ok(student);
        }

        [HttpDelete]
        public IActionResult Delete(Student student)
        {
            _unitOfWork.Student.Remove(student);
            _unitOfWork.Student.Save();

            return Ok("Successfully deleted");
        }
    }
}
