#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAddContentCharacter<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAddContentCharacter : BmSDK.BmGame.RAdditionalContent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAddContentCharacter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAddContentCharacter() { }

    /// <summary>
    /// Constructs a new RAddContentCharacter
    /// </summary>
    public RAddContentCharacter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAddContentCharacter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAddContentCharacter(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: BoolTest
    /// </summary>
    public unsafe bool BoolTest
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 88); }
    }
}
