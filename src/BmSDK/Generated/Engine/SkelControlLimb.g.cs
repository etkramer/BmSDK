#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SkelControlLimb<br/>
/// (size = 336)
/// (flags = 142606482)
/// </summary>
public partial class SkelControlLimb : BmSDK.Engine.SkelControlBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SkelControlLimb", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as SkelControlLimb.
    /// </summary>
    public static SkelControlLimb DefaultObject => (SkelControlLimb)StaticClass().DefaultObject;

    internal SkelControlLimb() { }

    /// <summary>
    /// Constructs a new SkelControlLimb
    /// </summary>
    public SkelControlLimb(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SkelControlLimb Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SkelControlLimb(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SkelControlLimb>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SkelControlLimb>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SkelControlLimb>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SkelControlLimb>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SkelControlLimb>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SkelControlLimb>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SkelControlLimb>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SkelControlLimb>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// StructProperty: EffectorLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EffectorLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 248);

    /// <summary>
    /// ByteProperty: EffectorLocationSpace
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlBase.EBoneControlSpace EffectorLocationSpace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlBase.EBoneControlSpace>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ByteProperty: JointTargetLocationSpace
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlBase.EBoneControlSpace JointTargetLocationSpace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlBase.EBoneControlSpace>(Ptr + 261); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 261); }
    }

    /// <summary>
    /// ByteProperty: JointOffsetSpace
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlBase.EBoneControlSpace JointOffsetSpace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlBase.EBoneControlSpace>(Ptr + 262); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 262); }
    }

    /// <summary>
    /// ByteProperty: BoneAxis
    /// </summary>
    public unsafe BmSDK.GameObject.EAxis BoneAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.EAxis>(Ptr + 263); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 263); }
    }

    /// <summary>
    /// ByteProperty: JointAxis
    /// </summary>
    public unsafe BmSDK.GameObject.EAxis JointAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.EAxis>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// NameProperty: EffectorSpaceBoneName
    /// </summary>
    public unsafe BmSDK.FName EffectorSpaceBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// StructProperty: JointTargetLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 JointTargetLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 276);

    /// <summary>
    /// NameProperty: JointTargetSpaceBoneName
    /// </summary>
    public unsafe BmSDK.FName JointTargetSpaceBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// StructProperty: JointOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 JointOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 296);

    /// <summary>
    /// NameProperty: JointOffsetBoneName
    /// </summary>
    public unsafe BmSDK.FName JointOffsetBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// BoolProperty: bInvertBoneAxis
    /// </summary>
    public unsafe bool bInvertBoneAxis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 316); }
    }

    /// <summary>
    /// BoolProperty: bInvertJointAxis
    /// </summary>
    public unsafe bool bInvertJointAxis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 316); }
    }

    /// <summary>
    /// BoolProperty: bRotateJoint
    /// </summary>
    public unsafe bool bRotateJoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 316); }
    }

    /// <summary>
    /// BoolProperty: bMaintainEffectorRelRot
    /// </summary>
    public unsafe bool bMaintainEffectorRelRot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 316); }
    }

    /// <summary>
    /// BoolProperty: bTakeRotationFromEffectorSpace
    /// </summary>
    public unsafe bool bTakeRotationFromEffectorSpace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 316); }
    }

    /// <summary>
    /// BoolProperty: bAllowStretching
    /// </summary>
    public unsafe bool bAllowStretching
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 316); }
    }

    /// <summary>
    /// StructProperty: StretchLimits
    /// </summary>
    public unsafe ref System.Numerics.Vector2 StretchLimits
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector2>(Ptr + 320);

    /// <summary>
    /// NameProperty: StretchRollBoneName
    /// </summary>
    public unsafe BmSDK.FName StretchRollBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }
}
