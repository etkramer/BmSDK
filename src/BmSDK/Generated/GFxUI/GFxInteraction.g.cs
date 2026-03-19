#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.GFxUI;

/// <summary>
/// Class: GFxInteraction<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class GFxInteraction : BmSDK.Engine.Interaction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "GFxUI.GFxInteraction", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal GFxInteraction() { }

    /// <summary>
    /// Constructs a new GFxInteraction
    /// </summary>
    public GFxInteraction(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GFxInteraction Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GFxInteraction(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VfTable_FCallbackEventDevice
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VfTable_FCallbackEventDevice
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bFakeMobileTouches
    /// </summary>
    public unsafe bool bFakeMobileTouches
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }
}
