using Lua;
using Microsoft.Xna.Framework;

namespace Welle.Lua.Modules.Graphics;

[LuaObject]
public partial class LuaGraphics
{
    [LuaMember("clear")]
    public static void Clear(float r, float g, float b, float a)
    {
        App.Instance.GraphicsDevice.Clear(new Color(r, g, b, a));
    }

    [LuaMember("loadTexture")]
    public static LuaTexture LoadTexture(string path)
    {
        AssetManager.LoadTexture(path);
        return new LuaTexture(path);
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
