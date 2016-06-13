using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace RPG
{
    // managed our screens
    public class ScreenManager
    {
        // singleton class -> only one instance
        private static ScreenManager instance;
        GameScreen currentScreen;

        public ScreenManager()
        {
            Dimentions = new Vector2(640, 480);
            currentScreen = new SplashScreen();
        }

        public Vector2 Dimentions { get; private set; }
        public ContentManager Content { get; private set; }

        public static ScreenManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ScreenManager();
                }

                return instance;
            } // no set accessor
        }

        public void LoadContent(ContentManager Content)
        {
            this.Content = new ContentManager(Content.ServiceProvider, "Content");
            currentScreen.LoadContent();
        }

        // will unload all we don't needed
        public void UnloadContent()
        {
            currentScreen.UnloadContent();
        }

        public void Update(GameTime gameTime)
        {
            currentScreen.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            currentScreen.Draw(spriteBatch);
        }
    }
}
