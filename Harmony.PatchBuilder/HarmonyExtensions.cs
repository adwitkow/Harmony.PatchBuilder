using System;
using System.Collections.Generic;
using System.Text;

namespace HarmonyLib.PatchBuilder;

public static class HarmonyExtensions
{
    public static HarmonyPatchBuilder<T> Patch<T>(this Harmony harmony)
        => new HarmonyPatchBuilder<T>(harmony);

    public static HarmonyPatchBuilder Patch(this Harmony harmony)
        => new HarmonyPatchBuilder(harmony);
}
