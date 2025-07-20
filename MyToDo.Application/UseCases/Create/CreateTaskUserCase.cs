using MyToDo.Communication.Requests;
using MyToDo.Communication.Responses;

namespace MyToDo.Application.UseCases.Create;
public class CreateTaskUserCase
{
    public ResponseTaskCreatedJson Execute(RequestNewTaskJson request)
    {
        return new ResponseTaskCreatedJson()
        {
            Deadline = request.Deadline,
            Description = request.Description,  
            Id = 1,
            Name = request.Name,
            Priority = request.Priority,    
            Status = request.Status,
        };
    }
}
