
using EnderLiliesMusicPack.Core.ILEditingStuff.UIChange;
using Terraria;
using Terraria.ModLoader;

namespace EnderLiliesMusicPack.Core.ILEditingStuff
{
    public class HookManager : ModSystem
    {
        public override void Load()
        {
            On_Main.DrawThickCursor += CursorChange.DrawThickCursor;
            On_Main.DrawCursor += CursorChange.UseNewCursorEffect;
            On_Main.DrawInterface_36_Cursor += CursorChange.UseNewCursor;
        }

        public override void Unload()
        {
            On_Main.DrawThickCursor -= CursorChange.DrawThickCursor;
            On_Main.DrawCursor -= CursorChange.UseNewCursorEffect;
            On_Main.DrawInterface_36_Cursor -= CursorChange.UseNewCursor;
        }
    }
}
