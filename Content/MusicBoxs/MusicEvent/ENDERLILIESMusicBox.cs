using EnderLiliesMusicPack.Common;
using EnderLiliesMusicPack.Content.Rarity;
using EnderLiliesMusicPack.Content.Tiles.MusicEvent;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnderLiliesMusicPack.Content.MusicBoxs.MusicEvent
{
    
    public class ENDERLILIESMusicBox : BaseMusicBox, ILocalizedModType
    {
        public override string MusicName => MusicPathing.ENDERLILIES;
        public override int MusicBoxTile => ModContent.TileType<ENDERLILIESMusicBoxTile>();
        public override int LiliesOrLilac => (int)LiliesRarityID.liliesID;

        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient(ItemID.IronBroadsword).
                AddIngredient(ItemID.StoneBlock, 2).
                Register();
        }
    }
}
