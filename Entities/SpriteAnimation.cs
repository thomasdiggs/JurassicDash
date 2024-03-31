
namespace JurassicDash
{
    internal class SpriteAnimation
    {
        private readonly List<SpriteAnimationFrame> _frames = new();

        public bool IsPlaying { get; private set; }
        public float PlaybackProgress { get; private set; }
        public void AddFrame(Sprite sprite, float timeStamp)
        {
            _frames.Add(new SpriteAnimationFrame(sprite, timeStamp));
        }
        public void Update(GameTime gameTime)
        {
        }
        public void Play()
        {
            IsPlaying = true;
        }
        public void Stop()
        {
            IsPlaying = false;
        }
    }
}
