using HarmonyLib;
using SodaDen.Pacha;
using Random = UnityEngine.Random;

namespace CheatMod.Core.Patches;

public partial class CheatModPatches
{
    [HarmonyPatch(typeof(PlantEntity), "HarvestID")]
    [HarmonyPrefix]
    private static bool InfinitePlantHarvestPatch(PlantEntity __instance, ref string __result)
    {
        if (!CheatOptions.Instance.IsInfiniteHarvestEnabled.Value)
            return true;

        __result = $"{__instance.ID}-{__instance.CurrentDay}-${Random.Range(1, int.MaxValue)}";
        return false;
    }

    [HarmonyPatch(typeof(TreeEntity), "ShakeAndDropFruit")]
    [HarmonyPrefix]
    private static bool InfiniteTreeHarvestPatch(TreeEntity __instance)
    {
        if (!CheatOptions.Instance.IsInfiniteHarvestEnabled.Value)
            return true;

        // TODO: Reimplement infinite tree harvest
        // Problem: This new function does not return a value which is used, so the value cannot be patched 
        // Meaning either the IL code needs to be modified, or the function needs to be duplicated here, which 
        // will likely break with future updates
        
        return true;
    }
}