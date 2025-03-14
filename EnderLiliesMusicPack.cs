using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace EnderLiliesMusicPack
{
    // Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
    public class EnderLiliesMusicPack : Mod
    {
        public static EnderLiliesMusicPack Instance;

        // »ñÈ¡ÔÖ¶òÒôÀÖ
        internal Mod CalmusicMod = null;
        // »ñÈ¡ÔÖ¶òÒôÀÖ
        internal Mod UnCalmusicMod = null;
        internal bool MusicAvailable => CalmusicMod is not null;
        internal bool UnMusicAvailable => UnCalmusicMod is not null;
        public override void Load()
        {
            Instance = this;

            // »ñÈ¡ÔÖ¶òÒôÀÖ
            CalmusicMod = null;
            ModLoader.TryGetMod("CalamityModMusic", out CalmusicMod);

            // »ñÈ¡ÔÖ¶ò¶îÍâÒôÀÖ
            UnCalmusicMod = null;
            ModLoader.TryGetMod("UnCalamityModMusic", out UnCalmusicMod);
        }
        public override void Unload()
        {
            // Ð¶ÔØÔÖ¶òÒôÀÖÓëÔÖ¶ò¶îÍâÒôÀÖ
            CalmusicMod = null;
            UnCalmusicMod = null;

            Instance = null;
            base.Unload();
        }
        // ´ÓÔÖ¶òÒôÀÖÖÐ»ñÈ¡ÒôÀÖ
        public int? GetMusicFromMusicMod(string songFilename) => MusicAvailable ? MusicLoader.GetMusicSlot(CalmusicMod, "Sounds/Music/" + songFilename) : null;
    }
}
