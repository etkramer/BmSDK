#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_AutoJez<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_AutoJez : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_AutoJez", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_AutoJez() { }

    /// <summary>
    /// Constructs a new RSeqAct_AutoJez
    /// </summary>
    public RSeqAct_AutoJez(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_AutoJez Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_AutoJez(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: PMaps
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PMaps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ArrayProperty: AutoJezChapters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqAct_AutoJez.FAutoJezChapter> AutoJezChapters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqAct_AutoJez.FAutoJezChapter>>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// StrProperty: AutoJezLabel
    /// </summary>
    public unsafe BmSDK.FString AutoJezLabel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// StrProperty: AutoJezRoomLabel
    /// </summary>
    public unsafe BmSDK.FString AutoJezRoomLabel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// IntProperty: PMapIndex
    /// </summary>
    public unsafe int PMapIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// ArrayProperty: RoomsForPMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> RoomsForPMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// IntProperty: RoomIndex
    /// </summary>
    public unsafe int RoomIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// StructProperty: SpinLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 SpinLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// StructProperty: SpinRotation
    /// </summary>
    public unsafe BmSDK.Rotator SpinRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// IntProperty: CurrentStage
    /// </summary>
    public unsafe int CurrentStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }
}
