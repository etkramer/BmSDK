using BmSDK;
using BmSDK.Framework;

namespace BmSDK.Engine;

public class ActorComponent : Core.Component
{
	public int Scene => (int)GetPropertyValue(0, "UStructProperty");
	public Engine.Actor Owner => (Engine.Actor)GetPropertyValue(4, "UObjectProperty");
	public bool bAttached => GetBoolPropertyValue(8, 1);
	public bool bTickInEditor => GetBoolPropertyValue(8, 2);
	public bool bNeedsReattach => GetBoolPropertyValue(8, 3);
	public bool bNeedsUpdateTransform => GetBoolPropertyValue(8, 4);
	public bool bDisableTick => GetBoolPropertyValue(8, 5);
	public bool bEnableUpdateChildComponents => GetBoolPropertyValue(8, 6);
	public ETickingGroup TickGroup => (ETickingGroup)GetPropertyValue(12, "UByteProperty");
}
