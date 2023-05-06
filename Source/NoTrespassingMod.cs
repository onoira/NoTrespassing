using System.Collections.Generic;
using ExtremelySimpleLogger;
using MLEM.Data;
using MLEM.Data.Content;
using MLEM.Textures;
using TinyLife;
using TinyLife.Mods;

namespace NoTrespassingMod;

public class NoTrespassingMod : Mod
{

    public static Logger Logger { get; private set; }

    public override string Name => "No Trespassing";
    public override string Description => "Lorem ipsum";
    public override TextureRegion Icon => this.uiTextures[new Point(0, 0)];

    private Dictionary<Point, TextureRegion> uiTextures;

    public override void AddGameContent(GameImpl game, ModInfo info)
    {
        // ...
    }

    public override void Initialize(Logger logger, RawContentManager content, RuntimeTexturePacker texturePacker, ModInfo info)
    {
        NoTrespassingMod.Logger = logger;
        texturePacker.Add(new UniformTextureAtlas(content.Load<Texture2D>("UiTextures"), 8, 8), r => this.uiTextures = r, 1, true);
    }
}
