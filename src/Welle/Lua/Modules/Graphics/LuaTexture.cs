using Lua;

namespace Welle.Lua.Modules.Graphics;

[LuaObject]
public partial class LuaTexture
{
    [LuaMember("width")]
    public int Width = 0;

    [LuaMember("height")]
    public int Height = 0;

    [LuaMember("path")]
    public string Path;

    public LuaTexture(string path, int width, int height)
    {
        Path = path;
        Width = width;
        Height = height;
    }
}
