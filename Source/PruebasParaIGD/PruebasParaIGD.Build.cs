// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PruebasParaIGD : ModuleRules
{
	public PruebasParaIGD(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"PruebasParaIGD",
			"PruebasParaIGD/Variant_Platforming",
			"PruebasParaIGD/Variant_Platforming/Animation",
			"PruebasParaIGD/Variant_Combat",
			"PruebasParaIGD/Variant_Combat/AI",
			"PruebasParaIGD/Variant_Combat/Animation",
			"PruebasParaIGD/Variant_Combat/Gameplay",
			"PruebasParaIGD/Variant_Combat/Interfaces",
			"PruebasParaIGD/Variant_Combat/UI",
			"PruebasParaIGD/Variant_SideScrolling",
			"PruebasParaIGD/Variant_SideScrolling/AI",
			"PruebasParaIGD/Variant_SideScrolling/Gameplay",
			"PruebasParaIGD/Variant_SideScrolling/Interfaces",
			"PruebasParaIGD/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
