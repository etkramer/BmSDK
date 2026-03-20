#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimNotify_PawnMaterialParam<br/>
/// (flags = 0)
/// </summary>
public partial class AnimNotify_PawnMaterialParam : BmSDK.Engine.AnimNotify_Scripted, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimNotify_PawnMaterialParam", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimNotify_PawnMaterialParam() { }

    /// <summary>
    /// Constructs a new AnimNotify_PawnMaterialParam
    /// </summary>
    public AnimNotify_PawnMaterialParam(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimNotify_PawnMaterialParam Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimNotify_PawnMaterialParam(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: ScalarParameterInterpArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Pawn.FScalarParameterInterpStruct> ScalarParameterInterpArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Pawn.FScalarParameterInterpStruct>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
