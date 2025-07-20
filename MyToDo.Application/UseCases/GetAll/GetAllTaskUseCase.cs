using MyToDo.Communication.Enums;
using MyToDo.Communication.Responses;

namespace MyToDo.Application.UseCases.GetAll;
public class GetAllTaskUseCase
{
    public ResponseAllTaskJson Execute()
    {
        return new ResponseAllTaskJson { 
            Tasks = new()
            {
                new ResponseShortTaskJson {Id = 1, Name = "Task 1", Status = StatusTask.Concluida},
                new ResponseShortTaskJson {Id = 2, Name = "Task 2", Status = StatusTask.EmAndamento},
                new ResponseShortTaskJson {Id = 3, Name = "Task 3", Status = StatusTask.Aguardando},
            }
        };
    }
}
