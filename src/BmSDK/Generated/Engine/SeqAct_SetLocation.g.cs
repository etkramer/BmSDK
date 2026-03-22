#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_SetLocation<br/>
/// (size = 236)
/// (flags = 134226066)
/// </summary>
public partial class SeqAct_SetLocation : BmSDK.Engine.SeqAct_SetSequenceVariable, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_SetLocation", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_SetLocation() { }

    /// <summary>
    /// Constructs a new SeqAct_SetLocation
    /// </summary>
    public SeqAct_SetLocation(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_SetLocation Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_SetLocation(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SeqAct_SetLocation.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// BoolProperty: bSetLocation
    /// </summary>
    public unsafe bool bSetLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }
    }

    /// <summary>
    /// BoolProperty: bSetRotation
    /// </summary>
    public unsafe bool bSetRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }
    }

    /// <summary>
    /// StructProperty: LocationValue
    /// </summary>
    public unsafe System.Numerics.Vector3 LocationValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// StructProperty: RotationValue
    /// </summary>
    public unsafe BmSDK.Rotator RotationValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ObjectProperty: Target
    /// </summary>
    public unsafe BmSDK.GameObject Target
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }
}
