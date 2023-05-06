using TinyLife.Actions;
using HarmonyLib;
using System.Reflection;

namespace NoTrespassingMod;

[HarmonyPatch]
public static class Patch_LockDoorAction
{
    public static MethodBase TargetMethod()
    {
        var type = AccessTools.TypeByName("TinyLife.Actions.LockDoorAction");
        return AccessTools.Method(type, "AndThenInitialize");
    }

    public static void Prefix(MultiAction __instance)
    {
        var person = __instance.Info.Person;
        NoTrespassingMod.Logger.Info($"LockDoorAction.AndThenInitialize accessed by {person.FirstName}");
    }
}
