using MyToDo.Communication.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDo.Communication.Responses;
public class ResponseTaskJson
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public PriorityTask Priority { get; set; }

    public StatusTask Status { get; set; }

    public DateTime Deadline { get; set; }
}
