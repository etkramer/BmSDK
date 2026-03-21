#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RCharacter_ThugBase<br/>
/// (size = 524)
/// (flags = 201326739)
/// </summary>
public partial class RCharacter_ThugBase : BmSDK.BmGame.RCharacter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCharacter_ThugBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_ThugBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_ThugBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCharacter_ThugBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCharacter_ThugBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCharacter_ThugBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCharacter_ThugBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCharacter_ThugBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCharacter_ThugBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCharacter_ThugBase>
        => ((GameObject)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// NameProperty: VestOnName
    /// </summary>
    public unsafe BmSDK.FName VestOnName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// NameProperty: BlackHeadName
    /// </summary>
    public unsafe BmSDK.FName BlackHeadName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// NameProperty: VestColourName
    /// </summary>
    public unsafe BmSDK.FName VestColourName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// NameProperty: ClothesColourName
    /// </summary>
    public unsafe BmSDK.FName ClothesColourName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// NameProperty: TattoosOnName
    /// </summary>
    public unsafe BmSDK.FName TattoosOnName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// BoolProperty: VestOnDef
    /// </summary>
    public unsafe bool VestOnDef
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 448); }
    }

    /// <summary>
    /// BoolProperty: TattoosOnDef
    /// </summary>
    public unsafe bool TattoosOnDef
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 448); }
    }

    /// <summary>
    /// BoolProperty: bCanRandomise
    /// </summary>
    public unsafe bool bCanRandomise
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 448); }
    }

    /// <summary>
    /// BoolProperty: bSyncVestAndClothesColour
    /// </summary>
    public unsafe bool bSyncVestAndClothesColour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 448); }
    }

    /// <summary>
    /// BoolProperty: BlackHeadDef
    /// </summary>
    public unsafe bool BlackHeadDef
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 448); }
    }

    /// <summary>
    /// StructProperty: VestColourDef
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor VestColourDef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// StructProperty: ClothesColourDef
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor ClothesColourDef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// ArrayProperty: PresetVestColours
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FLinearColor> PresetVestColours
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FLinearColor>>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// ArrayProperty: PresetClothesColours
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FLinearColor> PresetClothesColours
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FLinearColor>>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// ObjectProperty: VestOverrideMat
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant VestOverrideMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// ObjectProperty: BlackHeadOverrideMat
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant BlackHeadOverrideMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// ObjectProperty: BlackBodyOverrideMat
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant BlackBodyOverrideMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// ObjectProperty: GunRelaxedSpeechSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet GunRelaxedSpeechSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }
}
