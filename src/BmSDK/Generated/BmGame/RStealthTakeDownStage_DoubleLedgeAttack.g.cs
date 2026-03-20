#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RStealthTakeDownStage_DoubleLedgeAttack<br/>
/// (flags = 0)
/// </summary>
public partial class RStealthTakeDownStage_DoubleLedgeAttack : BmSDK.BmGame.RStealthTakeDownStageDoubleBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RStealthTakeDownStage_DoubleLedgeAttack", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RStealthTakeDownStage_DoubleLedgeAttack() { }

    /// <summary>
    /// Constructs a new RStealthTakeDownStage_DoubleLedgeAttack
    /// </summary>
    public RStealthTakeDownStage_DoubleLedgeAttack(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RStealthTakeDownStage_DoubleLedgeAttack Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RStealthTakeDownStage_DoubleLedgeAttack(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_DoubleLedgeAttack>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_DoubleLedgeAttack>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_DoubleLedgeAttack>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_DoubleLedgeAttack>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_DoubleLedgeAttack>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_DoubleLedgeAttack>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_DoubleLedgeAttack>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ArrayProperty: RopeAttachPoint
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> RopeAttachPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// ArrayProperty: RopeRenderAttachPoint
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> RopeRenderAttachPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 1860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1860); }
    }

    /// <summary>
    /// ByteProperty: AttachRope
    /// </summary>
    public unsafe byte AttachRope_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1876); }
    }
    /// <summary>
    /// ByteProperty: AttachRope
    /// </summary>
    public unsafe byte AttachRope_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1877); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1877); }
    }

    /// <summary>
    /// FloatProperty: RopeLength
    /// </summary>
    public unsafe float RopeLength_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }
    }
    /// <summary>
    /// FloatProperty: RopeLength
    /// </summary>
    public unsafe float RopeLength_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1884); }
    }

    /// <summary>
    /// BoolProperty: DisableCutRope
    /// </summary>
    public unsafe bool DisableCutRope
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bAttachRopeToFeet
    /// </summary>
    public unsafe bool bAttachRopeToFeet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// NameProperty: RopeBoneAttachName
    /// </summary>
    public unsafe BmSDK.FName RopeBoneAttachName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1892); }
    }

    /// <summary>
    /// FloatProperty: RopeAttachConnectionDistance
    /// </summary>
    public unsafe float RopeAttachConnectionDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// StructProperty: RopePelvisAttachPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 RopePelvisAttachPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1904); }
    }

    /// <summary>
    /// ArrayProperty: RopeExtraAttachConnections
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RRopeComponent.FRopeExtraAttachConnection> RopeExtraAttachConnections
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRopeComponent.FRopeExtraAttachConnection>>(Ptr + 1916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1916); }
    }

    /// <summary>
    /// StructProperty: RopeRenderStartOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 RopeRenderStartOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1932); }
    }

    /// <summary>
    /// StructProperty: RopePhysStartOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 RopePhysStartOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1944); }
    }

    /// <summary>
    /// ArrayProperty: HangRope
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RStringUpRope> HangRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RStringUpRope>>(Ptr + 1956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1956); }
    }

    /// <summary>
    /// ArrayProperty: StageAnimNoRailingEx
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.FTakeDownStageAnimSet> StageAnimNoRailingEx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.FTakeDownStageAnimSet>>(Ptr + 1972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1972); }
    }
}
