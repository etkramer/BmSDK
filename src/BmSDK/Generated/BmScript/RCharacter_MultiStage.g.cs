#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCharacter_MultiStage<br/>
/// (size = 392)
/// (flags = 0)
/// </summary>
public partial class RCharacter_MultiStage : BmSDK.BmGame.RCharacter_Thug, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCharacter_MultiStage", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_MultiStage() { }

    /// <summary>
    /// Constructs a new RCharacter_MultiStage
    /// </summary>
    public RCharacter_MultiStage(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacter_MultiStage Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_MultiStage(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: TypeSwitchName
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName TypeSwitchName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }
}
