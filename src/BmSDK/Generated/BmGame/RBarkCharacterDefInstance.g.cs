#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkCharacterDefInstance<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBarkCharacterDefInstance : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBarkCharacterDefInstance", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBarkCharacterDefInstance() { }

    /// <summary>
    /// Constructs a new RBarkCharacterDefInstance
    /// </summary>
    public RBarkCharacterDefInstance(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBarkCharacterDefInstance Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBarkCharacterDefInstance(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: SourceBCD
    /// </summary>
    public unsafe BmSDK.BmGame.RBarkCharacterDef SourceBCD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkCharacterDef>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// IntProperty: RegisterCount
    /// </summary>
    public unsafe int RegisterCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: DynamicBarkSetList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkCharacterDefInstance.FDynamicSetContainer> DynamicBarkSetList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkCharacterDefInstance.FDynamicSetContainer>>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
}
