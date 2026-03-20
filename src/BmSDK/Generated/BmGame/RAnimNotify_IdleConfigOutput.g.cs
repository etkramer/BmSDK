#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_IdleConfigOutput<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAnimNotify_IdleConfigOutput : BmSDK.Engine.AnimNotify_Script, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_IdleConfigOutput", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_IdleConfigOutput() { }

    /// <summary>
    /// Constructs a new RAnimNotify_IdleConfigOutput
    /// </summary>
    public RAnimNotify_IdleConfigOutput(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_IdleConfigOutput Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_IdleConfigOutput(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Gid
    /// </summary>
    public unsafe BmSDK.GameObject.FGuid Gid
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FGuid>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// NameProperty: KismetOutputName
    /// </summary>
    public unsafe BmSDK.FName KismetOutputName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }
}
