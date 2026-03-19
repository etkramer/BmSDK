#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimNotify_Script<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AnimNotify_Script : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimNotify_Script", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimNotify_Script() { }

    /// <summary>
    /// Constructs a new AnimNotify_Script
    /// </summary>
    public AnimNotify_Script(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimNotify_Script Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimNotify_Script(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: NotifyName
    /// </summary>
    public unsafe BmSDK.FName NotifyName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// NameProperty: NotifyTickName
    /// </summary>
    public unsafe BmSDK.FName NotifyTickName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// NameProperty: NotifyEndName
    /// </summary>
    public unsafe BmSDK.FName NotifyEndName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }
}
