#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: SequenceCondition<br/>
/// (size = 180)
/// (flags = 134217875)
/// </summary>
public partial class SequenceCondition : BmSDK.Engine.SequenceOp, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SequenceCondition", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SequenceCondition() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SequenceCondition(nint ptr) : base(ptr) { }

}
