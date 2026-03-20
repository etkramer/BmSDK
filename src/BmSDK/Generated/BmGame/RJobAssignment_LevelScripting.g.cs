#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RJobAssignment_LevelScripting<br/>
/// (flags = 0)
/// </summary>
public partial class RJobAssignment_LevelScripting : BmSDK.BmGame.RJobAssignment, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RJobAssignment_LevelScripting", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RJobAssignment_LevelScripting() { }

    /// <summary>
    /// Constructs a new RJobAssignment_LevelScripting
    /// </summary>
    public RJobAssignment_LevelScripting(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RJobAssignment_LevelScripting Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RJobAssignment_LevelScripting(nint ptr) : base(ptr) { }

    /// <summary>
    /// ClassProperty: TemplateOwnerClass
    /// </summary>
    public unsafe BmSDK.Class TemplateOwnerClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// NameProperty: TemplateName
    /// </summary>
    public unsafe BmSDK.FName TemplateName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
}
