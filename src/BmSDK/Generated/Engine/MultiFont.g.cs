#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MultiFont<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MultiFont : BmSDK.Engine.Font, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MultiFont", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MultiFont() { }

    /// <summary>
    /// Constructs a new MultiFont
    /// </summary>
    public MultiFont(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MultiFont Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MultiFont(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: ResolutionTestTable
    /// </summary>
    public unsafe BmSDK.TArray<float> ResolutionTestTable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }
}
