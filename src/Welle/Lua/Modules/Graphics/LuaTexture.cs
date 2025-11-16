using Lua;

namespace Welle.Lua.Modules.Graphics;

[LuaObject]
public partial class LuaTexture
{
    [LuaMember("path")]
    public string Path;

    public LuaTexture(string path)
    {
        Path = path;
    }
}
