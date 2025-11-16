using Lua;
using Microsoft.Xna.Framework.Input;

namespace Welle.Lua.Modules.Input;

[LuaObject]
public partial class LuaKey
{
    [LuaMember("a")] public string A => "A";
    [LuaMember("b")] public string B => "B";
    [LuaMember("c")] public string C => "C";
    [LuaMember("d")] public string D => "D";
    [LuaMember("e")] public string E => "E";
    [LuaMember("f")] public string F => "F";
    [LuaMember("g")] public string G => "G";
    [LuaMember("h")] public string H => "H";
    [LuaMember("i")] public string I => "I";
    [LuaMember("j")] public string J => "J";
    [LuaMember("k")] public string K => "K";
    [LuaMember("l")] public string L => "L";
    [LuaMember("m")] public string M => "M";
    [LuaMember("n")] public string N => "N";
    [LuaMember("o")] public string O => "O";
    [LuaMember("p")] public string P => "P";
    [LuaMember("q")] public string Q => "Q";
    [LuaMember("r")] public string R => "R";
    [LuaMember("s")] public string S => "S";
    [LuaMember("t")] public string T => "T";
    [LuaMember("u")] public string U => "U";
    [LuaMember("v")] public string V => "V";
    [LuaMember("w")] public string W => "W";
    [LuaMember("x")] public string X => "X";
    [LuaMember("y")] public string Y => "Y";
    [LuaMember("z")] public string Z => "Z";


    [LuaMember("space")] public string Space => "Space";
    [LuaMember("enter")] public string Enter => "Enter";
    [LuaMember("escape")] public string Escape => "Escape";
    [LuaMember("tab")] public string Tab => "Tab";
    [LuaMember("back")] public string Back => "Back";
    [LuaMember("delete")] public string Delete => "Delete";
    [LuaMember("left")] public string Left => "Left";
    [LuaMember("right")] public string Right => "Right";
    [LuaMember("up")] public string Up => "Up";
    [LuaMember("down")] public string Down => "Down";
    [LuaMember("leftshift")] public string LeftShift => "LeftShift";
    [LuaMember("rightshift")] public string RightShift => "RightShift";
    [LuaMember("leftcontrol")] public string LeftControl => "LeftControl";
    [LuaMember("rightcontrol")] public string RightControl => "RightControl";
    [LuaMember("leftalt")] public string LeftAlt => "LeftAlt";
    [LuaMember("rightalt")] public string RightAlt => "RightAlt";
}
