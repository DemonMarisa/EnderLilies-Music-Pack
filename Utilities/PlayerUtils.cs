using EnderLiliesMusicPack.LiliesPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;

namespace EnderLiliesMusicPack.Utilities
{
    public static partial class NPCUtils
    {
        public static LiliesPlayerFlags LiliesPlayer(this Player player)
        {
            return player.GetModPlayer<LiliesPlayerFlags>();
        }
    }
}
