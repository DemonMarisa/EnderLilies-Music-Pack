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
    
    public class ENDERLILIESMusicBox : BaseMusicBox, ILocalizedModType
    {
        public override string MusicName => MusicPathing.ENDERLILIES;
        public override int MusicBoxTile => ModContent.TileType<ENDERLILIESMusicBoxTile>();
        public override int LiliesOrLilac => (int)LiliesRarityID.liliesID;

        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient(ItemID.MusicBox).
                AddIngredient(ItemID.EnchantedSword).
                AddIngredient(ItemID.StoneBlock, 2).
                AddIngredient(ItemID.SoulofLight).
                AddIngredient(ItemID.SoulofNight).
                Register();
        }
    }
}
