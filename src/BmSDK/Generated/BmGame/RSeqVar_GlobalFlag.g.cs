#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqVar_GlobalFlag<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqVar_GlobalFlag : BmSDK.Engine.SeqVar_Bool, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqVar_GlobalFlag", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqVar_GlobalFlag() { }

    /// <summary>
    /// Constructs a new RSeqVar_GlobalFlag
    /// </summary>
    public RSeqVar_GlobalFlag(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqVar_GlobalFlag Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqVar_GlobalFlag(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: FlagName
    /// </summary>
    public unsafe BmSDK.FName FlagName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// StrProperty: FlagNameAsString
    /// </summary>
    public unsafe BmSDK.FString FlagNameAsString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }
}
