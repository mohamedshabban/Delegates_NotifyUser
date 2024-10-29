
namespace Delegates
{

    public delegate void Notify();

    public class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();
            process.OnCompleted = process.NotifyUser;
            process.StartProcess();
        }
    }
}



