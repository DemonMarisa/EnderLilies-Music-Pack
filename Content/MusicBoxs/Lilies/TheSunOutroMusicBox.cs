using EnderLiliesMusicPack.Common;
using EnderLiliesMusicPack.Content.Rarity;
using EnderLiliesMusicPack.Content.Tiles.Lilies;
using EnderLiliesMusicPack.Content.Tiles.MusicEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace EnderLiliesMusicPack.Content.MusicBoxs.Lilies
{
    public class TheSunOutroMusicBox : BaseMusicBox, ILocalizedModType
    {
        public override string MusicName => MusicPathing.TheSunOutro;
        public override int MusicBoxTile => ModContent.TileType<TheSunOutroTile>();
        public override int LiliesOrLilac => (int)LiliesRarityID.liliesID;
    }
}
