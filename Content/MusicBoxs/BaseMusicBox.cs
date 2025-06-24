using EnderLiliesMusicPack.Common;
using EnderLiliesMusicPack.Content.Rarity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnderLiliesMusicPack.Content.MusicBoxs
{
    public abstract class BaseMusicBox : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "MusicBox";
        public abstract string MusicName { get; }
        public abstract int MusicBoxTile { get; }
        public abstract int LiliesOrLilac { get; }
        public override void ModifyResearchSorting(ref ContentSamples.CreativeHelper.ItemGroup itemGroup)
        {
            itemGroup = ContentSamples.CreativeHelper.ItemGroup.PlacableObjects;
        }
        public override void SetStaticDefaults()
        {
            ItemID.Sets.CanGetPrefixes[Type] = false;
            Item.ResearchUnlockCount = 1;
            if (!String.IsNullOrEmpty(MusicName) && MusicPathing.GetMusicSlot(MusicName) > 0)
            {
                MusicLoader.AddMusicBox(Mod, MusicPathing.GetMusicSlot(MusicName), Type, MusicBoxTile);
            }
        }
        public override void SetDefaults()
        {
            Item.DefaultToMusicBox(MusicBoxTile, 0);
            if (LiliesOrLilac == 0)
                Item.rare = ModContent.RarityType<WhiteWitchLilies>();
            else if (LiliesOrLilac == 1)
                Item.rare = ModContent.RarityType<WhiteWitchLilac>();
        }
    }
}
