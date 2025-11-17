
using Lua;

namespace Welle.Lua.Modules.Graphics;

[LuaObject]
public partial class LuaColor
{
    [LuaMember("r")]
    public int R;
    [LuaMember("g")]
    public int G;
    [LuaMember("b")]
    public int B;
    [LuaMember("a")]
    public int A;

    [LuaMember("init")]
    public static LuaColor Init(int r, int g, int b, int a)
    {
        return new LuaColor()
        {
            R = r,
            G = g,
            B = b,
            A = a
        };
    }
    
    public Microsoft.Xna.Framework.Color ToXnaColor()
    {
        return new Microsoft.Xna.Framework.Color(R, G, B, A);
    }
}
