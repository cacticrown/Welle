using Lua;
using Microsoft.Xna.Framework;
using Welle.Lua.Modules.Input;
using Welle.Lua.Modules.Math;

namespace Welle.Lua.Modules.Graphics;

[LuaObject]
public partial class LuaGraphics
{
    [LuaMember("clear")]
    public static void Clear(int r, int g, int b, int a)
    {
        App.Instance.GraphicsDevice.Clear(new Color(r, g, b, a));
    }

    [LuaMember("loadTexture")]
    public static LuaTexture LoadTexture(string path)
    {
        var texture = AssetManager.LoadTexture(path);
        return new LuaTexture(path, texture.Width, texture.Height);
    }

    [LuaMember("draw")]
    public static void Draw(LuaTexture texture, float x, float y)
    {
        App.Instance.SpriteBatch.Draw(AssetManager.LoadTexture(texture.Path), new Vector2(x, y), Color.White);
    }

    [LuaMember("beginDraw")]
    public static void BeginDraw()
    {
        App.Instance.SpriteBatch.Begin();
    }

    [LuaMember("endDraw")]
    public static void EndDraw()
    {
        App.Instance.SpriteBatch.End();
    }
}
