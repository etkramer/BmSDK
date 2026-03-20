#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: TranslationContext<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class TranslationContext : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.TranslationContext", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal TranslationContext() { }

    /// <summary>
    /// Constructs a new TranslationContext
    /// </summary>
    public TranslationContext(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, TranslationContext Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected TranslationContext(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: TranslatorTags
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.TranslatorTag> TranslatorTags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.TranslatorTag>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
}
