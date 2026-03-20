#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPassThroughAdjustMovementDirectionInterface<br/>
/// (flags = 0)
/// </summary>
public partial class RPassThroughAdjustMovementDirectionInterface : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPassThroughAdjustMovementDirectionInterface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPassThroughAdjustMovementDirectionInterface() { }

    /// <summary>
    /// Constructs a new RPassThroughAdjustMovementDirectionInterface
    /// </summary>
    public RPassThroughAdjustMovementDirectionInterface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPassThroughAdjustMovementDirectionInterface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPassThroughAdjustMovementDirectionInterface(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: AdjustMovementDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 AdjustMovementDirection(System.Numerics.Vector3 MovementDir)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPassThroughAdjustMovementDirectionInterface.AdjustMovementDirection", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }
}
