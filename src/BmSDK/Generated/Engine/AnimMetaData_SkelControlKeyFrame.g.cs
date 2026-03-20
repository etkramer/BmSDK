#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimMetaData_SkelControlKeyFrame<br/>
/// (size = 128)
/// (flags = 0)
/// </summary>
public partial class AnimMetaData_SkelControlKeyFrame : BmSDK.Engine.AnimMetaData_SkelControl, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimMetaData_SkelControlKeyFrame", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimMetaData_SkelControlKeyFrame() { }

    /// <summary>
    /// Constructs a new AnimMetaData_SkelControlKeyFrame
    /// </summary>
    public AnimMetaData_SkelControlKeyFrame(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimMetaData_SkelControlKeyFrame Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimMetaData_SkelControlKeyFrame(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: KeyFrames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSequence.FTimeModifier> KeyFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSequence.FTimeModifier>>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }
}
