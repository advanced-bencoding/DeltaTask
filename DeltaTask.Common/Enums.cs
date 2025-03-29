namespace DeltaTask.Common;

public static class Enums
{
    public enum DeltaTaskStatus
    {
        Created = 0,
        Queued = 1,
        Running = 2,
        Success = 3,
        Failed = 4,
        Killed = 5,
    }

    public enum DeltaTaskType
    {
        Unknown = 0,
        Email = 1,
    }
}
