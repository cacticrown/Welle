using Microsoft.Xna.Framework;

namespace Welle;

class Program
{
    static void Main(string[] args)
    {
        string projectPath = args.Length > 0 ? args[0] : string.Empty;
        projectPath = projectPath.Trim('\"');
        App app = new App(projectPath);
        app.Run();
    }
}
