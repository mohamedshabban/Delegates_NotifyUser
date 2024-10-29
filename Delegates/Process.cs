namespace Delegates;

public class Process
{
    public Notify? OnCompleted;
    public void StartProcess()
    {
        Console.WriteLine("Process Started!!");
        Thread.Sleep(1000);
        OnCompleted?.Invoke();
    }
    public void NotifyUser()
    {
        Console.WriteLine("Process Completed!!");
    }
}