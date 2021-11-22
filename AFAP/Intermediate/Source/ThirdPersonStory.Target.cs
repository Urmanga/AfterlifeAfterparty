using UnrealBuildTool;

public class ThirdPersonStoryTarget : TargetRules
{
	public ThirdPersonStoryTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ThirdPersonStory");
	}
}
