// Shoot Them Up Game. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class mShootThemUpTarget : TargetRules
{
	public mShootThemUpTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "mShootThemUp" } );
	}
}
