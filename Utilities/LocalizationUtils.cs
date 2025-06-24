using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.Localization;

namespace EnderLiliesMusicPack.Utilities
{
    public static partial class LiliesUtils
    {
        public static LocalizedText GetText(string key)
        {
            return Language.GetOrRegister("Mods.EnderLiliesMusicPack." + key);
        }
        public static string GetTextValue(string key)
        {
            return Language.GetTextValue("Mods.EnderLiliesMusicPack." + key);
        }
    }
}
