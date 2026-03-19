#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqVar_ObjectVolume<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqVar_ObjectVolume : BmSDK.Engine.SeqVar_Object, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqVar_ObjectVolume", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqVar_ObjectVolume() { }

    /// <summary>
    /// Constructs a new SeqVar_ObjectVolume
    /// </summary>
    public SeqVar_ObjectVolume(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqVar_ObjectVolume Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqVar_ObjectVolume(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: LastUpdateTime
    /// </summary>
    public unsafe float LastUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// ArrayProperty: ContainedObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> ContainedObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// ArrayProperty: ExcludeClassList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> ExcludeClassList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// BoolProperty: bCollidingOnly
    /// </summary>
    public unsafe bool bCollidingOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 304); }
    }
}
