#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MorphTarget<br/>
/// (flags = 0)
/// </summary>
public partial class MorphTarget : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MorphTarget", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MorphTarget() { }

    /// <summary>
    /// Constructs a new MorphTarget
    /// </summary>
    public MorphTarget(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MorphTarget Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MorphTarget(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: MorphLODModels
    /// </summary>
    public unsafe BmSDK.TArray<int> MorphLODModels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// IntProperty: MaterialSlotId
    /// </summary>
    public unsafe int MaterialSlotId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// NameProperty: ScalarParameterName
    /// </summary>
    public unsafe BmSDK.FName ScalarParameterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }
}
