#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_SetDamageInstigator<br/>
/// (size = 360)
/// (flags = 0)
/// </summary>
public partial class SeqAct_SetDamageInstigator : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_SetDamageInstigator", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_SetDamageInstigator() { }

    /// <summary>
    /// Constructs a new SeqAct_SetDamageInstigator
    /// </summary>
    public SeqAct_SetDamageInstigator(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_SetDamageInstigator Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_SetDamageInstigator(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: DamageInstigator
    /// </summary>
    public unsafe BmSDK.Engine.Actor DamageInstigator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
