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
    public class LiliesMusicPackBossConfig : ModConfig
    {
        public static LiliesMusicPackBossConfig Instance;
        public override void OnLoaded()
        {
            Instance = this;
        }

        public override ConfigScope Mode => ConfigScope.ClientSide;
        public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref NetworkText message) => true;

        [Header("Music")]
        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool MoonLordMother { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool LunaticCultist { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool DukeFish { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool EOL { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool Golem { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool Plantera { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool SkeletronPrime { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool TheDestroyer { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool TheTwins { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool QueenSlimeBoss { get; set; }

        [Header("PreHardMode")]
        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool WOF { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool Deerclops { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool Skeletron { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool QueenBee { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool BOC { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool EOC { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool EyeOC { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool KingSlime { get; set; }
    }
}
