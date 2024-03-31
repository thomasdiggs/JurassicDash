
namespace JurassicDash
{
    internal interface IGameEntity
    {
        int DrawOrder { get; }
        void Update(GameTime gameTime);
        void Draw(SpriteBatch spriteBatch, GameTime gameTime);
    }
}
