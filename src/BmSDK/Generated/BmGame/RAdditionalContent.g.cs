#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RAdditionalContent<br/>
/// (size = 48)
/// (flags = 134217875)
/// </summary>
public partial class RAdditionalContent : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAdditionalContent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAdditionalContent() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAdditionalContent(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: TestID
    /// </summary>
    public unsafe int TestID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }
}
