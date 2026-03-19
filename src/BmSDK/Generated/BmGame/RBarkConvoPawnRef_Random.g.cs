#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkConvoPawnRef_Random<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBarkConvoPawnRef_Random : BmSDK.BmGame.RBarkConvoPawnRef, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBarkConvoPawnRef_Random", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBarkConvoPawnRef_Random() { }

    /// <summary>
    /// Constructs a new RBarkConvoPawnRef_Random
    /// </summary>
    public RBarkConvoPawnRef_Random(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBarkConvoPawnRef_Random Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBarkConvoPawnRef_Random(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: Description
    /// </summary>
    public unsafe BmSDK.FString Description
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// FloatProperty: DrawRadius
    /// </summary>
    public unsafe float DrawRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: LockedSpeaker
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LockedSpeaker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ObjectProperty: LockedVoice
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LockedVoice
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// BoolProperty: bDependsOnPreviousAssignments
    /// </summary>
    public unsafe bool bDependsOnPreviousAssignments
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 152); }
    }
}
