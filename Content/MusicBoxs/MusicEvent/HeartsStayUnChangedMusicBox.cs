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
    public class HeartsStayUnChangedMusicBox : BaseMusicBox, ILocalizedModType
    {
        public override string MusicName => MusicPathing.HeartsStayUnchanged;
        public override int MusicBoxTile => ModContent.TileType<HeartsStayUnChangedMusicBoxTile>();
        public override int LiliesOrLilac => (int)LiliesRarityID.lilacID;


        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient(ItemID.MusicBox).
                AddIngredient(ItemID.Acorn).
                AddIngredient(ItemID.BlueBerries).
                AddIngredient(ItemID.LunarOre, 5).
                Register();
        }
    }
}
