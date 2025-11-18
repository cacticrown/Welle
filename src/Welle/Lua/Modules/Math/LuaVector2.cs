using Lua;
using Microsoft.Xna.Framework;

namespace Welle.Lua.Modules.Math;

[LuaObject]
public partial class LuaVector2
{
    [LuaMember("y")]
    public float Y = 0;

    [LuaMember("x")]
    public float X = 0;

    [LuaMember("init")]
    public static LuaVector2 Init(float x, float y)
    {
        return new LuaVector2()
        {
            X = x,
            Y = y
        };
    }

    public Vector2 ToXnaVector()
    {
        return new Vector2(X, Y);
    }
}
