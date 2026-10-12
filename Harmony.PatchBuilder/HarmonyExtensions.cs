#pragma warning disable
#nullable enable

namespace HarmonyLib.PatchBuilder;

internal static class HarmonyExtensions
{
    internal static HarmonyPatchBuilder<T> Patch<T>(this Harmony harmony)
        => new HarmonyPatchBuilder<T>(harmony);

    internal static HarmonyPatchBuilder Patch(this Harmony harmony)
        => new HarmonyPatchBuilder(harmony);
}
