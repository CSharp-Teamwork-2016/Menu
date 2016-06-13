using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RPG
{
    public class SplashScreen : GameScreen
    {
        Texture2D image;
        public string Path;

        public override void LoadContent()
        {
            base.LoadContent();
            Path = "menu";
            image = content.Load<Texture2D>(Path);
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            //base.Draw(spriteBatch);
            spriteBatch.Draw(image, Vector2.Zero, Color.White);
        }
    }
}
