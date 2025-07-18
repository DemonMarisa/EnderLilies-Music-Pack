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
        public static string MainThemeMagnolia = "MainThemeMagnolia";
        public static string ENDERLILIES = "ENDERLILIES";
        public static string Bulbel = "Bulbel";
        public static string TheSunOutro = "TheSunOutro";
        public static string HeartsStayUnchanged = "HeartsStayUnchanged";
        public static void InitalizeMusicPaths(Mod mod)
        {
            musicPaths = new Dictionary<string, int>
            {
                //Alternates
                {"MainThemeLilies", MusicLoader.GetMusicSlot(mod, "Music/MainThemeLilies")},
                {"MainThemeMagnolia", MusicLoader.GetMusicSlot(mod, "Music/MainThemeMagnolia")},
                {"ENDERLILIES", MusicLoader.GetMusicSlot(mod, "Music/ENDERLILIES")},
                {"Bulbel", MusicLoader.GetMusicSlot(mod, "Music/Bulbel")},
                {"HeartsStayUnchanged", MusicLoader.GetMusicSlot(mod, "Music/HeartsStayUnchanged")},
                #region 事件
                {"TheSunOutro", MusicLoader.GetMusicSlot(mod, "Music/Event/TheSunOutro")}
                #endregion
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