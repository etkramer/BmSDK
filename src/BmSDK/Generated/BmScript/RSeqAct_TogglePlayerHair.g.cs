#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_TogglePlayerHair<br/>
/// (size = 360)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_TogglePlayerHair : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_TogglePlayerHair", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_TogglePlayerHair() { }

    /// <summary>
    /// Constructs a new RSeqAct_TogglePlayerHair
    /// </summary>
    public RSeqAct_TogglePlayerHair(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_TogglePlayerHair Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_TogglePlayerHair(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_TogglePlayerHair.Activated", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: Mesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh Mesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
