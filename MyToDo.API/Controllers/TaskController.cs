using Microsoft.AspNetCore.Mvc;
using MyToDo.Application.UseCases.Create;
using MyToDo.Communication.Requests;
using MyToDo.Communication.Responses;

namespace MyToDo.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseTaskCreatedJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] RequestNewTaskJson request) 
    {
        var response = new CreateTaskUserCase().Execute(request);
        return Created(string.Empty, response);
    }
}
