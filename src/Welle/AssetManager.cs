using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Graphics;

namespace Welle;

public static class AssetManager
{
    private static readonly Dictionary<string, Texture2D> _textures = new();

    public static string AssetPath => App.Instance.ProjectPath;

    public static Texture2D LoadTexture(string path)
    {
        string key = Path.Combine(AssetPath, path);

        if (_textures.TryGetValue(key, out var existing))
            return existing;

        using var stream = File.OpenRead(key);
        var tex = Texture2D.FromStream(App.Instance.GraphicsDevice, stream);

        _textures[key] = tex;
        return tex;
    }

    public static bool TryGetTexture(string path, out Texture2D tex)
    {
        string key = Path.GetFullPath(path);
        return _textures.TryGetValue(key, out tex);
    }

    public static void UnloadTexture(string path)
    {
        string key = Path.GetFullPath(path);
        if (_textures.TryGetValue(key, out var tex))
        {
            tex.Dispose();
            _textures.Remove(key);
        }
    }

    public static void UnloadAll()
    {
        foreach (var tex in _textures.Values)
            tex.Dispose();

        _textures.Clear();
    }
}
