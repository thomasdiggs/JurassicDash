

namespace JurassicDash
{
    internal class TRex : IGameEntity
    {
        private const int TREX_DEFAULT_SPRITE_POS_X = 848;
        private const int TREX_DEFAULT_SPRITE_POS_Y = 2;
        private const int TREX_DEFAULT_SPRITE_WIDTH = 44;
        private const int TREX_DEFAULT_SPRITE_HEIGHT = 47;
        private const int TREX_IDLE_BACKGROUND_SPRITE_POS_X = 40;
        private const int TREX_IDLE_BACKGROUND_SPRITE_POS_Y = 4;
        private const int TREX_IDLE_SPRITE_WIDTH = 44;
        private const int TREX_IDLE_SPRITE_HEIGHT = 45;
        private Sprite _idleBackgroundSprite;
        private SpriteAnimation _idleAnimation;

        public Sprite Sprite { get; private set; }
        public TRexState State { get; private set; }
        public bool IsAlive { get; private set; }
        public float Speed { get; private set; }
        public Vector2 Position { get; set; }
        public int DrawOrder { get; set; }

        public TRex(Texture2D texture, Vector2 position)
        {
            Sprite = new Sprite(texture, TREX_DEFAULT_SPRITE_POS_X, TREX_DEFAULT_SPRITE_POS_Y, TREX_DEFAULT_SPRITE_WIDTH, TREX_DEFAULT_SPRITE_HEIGHT);
            Position = new Vector2(position.X, position.Y - Sprite.Height);
            _idleBackgroundSprite = new Sprite(texture, TREX_IDLE_BACKGROUND_SPRITE_POS_X, TREX_IDLE_BACKGROUND_SPRITE_POS_Y, TREX_IDLE_SPRITE_WIDTH, TREX_IDLE_SPRITE_HEIGHT);
            State = TRexState.Idle;
            _idleAnimation = new SpriteAnimation();
            _idleAnimation.AddFrame(Sprite, 0);
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            if (State == TRexState.Idle)
            {
                _idleBackgroundSprite.Draw(spriteBatch, Position);
            }
            else
            {
                Sprite.Draw(spriteBatch, Position);
            }
        }

        public void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }
    }
}
