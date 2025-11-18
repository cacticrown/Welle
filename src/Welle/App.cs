using Lua;
using Lua.Standard;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Threading.Tasks;
using Welle.Lua.Modules.Graphics;
using Welle.Lua.Modules.Input;
using Welle.Lua.Modules.Math;
using Welle.Lua.Modules.Window;

namespace Welle;

public class App : Game
{
    public static App Instance;

    public KeyboardState KeyboardState;

    public string ProjectPath;

    public GraphicsDeviceManager GraphicsDeviceManager;
    public SpriteBatch SpriteBatch;

    #region Lua
    public LuaState LuaState;

    public LuaFunction LuaLoadFunction;
    public LuaFunction LuaUpdateFunction;
    public LuaFunction LuaDrawFunction;

    LuaTable WelleTable;

    #endregion

    public App(string projectPath)
    {
        ProjectPath = projectPath;

        Instance = this;

        GraphicsDeviceManager = new GraphicsDeviceManager(this);

        GraphicsDeviceManager.IsFullScreen = false;
        GraphicsDeviceManager.SynchronizeWithVerticalRetrace = true;

        Window.AllowUserResizing = true;
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        LuaState = LuaState.Create();
        LuaState.OpenStandardLibraries();

        LuaState.DoFileAsync(Path.Combine(ProjectPath, "main.lua")).GetAwaiter().GetResult();

        LuaLoadFunction = LuaState.Environment["load"].Read<LuaFunction>();
        LuaUpdateFunction = LuaState.Environment["update"].Read<LuaFunction>();
        LuaDrawFunction = LuaState.Environment["draw"].Read<LuaFunction>();

        WelleTable = new LuaTable();
        LuaState.Environment["welle"] = WelleTable;

        RegisterLuaModules();

        base.Initialize();
    }

    public void RegisterLuaModules()
    {
        WelleTable["graphics"] = new LuaGraphics();
        WelleTable["input"] = new LuaInput();
        WelleTable["window"] = new LuaWindow();
        WelleTable["math"] = new LuaMath();
    }

    protected override void LoadContent()
    {
        SpriteBatch = new SpriteBatch(GraphicsDeviceManager.GraphicsDevice);

        LuaLoadFunction.InvokeAsync(LuaState, new LuaValue[] { }).GetAwaiter().GetResult();

        base.LoadContent();
    }

    protected override void UnloadContent()
    {
        base.UnloadContent();
    }

    protected override void Update(GameTime gameTime)
    {
        KeyboardState = Keyboard.GetState();

        LuaUpdateFunction.InvokeAsync(LuaState, new LuaValue[] { new LuaValue(gameTime.ElapsedGameTime.TotalSeconds) }).GetAwaiter().GetResult();

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        LuaDrawFunction.InvokeAsync(LuaState, new LuaValue[] { }).GetAwaiter().GetResult();

        base.Draw(gameTime);
    }
}