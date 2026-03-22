#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RCharacter_NinjaBase<br/>
/// (size = 492)
/// (flags = 201326739)
/// </summary>
public partial class RCharacter_NinjaBase : BmSDK.BmGame.RCharacter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCharacter_NinjaBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCharacter_NinjaBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCharacter_NinjaBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: ClothesColourName
    /// </summary>
    public unsafe BmSDK.FName ClothesColourName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// NameProperty: BodyColourName
    /// </summary>
    public unsafe BmSDK.FName BodyColourName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// NameProperty: ClothesDesatName
    /// </summary>
    public unsafe BmSDK.FName ClothesDesatName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// NameProperty: HairColourName
    /// </summary>
    public unsafe BmSDK.FName HairColourName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// ArrayProperty: PresetClothesColours
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FLinearColor> PresetClothesColours
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FLinearColor>>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// ArrayProperty: PresetBodyColours
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FLinearColor> PresetBodyColours
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FLinearColor>>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// ArrayProperty: PresetClothesDesats
    /// </summary>
    public unsafe BmSDK.TArray<float> PresetClothesDesats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// ArrayProperty: PresetHairColours
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FLinearColor> PresetHairColours
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FLinearColor>>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bCanRandomise
    /// </summary>
    public unsafe bool bCanRandomise
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 488); }
    }
}
