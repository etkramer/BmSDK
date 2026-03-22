#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_InterpolateColour<br/>
/// (size = 276)
/// (flags = 134226066)
/// </summary>
public partial class SeqAct_InterpolateColour : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_InterpolateColour", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_InterpolateColour() { }

    /// <summary>
    /// Constructs a new SeqAct_InterpolateColour
    /// </summary>
    public SeqAct_InterpolateColour(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_InterpolateColour Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_InterpolateColour(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SeqAct_InterpolateColour.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// FloatProperty: Duration
    /// </summary>
    public unsafe float Duration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ArrayProperty: MatInst
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> MatInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// NameProperty: ParamName
    /// </summary>
    public unsafe BmSDK.FName ParamName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// StructProperty: TargetColour
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor TargetColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// FloatProperty: RemainingTime
    /// </summary>
    public unsafe float RemainingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ArrayProperty: DeltaColour
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FLinearColor> DeltaColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FLinearColor>>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }
}
