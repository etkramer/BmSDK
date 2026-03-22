#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_PrepareMapChange<br/>
/// (size = 244)
/// (flags = 134226066)
/// </summary>
public partial class SeqAct_PrepareMapChange : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_PrepareMapChange", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_PrepareMapChange() { }

    /// <summary>
    /// Constructs a new SeqAct_PrepareMapChange
    /// </summary>
    public SeqAct_PrepareMapChange(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_PrepareMapChange Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_PrepareMapChange(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: MainLevelName
    /// </summary>
    public unsafe BmSDK.FName MainLevelName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ArrayProperty: InitiallyLoadedSecondaryLevelNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> InitiallyLoadedSecondaryLevelNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// BoolProperty: bIsHighPriority
    /// </summary>
    public unsafe bool bIsHighPriority
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: bStatusIsOk
    /// </summary>
    public unsafe bool bStatusIsOk
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }
}
