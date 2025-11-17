using Lua;

namespace Welle.Lua.Modules.Window;

[LuaObject]
public partial class LuaWindow
{
    [LuaMember("getWidth")]
    public static int GetWidth() => App.Instance.GraphicsDevice.Viewport.Width;

    [LuaMember("getHeight")]
    public static int GetHeight() => App.Instance.GraphicsDevice.Viewport.Height;
}
