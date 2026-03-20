#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MHackableObjectBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MHackableObjectBase : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MHackableObjectBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MHackableObjectBase() { }

    /// <summary>
    /// Constructs a new MHackableObjectBase
    /// </summary>
    public MHackableObjectBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MHackableObjectBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MHackableObjectBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MHackableObjectBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHackableObjectBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MHackableObjectBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHackableObjectBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHackableObjectBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MHackableObjectBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MHackableObjectBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ComponentProperty: StaticMeshComponent
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent StaticMeshComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: HackingViewMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface HackingViewMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: DetectiveModeMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface DetectiveModeMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ObjectProperty: DisableStateStaticMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMesh DisableStateStaticMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMesh>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: CurrentSubroutine
    /// </summary>
    public unsafe BmSDK.BmGame.MHackSubroutine CurrentSubroutine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackSubroutine>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: PreviewSubroutine
    /// </summary>
    public unsafe BmSDK.BmGame.MHackSubroutine PreviewSubroutine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackSubroutine>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: HighlightMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstance HighlightMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ObjectProperty: HighlightMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant HighlightMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ObjectProperty: EnableStateStaticMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMesh EnableStateStaticMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMesh>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ComponentProperty: HighlightStaticMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent HighlightStaticMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ComponentProperty: XRayMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent XRayMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ComponentProperty: DLCXtraMaskMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent DLCXtraMaskMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ComponentProperty: Interactions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent Interactions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ArrayProperty: SupportedSubroutines
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.MHackableInterface.FSubroutineDefinition> SupportedSubroutines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.MHackableInterface.FSubroutineDefinition>>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// StructProperty: TargetPositionOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 TargetPositionOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// InterfaceProperty: NotifyObjectOnHack
    /// </summary>
    public unsafe BmSDK.BmGame.MHackableInterface NotifyObjectOnHack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackableInterface>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// IntProperty: EnableAfterHackCount
    /// </summary>
    public unsafe int EnableAfterHackCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// ByteProperty: CurrentHighlightType
    /// </summary>
    public unsafe BmSDK.BmGame.MHackableInterface.EHackableObjectState CurrentHighlightType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MHackableInterface.EHackableObjectState>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ByteProperty: SubroutinesTypeDisabled
    /// </summary>
    public unsafe byte SubroutinesTypeDisabled_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 821); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 821); }
    }
    /// <summary>
    /// ByteProperty: SubroutinesTypeDisabled
    /// </summary>
    public unsafe byte SubroutinesTypeDisabled_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 822); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 822); }
    }
    /// <summary>
    /// ByteProperty: SubroutinesTypeDisabled
    /// </summary>
    public unsafe byte SubroutinesTypeDisabled_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 823); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 823); }
    }
    /// <summary>
    /// ByteProperty: SubroutinesTypeDisabled
    /// </summary>
    public unsafe byte SubroutinesTypeDisabled_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }
    /// <summary>
    /// ByteProperty: SubroutinesTypeDisabled
    /// </summary>
    public unsafe byte SubroutinesTypeDisabled_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 825); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 825); }
    }
    /// <summary>
    /// ByteProperty: SubroutinesTypeDisabled
    /// </summary>
    public unsafe byte SubroutinesTypeDisabled_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 826); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 826); }
    }
    /// <summary>
    /// ByteProperty: SubroutinesTypeDisabled
    /// </summary>
    public unsafe byte SubroutinesTypeDisabled_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 827); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 827); }
    }
    /// <summary>
    /// ByteProperty: SubroutinesTypeDisabled
    /// </summary>
    public unsafe byte SubroutinesTypeDisabled_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// IntProperty: RoomHackedCount
    /// </summary>
    public unsafe int RoomHackedCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// BoolProperty: bEnabled
    /// </summary>
    public unsafe bool bEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 836); }
    }

    /// <summary>
    /// BoolProperty: bHacked
    /// </summary>
    public unsafe bool bHacked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 836); }
    }

    /// <summary>
    /// BoolProperty: bUsingEnableStateMesh
    /// </summary>
    public unsafe bool bUsingEnableStateMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 836); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 836); }
    }

    /// <summary>
    /// StrProperty: SubroutinesNameModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesNameModifiedByKismet_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }
    /// <summary>
    /// StrProperty: SubroutinesNameModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesNameModifiedByKismet_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }
    /// <summary>
    /// StrProperty: SubroutinesNameModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesNameModifiedByKismet_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }
    /// <summary>
    /// StrProperty: SubroutinesNameModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesNameModifiedByKismet_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }
    /// <summary>
    /// StrProperty: SubroutinesNameModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesNameModifiedByKismet_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }
    /// <summary>
    /// StrProperty: SubroutinesNameModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesNameModifiedByKismet_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }
    /// <summary>
    /// StrProperty: SubroutinesNameModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesNameModifiedByKismet_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }
    /// <summary>
    /// StrProperty: SubroutinesNameModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesNameModifiedByKismet_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// StrProperty: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesDescriptionModifiedByKismet_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }
    /// <summary>
    /// StrProperty: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesDescriptionModifiedByKismet_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }
    /// <summary>
    /// StrProperty: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesDescriptionModifiedByKismet_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }
    /// <summary>
    /// StrProperty: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesDescriptionModifiedByKismet_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }
    /// <summary>
    /// StrProperty: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesDescriptionModifiedByKismet_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }
    /// <summary>
    /// StrProperty: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesDescriptionModifiedByKismet_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }
    /// <summary>
    /// StrProperty: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesDescriptionModifiedByKismet_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }
    /// <summary>
    /// StrProperty: SubroutinesDescriptionModifiedByKismet
    /// </summary>
    public unsafe BmSDK.FString SubroutinesDescriptionModifiedByKismet_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }
}
