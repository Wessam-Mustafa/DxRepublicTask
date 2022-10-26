using BLL.Services.Interfaces;
using CORE.DTO.Parent;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static CORE.Shared.Enums;

namespace DxRepublic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentController : ControllerBase
    {
        private IParentService parentService { get; }

        public ParentController(IParentService _parentService)
        {
            parentService = _parentService;
        }

        [HttpPost("addParent")]
        public IActionResult AddParent([FromBody] ParentInput parentInput)
        {
            var response = parentService.Add(parentInput);
            switch (response.Code)
            {
                case 200:
                    return Ok(response);
                case 400:
                    return StatusCode(StatusCodes.Status400BadRequest, response);
                case 404:
                    return StatusCode(StatusCodes.Status404NotFound, response);
                default:
                    return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        [HttpPost("updateParent")]
        public IActionResult UpdateParent([FromBody] ParentInput parentInput)
        {
            var response = parentService.Update(parentInput);
            switch (response.Code)
            {
                case 200:
                    return Ok(response);
                case 400:
                    return StatusCode(StatusCodes.Status400BadRequest, response);
                case 404:
                    return StatusCode(StatusCodes.Status404NotFound, response);
                default:
                    return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        [HttpPost("deleteParent/{parentId}")]
        public IActionResult DeleteParent(int parentId)
        {
            var response = parentService.Delete(parentId);
            switch (response.Code)
            {
                case 200:
                    return Ok(response);
                case 400:
                    return StatusCode(StatusCodes.Status400BadRequest, response);
                case 404:
                    return StatusCode(StatusCodes.Status404NotFound, response);
                default:
                    return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        [HttpGet("getOne/{parentId}")]
        public IActionResult GetOneParent(int parentId)
        {
            var response = parentService.GetOne(parentId);
            switch (response.Code)
            {
                case 200:
                    return Ok(response);
                case 400:
                    return StatusCode(StatusCodes.Status400BadRequest, response);
                case 404:
                    return StatusCode(StatusCodes.Status404NotFound, response);
                default:
                    return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        [HttpGet("getAll")]
        public IActionResult GetAllParents()
        {
            var response = parentService.GetAll();
            switch (response.Code)
            {
                case 200:
                    return Ok(response);
                case 400:
                    return StatusCode(StatusCodes.Status400BadRequest, response);
                case 404:
                    return StatusCode(StatusCodes.Status404NotFound, response);
                default:
                    return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        [HttpGet("getByParentNationalId/{nationalId}")]
        public IActionResult GetByParentNationalId(string nationalId)
        {
            var response = parentService.GetByParentNationalId(nationalId);
            switch (response.Code)
            {
                case 200:
                    return Ok(response);
                case 400:
                    return StatusCode(StatusCodes.Status400BadRequest, response);
                case 404:
                    return StatusCode(StatusCodes.Status404NotFound, response);
                default:
                    return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        [HttpGet("getByStudentName/{name}")]
        public IActionResult GetByStudentName(string name)
        {
            var response = parentService.GetByStudentName(name);
            switch (response.Code)
            {
                case 200:
                    return Ok(response);
                case 400:
                    return StatusCode(StatusCodes.Status400BadRequest, response);
                case 404:
                    return StatusCode(StatusCodes.Status404NotFound, response);
                default:
                    return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        [HttpGet("getByStudentGender/{gender}")]
        public IActionResult GetByStudentGender(Gender gender)
        {
            var response = parentService.GetByStudentGender(gender);
            switch (response.Code)
            {
                case 200:
                    return Ok(response);
                case 400:
                    return StatusCode(StatusCodes.Status400BadRequest, response);
                case 404:
                    return StatusCode(StatusCodes.Status404NotFound, response);
                default:
                    return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        [HttpGet("getByStudentAgeRange/{startAge}/{endAge}")]
        public IActionResult GetByStudentAgeRange(int startAge, int endAge)
        {
            var response = parentService.GetByStudentAgeRange(startAge, endAge);
            switch (response.Code)
            {
                case 200:
                    return Ok(response);
                case 400:
                    return StatusCode(StatusCodes.Status400BadRequest, response);
                case 404:
                    return StatusCode(StatusCodes.Status404NotFound, response);
                default:
                    return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }
    }
}
