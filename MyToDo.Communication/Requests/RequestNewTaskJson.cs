using MyToDo.Communication.Enums;

namespace MyToDo.Communication.Requests;
public class RequestNewTaskJson
{
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public PriorityTask Priority { get; set; }

    public StatusTask Status { get; set; }

    public DateTime Deadline { get; set; }

}
