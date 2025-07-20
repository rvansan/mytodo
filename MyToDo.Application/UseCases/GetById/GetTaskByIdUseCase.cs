using MyToDo.Communication.Enums;
using MyToDo.Communication.Responses;

namespace MyToDo.Application.UseCases.GetById;
public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson()
        {
            Deadline = DateTime.Now,
            Description = "descrição",
            Id = 1,
            Name = "Task 1",
            Priority = PriorityTask.Baixa,
            Status = StatusTask.Aguardando
        };
    }
}
