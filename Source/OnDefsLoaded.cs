using RimWorld;
using Verse;

namespace NoMoreFilth
{
    [StaticConstructorOnStartup] // This attribute calls the static constructor AFTER the defs are loaded.
    public class EGB_OnDefsLoaded
    {
        static EGB_OnDefsLoaded()
        {
            RemoveFilthFromAllTerrainDefs();
        }

        public static void RemoveFilthFromAllTerrainDefs()
        {
            foreach (TerrainDef terrainDef in DefDatabase<TerrainDef>.AllDefs)
                terrainDef.filthAcceptanceMask = FilthSourceFlags.None;
        }
    }
}
