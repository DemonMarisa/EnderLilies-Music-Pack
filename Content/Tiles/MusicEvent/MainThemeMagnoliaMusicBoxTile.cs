using EnderLiliesMusicPack.Content.MusicBoxs.MusicEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace EnderLiliesMusicPack.Content.Tiles.MusicEvent
{
    public class MainThemeMagnoliaMusicBoxTile : BaseMusicBoxTile
    {
        public override int musicBoxID => ModContent.ItemType<MainThemeMagnoliaMusicBox>();
    }
}
