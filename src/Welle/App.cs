using Lua;
using Lua.Standard;
using Microsoft.Xna.Framework;
using System.Threading.Tasks;

namespace Welle;

public class App : Game
{
    public string ProjectPath;

    public LuaState LuaState;
    public LuaFunction LuaUpdateFunction;

    public App(string projectPath)
    {
        ProjectPath = projectPath;

        GraphicsDeviceManager gdm = new GraphicsDeviceManager(this);

        gdm.IsFullScreen = false;
        gdm.SynchronizeWithVerticalRetrace = true;

        Window.AllowUserResizing = true;
        IsMouseVisible = true;
    }

    protected async override void Initialize()
    {
        LuaState = LuaState.Create();
        LuaState.OpenStandardLibraries();

        await LuaState.DoFileAsync(Path.Combine(ProjectPath, "main.lua"));

        LuaUpdateFunction = LuaState.Environment["update"].Read<LuaFunction>();


        base.Initialize();
    }

    protected override void LoadContent()
    {
        base.LoadContent();
    }

    protected override void UnloadContent()
    {
        base.UnloadContent();
    }

    protected async override void Update(GameTime gameTime)
    {
        await LuaUpdateFunction.InvokeAsync(LuaState, new LuaValue[] {  });

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);
        base.Draw(gameTime);
    }
}