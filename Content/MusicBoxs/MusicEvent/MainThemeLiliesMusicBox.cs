using Terraria.ModLoader;
using EnderLiliesMusicPack.Content.Rarity;
using EnderLiliesMusicPack.Content.Tiles.MusicEvent;
using EnderLiliesMusicPack.Common;
using Terraria.ID;

namespace EnderLiliesMusicPack.Content.MusicBoxs.MusicEvent
{
    public class MainThemeLiliesMusicBox : BaseMusicBox, ILocalizedModType
    {
        public override string MusicName => MusicPathing.MainThemeLilies;
        public override int MusicBoxTile => ModContent.TileType<MainThemeLiliesMusicBoxTile>();
        public override int LiliesOrLilac => (int)LiliesRarityID.liliesID;

        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient(ItemID.MusicBox).
                AddIngredient(ItemID.GemTreeDiamondSeed).
                Register();
        }
    }
}
