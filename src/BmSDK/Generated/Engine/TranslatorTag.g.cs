#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: TranslatorTag<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class TranslatorTag : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.TranslatorTag", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal TranslatorTag() { }

    /// <summary>
    /// Constructs a new TranslatorTag
    /// </summary>
    public TranslatorTag(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, TranslatorTag Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected TranslatorTag(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: Tag
    /// </summary>
    public unsafe BmSDK.FName Tag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
