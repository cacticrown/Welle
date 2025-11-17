using Lua;
using Microsoft.Xna.Framework;
using Welle.Lua.Modules.Input;

namespace Welle.Lua.Modules.Graphics;

[LuaObject]
public partial class LuaGraphics
{
    [LuaMember("color")]
    public static LuaColor Color = new LuaColor();

    [LuaMember("clear")]
    public static void Clear(LuaColor color)
    {
        App.Instance.GraphicsDevice.Clear(color.ToXnaColor());
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
        App.Instance.SpriteBatch.Draw(AssetManager.LoadTexture(texture.Path), new Vector2(x, y), Microsoft.Xna.Framework.Color.White);
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
