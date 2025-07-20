using MyToDo.Communication.Enums;

namespace MyToDo.Communication.Responses;
public class ResponseTaskCreatedJson
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public PriorityTask Priority { get; set; }

    public StatusTask Status { get; set; }

    public DateTime Deadline { get; set; }
}
