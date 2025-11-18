using Lua;

namespace Welle.Lua.Modules.Math;

[LuaObject]
public partial class LuaMath
{
    [LuaMember("vector2")]
    public static LuaVector2 Vector2 = new LuaVector2();
}
