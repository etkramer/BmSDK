#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_AttachToActor<br/>
/// (size = 241)
/// (flags = 8210)
/// </summary>
public partial class SeqAct_AttachToActor : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_AttachToActor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_AttachToActor() { }

    /// <summary>
    /// Constructs a new SeqAct_AttachToActor
    /// </summary>
    public SeqAct_AttachToActor(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_AttachToActor Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_AttachToActor(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SeqAct_AttachToActor.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// BoolProperty: bDetach
    /// </summary>
    public unsafe bool bDetach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: bHardAttach
    /// </summary>
    public unsafe bool bHardAttach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: bUseRelativeOffset
    /// </summary>
    public unsafe bool bUseRelativeOffset
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: bUseRelativeRotation
    /// </summary>
    public unsafe bool bUseRelativeRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreBaseRotation
    /// </summary>
    public unsafe bool bIgnoreBaseRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: bUseTickGroup
    /// </summary>
    public unsafe bool bUseTickGroup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: bDropOnCombatSp
    /// </summary>
    public unsafe bool bDropOnCombatSp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: bAttemptToInheritLightEnvironment
    /// </summary>
    public unsafe bool bAttemptToInheritLightEnvironment
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }
    }

    /// <summary>
    /// NameProperty: BoneName
    /// </summary>
    public unsafe BmSDK.FName BoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// StructProperty: RelativeOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 RelativeOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// StructProperty: RelativeRotation
    /// </summary>
    public unsafe BmSDK.Rotator RelativeRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ByteProperty: TickGroup
    /// </summary>
    public unsafe BmSDK.GameObject.ETickingGroup TickGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.ETickingGroup>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }
}
