using static DeltaTask.Common.Enums;

namespace DeltaTask.Data.Entities;

public class TaskModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DeltaTaskType Type { get; set; } = DeltaTaskType.Unknown;
    public DeltaTaskStatus Status { get; set; } = DeltaTaskStatus.Created;
}
