// Shoot Them Up Game. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class mShootThemUpEditorTarget : TargetRules
{
	public mShootThemUpEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "mShootThemUp" } );
	}
}
