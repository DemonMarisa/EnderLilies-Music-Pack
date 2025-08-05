using EnderLiliesMusicPack.Common;
using EnderLiliesMusicPack.Content.Rarity;
using EnderLiliesMusicPack.Content.Tiles.MusicEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnderLiliesMusicPack.Content.MusicBoxs.MusicEvent
{
    public  class BulbelMusicBox : BaseMusicBox, ILocalizedModType
    {
        public override string MusicName => MusicPathing.Bulbel;
        public override int MusicBoxTile => ModContent.TileType<BulbelMusicBoxTile>();
        public override int LiliesOrLilac => (int)LiliesRarityID.liliesID;

        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient(ItemID.MusicBox).
                AddIngredient(ItemID.StoneBlock, 5).
                AddIngredient(ItemID.Wood, 5).
                AddIngredient(ItemID.LunarOre, 5).
                Register();
        }
    }
}
