#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpGroupInstAI<br/>
/// (size = 76)
/// (flags = 134217874)
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
    public unsafe BmSDK.Engine.InterpGroupAI AIGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.InterpGroupAI>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// ByteProperty: SavedPhysics
    /// </summary>
    public unsafe BmSDK.Engine.Actor.EPhysics SavedPhysics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.EPhysics>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: bSavedNoEncroachCheck
    /// </summary>
    public unsafe bool bSavedNoEncroachCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }
    }
}
