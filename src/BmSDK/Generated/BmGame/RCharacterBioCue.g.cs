#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCharacterBioCue<br/>
/// (flags = 0)
/// </summary>
public partial class RCharacterBioCue : BmSDK.BmGame.RConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCharacterBioCue", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacterBioCue() { }

    /// <summary>
    /// Constructs a new RCharacterBioCue
    /// </summary>
    public RCharacterBioCue(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCharacterBioCue Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacterBioCue(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Speech
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech Speech
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ClassProperty: WeaponType
    /// </summary>
    public unsafe BmSDK.Class WeaponType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// IntProperty: ForceRandomLine
    /// </summary>
    public unsafe int ForceRandomLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: Barksets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkSet> Barksets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkSet>>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ArrayProperty: AnimsetReferences
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> AnimsetReferences
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }
}
