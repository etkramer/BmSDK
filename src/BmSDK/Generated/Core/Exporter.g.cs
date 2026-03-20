#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: Exporter<br/>
/// (flags = 0)
/// </summary>
public partial class Exporter : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.Exporter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Exporter() { }

    /// <summary>
    /// Constructs a new Exporter
    /// </summary>
    public Exporter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Exporter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Exporter(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: FormatDescription
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> FormatDescription
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ArrayProperty: FormatExtension
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> FormatExtension
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
}
