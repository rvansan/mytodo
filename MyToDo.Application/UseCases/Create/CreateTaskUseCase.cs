using MyToDo.Communication.Requests;
using MyToDo.Communication.Responses;

namespace MyToDo.Application.UseCases.Create;
public class CreateTaskUseCase
{
    public ResponseTaskCreatedJson Execute(RequestTaskJson request)
    {
        return new ResponseTaskCreatedJson()
        {
            Id = 1,
            Name = request.Name,
        };
    }
}
