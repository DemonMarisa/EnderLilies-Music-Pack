using EnderLiliesMusicPack.Common;
using EnderLiliesMusicPack.Content.Rarity;
using EnderLiliesMusicPack.Content.Tiles.MusicEvent;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnderLiliesMusicPack.Content.MusicBoxs.MusicEvent
{
    public class MainThemeMagnoliaMusicBox : BaseMusicBox, ILocalizedModType
    {
        public override string MusicName => MusicPathing.MainThemeMagnolia;
        public override int MusicBoxTile => ModContent.TileType<MainThemeMagnoliaMusicBoxTile>();
        public override int LiliesOrLilac => (int)LiliesRarityID.lilacID;

        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient(ItemID.MusicBox).
                AddIngredient(ItemID.SkyBlueFlower).
                Register();
        }
    }
}
