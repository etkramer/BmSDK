#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkDialogueSpeech<br/>
/// (flags = 0)
/// </summary>
public partial class AkDialogueSpeech : BmSDK.Engine.AkHash, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkDialogueSpeech", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkDialogueSpeech() { }

    /// <summary>
    /// Constructs a new AkDialogueSpeech
    /// </summary>
    public AkDialogueSpeech(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkDialogueSpeech Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkDialogueSpeech(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VfTable_AkDialogueSpeech
    /// </summary>
    public unsafe System.IntPtr VfTable_AkDialogueSpeech
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
}
