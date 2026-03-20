#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: AkSDEntityGlobalFlagFromKismet<br/>
/// (size = 268)
/// (flags = 0)
/// </summary>
public partial class AkSDEntityGlobalFlagFromKismet : BmSDK.AkAudio.AkSDEntityValue, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.AkSDEntityGlobalFlagFromKismet", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkSDEntityGlobalFlagFromKismet() { }

    /// <summary>
    /// Constructs a new AkSDEntityGlobalFlagFromKismet
    /// </summary>
    public AkSDEntityGlobalFlagFromKismet(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkSDEntityGlobalFlagFromKismet Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkSDEntityGlobalFlagFromKismet(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: VariableName
    /// </summary>
    public unsafe BmSDK.FString VariableName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }
}
