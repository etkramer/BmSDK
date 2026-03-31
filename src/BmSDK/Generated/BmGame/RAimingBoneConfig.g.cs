#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAimingBoneConfig<br/>
/// (size = 404)
/// (flags = 134217874)
/// </summary>
public partial class RAimingBoneConfig : BmSDK.BmGame.RConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAimingBoneConfig", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAimingBoneConfig() { }

    /// <summary>
    /// Constructs a new RAimingBoneConfig
    /// </summary>
    public RAimingBoneConfig(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAimingBoneConfig Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAimingBoneConfig(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAimingBoneConfig>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAimingBoneConfig>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAimingBoneConfig>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAimingBoneConfig>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAimingBoneConfig>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAimingBoneConfig>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAimingBoneConfig>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAimingBoneConfig>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// StructProperty: Spine
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues Spine
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 44);

    /// <summary>
    /// StructProperty: Spine1
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues Spine1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 80);

    /// <summary>
    /// StructProperty: Spine2
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues Spine2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 116);

    /// <summary>
    /// StructProperty: Spine3
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues Spine3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 152);

    /// <summary>
    /// StructProperty: Neck
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues Neck
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 188);

    /// <summary>
    /// StructProperty: Head
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues Head
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 224);

    /// <summary>
    /// StructProperty: LeftClavicle
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues LeftClavicle
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 260);

    /// <summary>
    /// StructProperty: LeftUpperArm
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues LeftUpperArm
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 296);

    /// <summary>
    /// StructProperty: RightClavicle
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues RightClavicle
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 332);

    /// <summary>
    /// StructProperty: RightUpperArm
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues RightUpperArm
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAimingBoneConfig.FAimingBoneValues>(Ptr + 368);

    /// <summary>
    /// Struct: FAimingBoneValues
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FAimingBoneValues
    {
        /// <summary>
        /// StructProperty: GroupProportion
        /// </summary>
        public unsafe ref System.Numerics.Vector3 GroupProportion
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>((IntPtr)thisPtr + 0); } }
        }

        /// <summary>
        /// StructProperty: PositiveLimit
        /// </summary>
        public unsafe ref System.Numerics.Vector3 PositiveLimit
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>((IntPtr)thisPtr + 12); } }
        }

        /// <summary>
        /// StructProperty: NegativeLimit
        /// </summary>
        public unsafe ref System.Numerics.Vector3 NegativeLimit
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>((IntPtr)thisPtr + 24); } }
        }
    }
}
