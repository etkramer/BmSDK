#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SequenceFrameWrapped<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SequenceFrameWrapped : BmSDK.Engine.SequenceFrame, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SequenceFrameWrapped", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SequenceFrameWrapped() { }

    /// <summary>
    /// Constructs a new SequenceFrameWrapped
    /// </summary>
    public SequenceFrameWrapped(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SequenceFrameWrapped Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SequenceFrameWrapped(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: SizeX
    /// </summary>
    public unsafe int SizeX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// IntProperty: SizeY
    /// </summary>
    public unsafe int SizeY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// IntProperty: BorderWidth
    /// </summary>
    public unsafe int BorderWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// BoolProperty: bDrawBox
    /// </summary>
    public unsafe bool bDrawBox
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 236); }
    }

    /// <summary>
    /// BoolProperty: bFilled
    /// </summary>
    public unsafe bool bFilled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 236); }
    }

    /// <summary>
    /// BoolProperty: bTileFill
    /// </summary>
    public unsafe bool bTileFill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 236); }
    }

    /// <summary>
    /// StructProperty: BorderColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BorderColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// StructProperty: FillColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FillColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// ObjectProperty: FillTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FillTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// ObjectProperty: FillMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FillMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }
}
