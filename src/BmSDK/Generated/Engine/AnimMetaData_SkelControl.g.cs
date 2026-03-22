#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimMetaData_SkelControl<br/>
/// (size = 68)
/// (flags = 134230162)
/// </summary>
public partial class AnimMetaData_SkelControl : BmSDK.Engine.AnimMetaData, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimMetaData_SkelControl", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimMetaData_SkelControl() { }

    /// <summary>
    /// Constructs a new AnimMetaData_SkelControl
    /// </summary>
    public AnimMetaData_SkelControl(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimMetaData_SkelControl Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimMetaData_SkelControl(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: SkelControlNameList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> SkelControlNameList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// BoolProperty: bFullControlOverController
    /// </summary>
    public unsafe bool bFullControlOverController
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// NameProperty: SkelControlName
    /// </summary>
    public unsafe BmSDK.FName SkelControlName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }
}
