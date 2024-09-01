// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ActionPluginEditor : ModuleRules
{
	public ActionPluginEditor(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(new string[] {
			// ... add public include paths required here ...
		});
				
		
		PrivateIncludePaths.AddRange(new string[] {
			// ... add other private include paths required here ...
		});
			
		
		PublicDependencyModuleNames.AddRange(new string[] {
			"AnimationCore",
			//"AnimationWarpingRuntime",
			"ActionPluginRuntime",
            "AnimGraph",
			"AnimGraphRuntime",
			"AnimationModifiers",
			"AnimationBlueprintLibrary",
			//"AnimationModifierLibrary",
			"Core",
            "CoreUObject",
            "Engine",
        });

		PrivateDependencyModuleNames.AddRange(new string[] {
            "SlateCore",
        });

        if (Target.bBuildEditor == true)
        {
            PrivateDependencyModuleNames.AddRange(
                new string[]
                {
					"BlueprintGraph",
					"EditorFramework",
					"Kismet",
                    "UnrealEd",
                }
            );
        }
	
		DynamicallyLoadedModuleNames.AddRange(new string[] {
			// ... add any modules that your module loads dynamically here ...
		});
	}
}
