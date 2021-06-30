// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class FPSUdemyServerTarget : TargetRules //Change this line according to the name of your project
{
    public FPSUdemyServerTarget(TargetInfo Target) : base(Target) //Change this line according to the name of your project
    {
        Type = TargetType.Server;
        DefaultBuildSettings = BuildSettingsVersion.V2;
        ExtraModuleNames.Add("FPSUdemy"); //Change this line according to the name of your project
    }
}
// Copyright Epic Games, Inc. All Rights Reserved.
/*
using UnrealBuildTool;
using System.Collections.Generic;

[SupportedPlatforms(UnrealPlatformClass.Server)]
public class FPSUdemyServerTarget : TargetRules
{
    public FPSUdemyServerTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Server;
        BuildEnvironment = TargetBuildEnvironment.Shared;
        ExtraModuleNames.Add("FPSUdemy");
    }
}*/
