#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpGroupInstAI<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class InterpGroupInstAI : BmSDK.Engine.InterpGroupInst, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpGroupInstAI", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpGroupInstAI() { }

    /// <summary>
    /// Constructs a new InterpGroupInstAI
    /// </summary>
    public InterpGroupInstAI(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpGroupInstAI Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpGroupInstAI(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: AIGroup
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AIGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// ObjectProperty: PreviewPawn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PreviewPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ObjectProperty: StageMarkActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StageMarkActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// ByteProperty: SavedPhysics
    /// </summary>
    public unsafe byte SavedPhysics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// BoolProperty: bSavedNoEncroachCheck
    /// </summary>
    public unsafe bool bSavedNoEncroachCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 156); }
    }

    /// <summary>
    /// BoolProperty: bSavedCollideActors
    /// </summary>
    public unsafe bool bSavedCollideActors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 156); }
    }

    /// <summary>
    /// BoolProperty: bSavedBlockActors
    /// </summary>
    public unsafe bool bSavedBlockActors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 156); }
    }
}
