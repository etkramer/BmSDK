#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MSeqAct_HackingUpdate<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MSeqAct_HackingUpdate : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MSeqAct_HackingUpdate", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MSeqAct_HackingUpdate() { }

    /// <summary>
    /// Constructs a new MSeqAct_HackingUpdate
    /// </summary>
    public MSeqAct_HackingUpdate(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MSeqAct_HackingUpdate Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MSeqAct_HackingUpdate(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: HackSubroutineType
    /// </summary>
    public unsafe byte HackSubroutineType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// StrProperty: SubroutineNewName
    /// </summary>
    public unsafe BmSDK.FString SubroutineNewName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// StrProperty: SubroutineNewDescription
    /// </summary>
    public unsafe BmSDK.FString SubroutineNewDescription
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// ObjectProperty: HackableObjectActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HackableObjectActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }
}
