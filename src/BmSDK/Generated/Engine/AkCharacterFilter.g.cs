#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkCharacterFilter<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkCharacterFilter : BmSDK.Engine.AkHash, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkCharacterFilter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkCharacterFilter() { }

    /// <summary>
    /// Constructs a new AkCharacterFilter
    /// </summary>
    public AkCharacterFilter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkCharacterFilter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkCharacterFilter(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: CharacterValue
    /// </summary>
    public unsafe int CharacterValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// StrProperty: AnimViewerDisplayName
    /// </summary>
    public unsafe BmSDK.FString AnimViewerDisplayName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
}
