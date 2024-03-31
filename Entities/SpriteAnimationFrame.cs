
namespace JurassicDash
{
    internal class SpriteAnimationFrame
    {
        public Sprite Sprite { get; set; }
        public float TimeStamp { get; }
        
        public SpriteAnimationFrame(Sprite sprite, float timeStamp)
        {
            Sprite = sprite;
            TimeStamp = timeStamp;
        }
    }
}
