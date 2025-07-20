using MyToDo.Communication.Enums;

namespace MyToDo.Communication.Responses;
public class ResponseShortTaskJson
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public StatusTask Status { get; set; }

    
}
