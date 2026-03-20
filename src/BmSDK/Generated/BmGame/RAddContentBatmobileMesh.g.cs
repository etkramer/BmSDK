#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAddContentBatmobileMesh<br/>
/// (flags = 0)
/// </summary>
public partial class RAddContentBatmobileMesh : BmSDK.BmGame.RAdditionalContent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAddContentBatmobileMesh", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAddContentBatmobileMesh() { }

    /// <summary>
    /// Constructs a new RAddContentBatmobileMesh
    /// </summary>
    public RAddContentBatmobileMesh(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAddContentBatmobileMesh Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAddContentBatmobileMesh(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: MaterialOverrides
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAddContentBatmobileMesh.FBatmobileMaterialOverride> MaterialOverrides
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAddContentBatmobileMesh.FBatmobileMaterialOverride>>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// StructProperty: DamageChapter
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor DamageChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// FloatProperty: DamageScratchesAllOver
    /// </summary>
    public unsafe float DamageScratchesAllOver
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// FloatProperty: VectorDisplacementMultiplier
    /// </summary>
    public unsafe float VectorDisplacementMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// StructProperty: DamageColour
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor DamageColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// NameProperty: DamageChapterName
    /// </summary>
    public unsafe BmSDK.FName DamageChapterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// NameProperty: DamageScratchesAllOverName
    /// </summary>
    public unsafe BmSDK.FName DamageScratchesAllOverName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// NameProperty: VectorDisplacementMultiplierName
    /// </summary>
    public unsafe BmSDK.FName VectorDisplacementMultiplierName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// NameProperty: DamageColourName
    /// </summary>
    public unsafe BmSDK.FName DamageColourName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// Struct: FBatmobileMaterialOverride
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FBatmobileMaterialOverride
    {
        /// <summary>
        /// IntProperty: MaterialIndex
        /// </summary>
        public unsafe int MaterialIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: Material
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInterface Material
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }
}
