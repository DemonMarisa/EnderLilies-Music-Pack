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
    public class LiliesMusicPackBiomeConfig : ModConfig
    {
        public static LiliesMusicPackBiomeConfig Instance;
        public override void OnLoaded()
        {
            Instance = this;
        }

        public override ConfigScope Mode => ConfigScope.ClientSide;
        public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref NetworkText message) => true;

        [Header("Music")]
        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool Forest { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool Town { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool UnderGround { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool UnderWorld { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool Space { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool Snow { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool Desert { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool Jungle { get; set; }
        
        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool Ocean { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool MushroomFields { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool EvilBiome { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool Hallow { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool Dungeon { get; set; }

        [BackgroundColor(211, 211, 211, 192)]
        [DefaultValue(true)]
        public bool Aether { get; set; }
    }
}
