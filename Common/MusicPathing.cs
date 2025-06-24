using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace EnderLiliesMusicPack.Common
{
    public static class MusicPathing
    {
        public static Dictionary<string, int> musicPaths;
        public static string MainThemeLilies = "MainThemeLilies";
        public static string MainThemeMagnolia = "MainthemeMagnolia";
        public static void InitalizeMusicPaths(Mod mod)
        {
            musicPaths = new Dictionary<string, int>
            {
                //Alternates
                {"MainThemeLilies", MusicLoader.GetMusicSlot(mod, "Music/MainThemeLilies")},
                {"MainthemeMagnolia", MusicLoader.GetMusicSlot(mod, "Music/MainthemeMagnolia")},
            };
        }
        public static int GetMusicSlot(string key)
        {
            if (musicPaths.TryGetValue(key, out int slot))
            {
                return slot;
            }
            return -1;
        }
    }
}