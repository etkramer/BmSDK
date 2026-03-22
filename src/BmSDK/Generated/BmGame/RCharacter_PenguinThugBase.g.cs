#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RCharacter_PenguinThugBase<br/>
/// (size = 556)
/// (flags = 201326739)
/// </summary>
public partial class RCharacter_PenguinThugBase : BmSDK.BmGame.RCharacter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCharacter_PenguinThugBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_PenguinThugBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_PenguinThugBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: LegClothesColourName
    /// </summary>
    public unsafe BmSDK.FName LegClothesColourName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// NameProperty: ClothesColourName
    /// </summary>
    public unsafe BmSDK.FName ClothesColourName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// NameProperty: BodyColourName
    /// </summary>
    public unsafe BmSDK.FName BodyColourName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// NameProperty: LegDesatName
    /// </summary>
    public unsafe BmSDK.FName LegDesatName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// BoolProperty: bCanRandomise
    /// </summary>
    public unsafe bool bCanRandomise
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 440); }
    }

    /// <summary>
    /// BoolProperty: bCanRandomiseHeadApparel
    /// </summary>
    public unsafe bool bCanRandomiseHeadApparel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 440); }
    }

    /// <summary>
    /// ArrayProperty: PresetLegClothesColours
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FLinearColor> PresetLegClothesColours
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FLinearColor>>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// ArrayProperty: PresetClothesColours
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FLinearColor> PresetClothesColours
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FLinearColor>>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ArrayProperty: PresetBodyColours
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FLinearColor> PresetBodyColours
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FLinearColor>>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// ArrayProperty: PresetLegDesats
    /// </summary>
    public unsafe BmSDK.TArray<float> PresetLegDesats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// NameProperty: HeadApparelColourName
    /// </summary>
    public unsafe BmSDK.FName HeadApparelColourName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// NameProperty: HeadApparelPatternName
    /// </summary>
    public unsafe BmSDK.FName HeadApparelPatternName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// NameProperty: HeadApparelPatternColourName
    /// </summary>
    public unsafe BmSDK.FName HeadApparelPatternColourName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// ArrayProperty: PresetHeadApparelColour
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FLinearColor> PresetHeadApparelColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FLinearColor>>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// ArrayProperty: PresetHeadApparelPattern
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FLinearColor> PresetHeadApparelPattern
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FLinearColor>>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// ArrayProperty: PresetHeadApparelPatternColour
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FLinearColor> PresetHeadApparelPatternColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FLinearColor>>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// ObjectProperty: GunRelaxedSpeechSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet GunRelaxedSpeechSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }
}
