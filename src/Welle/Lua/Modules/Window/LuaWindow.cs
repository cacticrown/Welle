using Lua;
using System.Numerics;

namespace Welle.Lua.Modules.Window;

[LuaObject]
public partial class LuaWindow
{
    [LuaMember("width")]
    public int Width
    {
        get => App.Instance.GraphicsDevice.Viewport.Width;
        set {
            App.Instance.GraphicsDeviceManager.PreferredBackBufferWidth = value;
            App.Instance.GraphicsDeviceManager.ApplyChanges();
        }
    }

    [LuaMember("height")]
    public int Height
    {
        get => App.Instance.GraphicsDevice.Viewport.Height;
        set {
            App.Instance.GraphicsDeviceManager.PreferredBackBufferHeight = value;
            App.Instance.GraphicsDeviceManager.ApplyChanges();
        }
    }
}
