﻿using System.Diagnostics.CodeAnalysis;
using ModShardLauncher;
using ModShardLauncher.Mods;

namespace SpeedManager;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility")]
public class SpeedManager : Mod
{
    public override string Name => "SpeedManager";
    public override string Author => "Nylux";
    public override string Description => "Change the game's speed at will.";
    public override string Version => "1.1.1";

    public override void PatchMod()
    {
        Msl.InsertGMLString(ModFiles.GetCode("speedF3.gml"), "gml_Object_o_player_KeyPress_114", 0);
        Msl.InsertGMLString(ModFiles.GetCode("speedF4.gml"), "gml_Object_o_player_KeyPress_115", 0);
        Msl.InsertGMLString(ModFiles.GetCode("speedAlarm7.gml"), "gml_Object_o_player_Alarm_7", 0);
    }
}