using Microsoft.AspNetCore.Mvc;
using MyToDo.Application.UseCases;
using MyToDo.Application.UseCases.Create;
using MyToDo.Application.UseCases.GetAll;
using MyToDo.Application.UseCases.GetById;
using MyToDo.Communication.Requests;
using MyToDo.Communication.Responses;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

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
        var response = new CreateTaskUseCase().Execute(request);
        return Created(string.Empty, response);
    }


    [HttpGet]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseAllTaskJson), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new GetAllTaskUseCase().Execute();

        if (response.Tasks.Any())
            return Ok(response); 
        
        return NoContent();
    }


    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult Get([FromRoute] int id) 
    {
        var response = new GetTaskByIdUseCase().Execute(id);
        return Ok(response);
    }
}
