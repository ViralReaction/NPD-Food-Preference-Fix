using HarmonyLib;
using RimWorld;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection;
using System.Linq;
using System;
using Verse;

namespace NPD_FoodPreference
{
    public class ModStart : Mod
    {

        public ModStart(ModContentPack content) : base(content)
        {
            Harmony harmony = new Harmony(id: "NPD_FoodPreference");
            harmony.PatchAll();
        }
    }
}
