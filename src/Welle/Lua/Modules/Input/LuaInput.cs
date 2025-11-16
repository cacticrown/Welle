using Lua;

namespace Welle.Lua.Modules.Input;

[LuaObject]
public partial class LuaInput
{
    [LuaMember("keyboard")]
    public static LuaKeyboard Keyboard = new LuaKeyboard();
}
