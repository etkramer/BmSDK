#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSkelControl_FeedConstraint<br/>
/// (size = 332)
/// (flags = 142606482)
/// </summary>
public partial class RSkelControl_FeedConstraint : BmSDK.Engine.SkelControlBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSkelControl_FeedConstraint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RSkelControl_FeedConstraint.
    /// </summary>
    public static RSkelControl_FeedConstraint DefaultObject => (RSkelControl_FeedConstraint)StaticClass().DefaultObject;

    internal RSkelControl_FeedConstraint() { }

    /// <summary>
    /// Constructs a new RSkelControl_FeedConstraint
    /// </summary>
    public RSkelControl_FeedConstraint(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSkelControl_FeedConstraint Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSkelControl_FeedConstraint(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSkelControl_FeedConstraint>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSkelControl_FeedConstraint>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSkelControl_FeedConstraint>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSkelControl_FeedConstraint>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSkelControl_FeedConstraint>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSkelControl_FeedConstraint>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSkelControl_FeedConstraint>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSkelControl_FeedConstraint>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// NameProperty: SourceBoneName
    /// </summary>
    public unsafe BmSDK.FName SourceBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// ByteProperty: SourceType
    /// </summary>
    public unsafe BmSDK.BmGame.RSkelControl_FeedConstraint.ERotationOrTranslation SourceType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSkelControl_FeedConstraint.ERotationOrTranslation>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// ByteProperty: SourceAxis
    /// </summary>
    public unsafe BmSDK.GameObject.ESimpleAxis SourceAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.ESimpleAxis>(Ptr + 257); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 257); }
    }

    /// <summary>
    /// ByteProperty: DestinationType
    /// </summary>
    public unsafe BmSDK.BmGame.RSkelControl_FeedConstraint.ERotationOrTranslation DestinationType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSkelControl_FeedConstraint.ERotationOrTranslation>(Ptr + 258); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 258); }
    }

    /// <summary>
    /// ByteProperty: DestinationAxis
    /// </summary>
    public unsafe BmSDK.GameObject.ESimpleAxis DestinationAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.ESimpleAxis>(Ptr + 259); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 259); }
    }

    /// <summary>
    /// StructProperty: SourceRange
    /// </summary>
    public unsafe ref BmSDK.BmGame.RSkelControl_FeedConstraint.FFeedConstraintSourceRange SourceRange
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RSkelControl_FeedConstraint.FFeedConstraintSourceRange>(Ptr + 260);

    /// <summary>
    /// StructProperty: DestinationRange
    /// </summary>
    public unsafe ref BmSDK.BmGame.RSkelControl_FeedConstraint.FFeedConstraintDestinationRange DestinationRange
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RSkelControl_FeedConstraint.FFeedConstraintDestinationRange>(Ptr + 272);

    /// <summary>
    /// IntProperty: SourceBoneIndex
    /// </summary>
    public unsafe int SourceBoneIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// StructProperty: SourceBoneInverseReferencePose
    /// </summary>
    public unsafe ref BmSDK.GameObject.FBoneAtom SourceBoneInverseReferencePose
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FBoneAtom>(Ptr + 288);

    /// <summary>
    /// FloatProperty: SourceToDestinationScale
    /// </summary>
    public unsafe float SourceToDestinationScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// FloatProperty: SourceToDestinationBias
    /// </summary>
    public unsafe float SourceToDestinationBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// BoolProperty: Euler
    /// </summary>
    public unsafe bool Euler
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 328); }
    }

    /// <summary>
    /// Struct: FFeedConstraintDestinationRange
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FFeedConstraintDestinationRange
    {
        /// <summary>
        /// FloatProperty: Min
        /// </summary>
        public unsafe float Min
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Max
        /// </summary>
        public unsafe float Max
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FFeedConstraintSourceRange
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FFeedConstraintSourceRange
    {
        /// <summary>
        /// FloatProperty: Min
        /// </summary>
        public unsafe float Min
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Max
        /// </summary>
        public unsafe float Max
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: ClampToMin
        /// </summary>
        public unsafe bool ClampToMin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: ClampToMax
        /// </summary>
        public unsafe bool ClampToMax
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: ERotationOrTranslation
    /// </summary>
    public enum ERotationOrTranslation : byte
    {
        ROT_Rotation = 0,
        ROT_Translation = 1,
        ROT_MAX = 2,
    }
}
