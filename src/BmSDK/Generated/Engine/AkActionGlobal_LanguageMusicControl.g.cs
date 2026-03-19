#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkActionGlobal_LanguageMusicControl<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkActionGlobal_LanguageMusicControl : BmSDK.Engine.AkActionGlobal_GenericMusicControl, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkActionGlobal_LanguageMusicControl", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkActionGlobal_LanguageMusicControl() { }

    /// <summary>
    /// Constructs a new AkActionGlobal_LanguageMusicControl
    /// </summary>
    public AkActionGlobal_LanguageMusicControl(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkActionGlobal_LanguageMusicControl Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkActionGlobal_LanguageMusicControl(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: LanguageStates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> LanguageStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }
}
