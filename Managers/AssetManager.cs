namespace JurassicDash
{
    internal static class AssetManager
    {
        public static ContentManager _content;

        // ---- ASSET STRINGS ----
        // SPRITES
        private const string ASSET_SPRITE_PATH = "Assets\\Sprites\\";
        private const string ASSET_SPRITESHEET_TRex = $"{ASSET_SPRITE_PATH}TRex";
        // SOUNDS
        private const string ASSET_SOUND_PATH = "Assets\\Sounds\\";
        private const string ASSET_SFX_PlayerHit = $"{ASSET_SOUND_PATH}PlayerHit";
        private const string ASSET_SFX_ScoreReached = $"{ASSET_SOUND_PATH}ScoreReached";
        private const string ASSET_SFX_ButtonPress = $"{ASSET_SOUND_PATH}ButtonPress";

        // ---- ASSET VARIABLES ----
        // SPRITES
        public static Texture2D SpriteSheetTRex { get; private set; }
        // SOUNDS
        public static SoundEffect SfxPlayerHit { get; private set; }
        public static SoundEffect SfxScoreReached { get; private set; }
        public static SoundEffect SfxButtonPress { get; private set; }

        public static void LoadContent()
        {
            // SPRITES
            SpriteSheetTRex = _content.Load<Texture2D>(ASSET_SPRITESHEET_TRex);
            // SOUNDS
            SfxPlayerHit = _content.Load<SoundEffect>(ASSET_SFX_PlayerHit);
            SfxScoreReached = _content.Load<SoundEffect>(ASSET_SFX_ScoreReached);
            SfxButtonPress = _content.Load<SoundEffect>(ASSET_SFX_ButtonPress);
        }
    }
}
