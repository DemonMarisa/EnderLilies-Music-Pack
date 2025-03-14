using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static EnderLiliesMusicPack.Scenes.MusicScenes.TownMusicScenes;

namespace EnderLiliesMusicPack.LiliesPlayer
{
    public class LiliesPlayerFlags : ModPlayer
    {
        public static bool onSurface;
        public static bool inSpace;

        public static bool inTown;
        public static bool inTownWithRain;
        public static bool inUgTown;

        public static bool isRaining;
        public static bool notRaining;
        public static bool largeWorld;
        public static bool mediumWorld;
        public static bool smallWorld;

        public static bool ugDesertOriginalHeight;
        public static bool ZoneSandstorm;
        public static bool ZoneOverworldHeightExtra;

        // mod适配
        public static bool infernumMode;
        public static bool ZoneBrimstoneCrags;
        public static bool ZoneAstralInfection;
        public static bool ZoneAbyss;
        public static bool ZoneSunkenSea;

        // 炼狱亵渎神庙
        public static bool ZoneProfanedTemple;

        public static float MusicTileRange = 525f * 16f;
        public override void PreUpdate()
        {
            var calamityMod = ModLoader.TryGetMod("CalamityMod", out Mod calamity);
            var infernumMod = ModLoader.TryGetMod("InfernumMode", out Mod infernum);
            var remnantsMod = ModLoader.TryGetMod("Remnants", out Mod remnants);
            var noTownMusic = ModLoader.TryGetMod("NoTownMusic", out Mod notownmusic);

            float spacef = remnantsMod ? 17f : 16f;
            float spaceh = (float)Main.maxTilesX / 4200f;
            spaceh *= spaceh;

            Player player = Main.player[Main.myPlayer];

            onSurface = player.position.Y < Main.worldSurface * 16.0 + (double)Main.screenHeight / 2;
            inSpace = (float)((double)((Main.screenPosition.Y + (float)(Main.screenHeight / 2)) / spacef - (65f + 10f * spaceh)) / (Main.worldSurface / 5.0)) < 1f;
            isRaining = Main.cloudAlpha > 0f;
            notRaining = Main.cloudAlpha <= 0.01f;
            largeWorld = Main.maxTilesY == 2400;
            mediumWorld = Main.maxTilesY == 1800;
            smallWorld = Main.maxTilesY == 1200;

            ugDesertOriginalHeight = (double)player.position.Y >= Main.worldSurface * 16.0 + (double)(Main.screenHeight / 2);

            if (noTownMusic)
            {
                inTown = false;
                inTownWithRain = false;
                inUgTown = false;
            }
            else
            {
                if (player.ZoneShadowCandle || player.inventory[player.selectedItem].type == ItemID.ShadowCandle)
                {
                    inTown = false;
                    inTownWithRain = false;
                    inUgTown = false;
                }
                else
                {
                    inTown = player.townNPCs > 2f && ((notRaining && player.ZoneOverworldHeight) || inSpace);
                    inTownWithRain = player.townNPCs > 2f && isRaining && ZoneOverworldHeightExtra;
                    inUgTown = player.townNPCs > 2f && (player.ZoneDirtLayerHeight || player.ZoneRockLayerHeight || player.ZoneUnderworldHeight);
                }
            }
            if (calamityMod)
            {
                ZoneBrimstoneCrags = (bool)calamity.Call("GetInZone", player, "crags");
                ZoneAstralInfection = (bool)calamity.Call("GetInZone", player, "astral");
                ZoneAbyss = (bool)calamity.Call("GetInZone", player, "abyss");
                ZoneSunkenSea = (bool)calamity.Call("GetInZone", player, "sunkensea");

            }

            if (infernumMod)
            {
                infernumMode = (bool)infernum.Call("GetInfernumActive");
                ZoneProfanedTemple = player.InModBiome(infernum.Find<ModBiome>("ProfanedTempleBiome"));
            }
        }
    }
}
