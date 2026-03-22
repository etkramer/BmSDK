#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_DestroyAllAIPawns<br/>
/// (size = 208)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_DestroyAllAIPawns : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_DestroyAllAIPawns", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_DestroyAllAIPawns() { }

    /// <summary>
    /// Constructs a new RSeqAct_DestroyAllAIPawns
    /// </summary>
    public RSeqAct_DestroyAllAIPawns(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_DestroyAllAIPawns Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_DestroyAllAIPawns(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe override void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_DestroyAllAIPawns.Activated", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ClassProperty: DestroyType
    /// </summary>
    public unsafe BmSDK.Class DestroyType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }
}
