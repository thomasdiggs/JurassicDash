
namespace JurassicDash
{
    internal class SpriteAnimation
    {
        private readonly List<SpriteAnimationFrame> _frames = new();

        public bool IsPlaying { get; private set; }
        public float PlaybackProgress { get; private set; }

        // Cool C# feature: Indexer
        public SpriteAnimationFrame this[int index] => GetFrame(index);

        public SpriteAnimationFrame CurrentFrame
        {
            get
            {
                return _frames.Where(f => f.TimeStamp <= PlaybackProgress).OrderBy(f => f.TimeStamp).LastOrDefault();
            }
        }

        public float Duration
        {
            get
            {
                if (!_frames.Any())
                    return 0;

                return _frames.Max(f => f.TimeStamp);
            }
        }

        public void AddFrame(Sprite sprite, float timeStamp)
        {
            _frames.Add(new SpriteAnimationFrame(sprite, timeStamp));
        }

        public void Update(GameTime gameTime)
        {
            if (IsPlaying)
            {
                PlaybackProgress += (float)gameTime.ElapsedGameTime.TotalSeconds;

                if (PlaybackProgress > Duration)
                    PlaybackProgress -= Duration;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            SpriteAnimationFrame frame = CurrentFrame;
            if (frame != null)
                frame.Sprite.Draw(spriteBatch, position);
        }

        public void Play()
        {
            IsPlaying = true;
        }

        public void Stop()
        {
            IsPlaying = false;
            PlaybackProgress = 0;
        }

        public SpriteAnimationFrame GetFrame(int index)
        {
            if (index < 0 || index >= _frames.Count)
                throw new ArgumentOutOfRangeException(nameof(index), "A frame with index " + index + " does not exist in this animation");

            return _frames[index];
        }
    }
}
