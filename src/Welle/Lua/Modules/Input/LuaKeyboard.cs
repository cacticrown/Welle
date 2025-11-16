using System;
using Lua;
using Microsoft.Xna.Framework.Input;

namespace Welle.Lua.Modules.Input;

[LuaObject]
public partial class LuaKeyboard
{
    [LuaMember("isKeyDown")]
    public static bool IsKeyDown(string key)
    {
        if (!Enum.TryParse<Keys>(key, true, out var keyEnum))
            return false;

        return App.Instance.KeyboardState.IsKeyDown(keyEnum);
    }
}