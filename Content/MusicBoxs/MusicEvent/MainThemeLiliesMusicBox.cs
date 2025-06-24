using Terraria.ModLoader;
using EnderLiliesMusicPack.Content.Rarity;
using EnderLiliesMusicPack.Content.Tiles.MusicEvent;
using EnderLiliesMusicPack.Common;

namespace EnderLiliesMusicPack.Content.MusicBoxs.MusicEvent
{
    public class MainThemeLiliesMusicBox : BaseMusicBox, ILocalizedModType
    {
        public override string MusicName => MusicPathing.MainThemeLilies;
        public override int MusicBoxTile => ModContent.TileType<MainThemeLiliesMusicBoxTile>();
        public override int LiliesOrLilac => LiliesRarityID.liliesID;
    }
}
