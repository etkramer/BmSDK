#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_UpdateGrundy<br/>
/// (size = 220)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_UpdateGrundy : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_UpdateGrundy", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_UpdateGrundy() { }

    /// <summary>
    /// Constructs a new RSeqAct_UpdateGrundy
    /// </summary>
    public RSeqAct_UpdateGrundy(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_UpdateGrundy Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_UpdateGrundy(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_UpdateGrundy.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PreparePenguinForRocketReveal
    /// </summary>
    public unsafe virtual void PreparePenguinForRocketReveal()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_UpdateGrundy.PreparePenguinForRocketReveal", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe override void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_UpdateGrundy.Activated", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: Grundy
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnBossGrundyBase Grundy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossGrundyBase>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ObjectProperty: Penguin
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnBossPenguinBase Penguin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossPenguinBase>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// ObjectProperty: WaterPoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor WaterPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// ObjectProperty: PenguinStart
    /// </summary>
    public unsafe BmSDK.Engine.Actor PenguinStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }
}
