#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RFlaps_ConstraintSetupAnimBlend<br/>
/// (size = 144)
/// (flags = 134217874)
/// </summary>
public partial class RFlaps_ConstraintSetupAnimBlend : BmSDK.Engine.RFlaps_ConstraintSetup, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RFlaps_ConstraintSetupAnimBlend", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RFlaps_ConstraintSetupAnimBlend() { }

    /// <summary>
    /// Constructs a new RFlaps_ConstraintSetupAnimBlend
    /// </summary>
    public RFlaps_ConstraintSetupAnimBlend(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RFlaps_ConstraintSetupAnimBlend Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RFlaps_ConstraintSetupAnimBlend(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFlaps_ConstraintSetupAnimBlend>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFlaps_ConstraintSetupAnimBlend>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFlaps_ConstraintSetupAnimBlend>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFlaps_ConstraintSetupAnimBlend>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFlaps_ConstraintSetupAnimBlend>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFlaps_ConstraintSetupAnimBlend>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFlaps_ConstraintSetupAnimBlend>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFlaps_ConstraintSetupAnimBlend>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// StructProperty: ConstrainedParticle
    /// </summary>
    public unsafe BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference ConstrainedParticle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// FloatProperty: ConstraintRadius
    /// </summary>
    public unsafe float ConstraintRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// StructProperty: BlendDatas
    /// </summary>
    public unsafe BmSDK.Engine.RFlaps_ConstraintSetupAnimBlend.FRBlendBoneData BlendDatas_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RFlaps_ConstraintSetupAnimBlend.FRBlendBoneData>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }
    /// <summary>
    /// StructProperty: BlendDatas
    /// </summary>
    public unsafe BmSDK.Engine.RFlaps_ConstraintSetupAnimBlend.FRBlendBoneData BlendDatas_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RFlaps_ConstraintSetupAnimBlend.FRBlendBoneData>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
    /// <summary>
    /// StructProperty: BlendDatas
    /// </summary>
    public unsafe BmSDK.Engine.RFlaps_ConstraintSetupAnimBlend.FRBlendBoneData BlendDatas_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RFlaps_ConstraintSetupAnimBlend.FRBlendBoneData>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }
    /// <summary>
    /// StructProperty: BlendDatas
    /// </summary>
    public unsafe BmSDK.Engine.RFlaps_ConstraintSetupAnimBlend.FRBlendBoneData BlendDatas_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RFlaps_ConstraintSetupAnimBlend.FRBlendBoneData>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }
    /// <summary>
    /// StructProperty: BlendDatas
    /// </summary>
    public unsafe BmSDK.Engine.RFlaps_ConstraintSetupAnimBlend.FRBlendBoneData BlendDatas_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RFlaps_ConstraintSetupAnimBlend.FRBlendBoneData>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// Struct: FRBlendBoneData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FRBlendBoneData
    {
        /// <summary>
        /// NameProperty: ConstraintFrameBoneName
        /// </summary>
        public unsafe BmSDK.FName ConstraintFrameBoneName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: BlendWeight
        /// </summary>
        public unsafe float BlendWeight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

}
