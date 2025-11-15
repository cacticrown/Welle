using System;
using Microsoft.Xna.Framework;

namespace Welle;

public class App : Game
{
    public string ProjectPath;

    public App(string projectPath)
    {
        ProjectPath = projectPath;

        GraphicsDeviceManager gdm = new GraphicsDeviceManager(this);

        gdm.IsFullScreen = false;
        gdm.SynchronizeWithVerticalRetrace = true;

        Window.AllowUserResizing = true;
    }

    protected override void Initialize()
    {
        /* This is a nice place to start up the engine, after
         * loading configuration stuff in the constructor
         */
        base.Initialize();
    }

    protected override void LoadContent()
    {
        // Load textures, sounds, and so on in here...
        base.LoadContent();
    }

    protected override void UnloadContent()
    {
        // Clean up after yourself!
        base.UnloadContent();
    }

    protected override void Update(GameTime gameTime)
    {
        // Run game logic in here. Do NOT render anything here!
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        // Render stuff in here. Do NOT run game logic in here!
        GraphicsDevice.Clear(Color.CornflowerBlue);
        base.Draw(gameTime);
    }
}