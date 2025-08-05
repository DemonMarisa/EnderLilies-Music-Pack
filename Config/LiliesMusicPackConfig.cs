using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.Localization;
using Terraria.ModLoader.Config;

namespace EnderLiliesMusicPack.Config
{
    [BackgroundColor(105, 105, 105, 216)]
    public class LiliesMusicPackConfig : ModConfig
    {
        public static LiliesMusicPackConfig Instance;
        public override ConfigScope Mode => ConfigScope.ClientSide;
        public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref NetworkText message) => true;

        [Header("Music")]
        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool MainThemeLilies { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool MainthemeMagnolia { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool ENDERLILIES { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool Bulbel { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool HeartsStayUnchanged { get; set; }


        [BackgroundColor(192, 54, 64, 192)]
        [Range(500, 10000)]
        [Increment(1)]
        [DefaultValue(5000)]
        public int ParticleLimit { get; set; }
    }
}
