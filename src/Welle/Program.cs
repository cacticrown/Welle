namespace Welle;

class Program
{
    static void Main(string[] args)
    {
        string projectPath = args.Length > 0 ? args[0] : string.Empty;

        App app = new App(projectPath);
        app.Run();
    }
}
