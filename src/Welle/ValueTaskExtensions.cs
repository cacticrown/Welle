namespace Welle;

public static class ValueTaskExtensions
{
    public static T RunSynchronously<T>(this ValueTask<T> valueTask)
    {
        if (valueTask.IsCompleted)
        {
            return valueTask.GetAwaiter().GetResult();
        }

        return valueTask.AsTask().GetAwaiter().GetResult();
    }
}