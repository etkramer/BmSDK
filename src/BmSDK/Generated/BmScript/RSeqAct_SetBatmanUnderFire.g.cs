#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_SetBatmanUnderFire<br/>
/// (size = 220)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_SetBatmanUnderFire : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_SetBatmanUnderFire", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetBatmanUnderFire() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetBatmanUnderFire
    /// </summary>
    public RSeqAct_SetBatmanUnderFire(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetBatmanUnderFire Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetBatmanUnderFire(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: Update
    /// </summary>
    public unsafe override bool Update(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_SetBatmanUnderFire.Update", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }
}
