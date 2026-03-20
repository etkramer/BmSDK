#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_ResetVoiceSynthesiserUseDetected<br/>
/// (size = 368)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_ResetVoiceSynthesiserUseDetected : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_ResetVoiceSynthesiserUseDetected", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_ResetVoiceSynthesiserUseDetected() { }

    /// <summary>
    /// Constructs a new RSeqAct_ResetVoiceSynthesiserUseDetected
    /// </summary>
    public RSeqAct_ResetVoiceSynthesiserUseDetected(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_ResetVoiceSynthesiserUseDetected Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_ResetVoiceSynthesiserUseDetected(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_ResetVoiceSynthesiserUseDetected.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_ResetVoiceSynthesiserUseDetected.Activated", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: ResetPredatorVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RPredatorVolume ResetPredatorVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPredatorVolume>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: Batman
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer Batman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }
}
