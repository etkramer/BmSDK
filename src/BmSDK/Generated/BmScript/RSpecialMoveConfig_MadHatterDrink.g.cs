#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_MadHatterDrink<br/>
/// (size = 352)
/// (flags = 8392722)
/// </summary>
public partial class RSpecialMoveConfig_MadHatterDrink : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_MadHatterDrink", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_MadHatterDrink() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_MadHatterDrink
    /// </summary>
    public RSpecialMoveConfig_MadHatterDrink(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_MadHatterDrink Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_MadHatterDrink(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: injector
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent injector
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }
}
