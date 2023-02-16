
using System.Collections.Concurrent;

namespace LeetCodeTasks;

public class GarbageTraining
{
    static internal readonly ConcurrentQueue<GarbageTraining> failedDeletions = new();

    public readonly string FilePath;
    public Exception DeletionError { get; private set; }

    public GarbageTraining(string filePath)
    {
        FilePath = filePath;
    }

    ~GarbageTraining() 
    {
        try
        {
            File.Delete(FilePath);
        }
        catch (Exception ex)
        {
            DeletionError = ex;
            failedDeletions.Enqueue(this); // восстановление объекта, создаем ещё одну ссылку на объект, что не позволит GC его удалить
        }
    }

}
