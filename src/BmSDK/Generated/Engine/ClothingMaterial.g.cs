#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ClothingMaterial<br/>
/// (size = 96)
/// (flags = 134226066)
/// </summary>
public partial class ClothingMaterial : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ClothingMaterial", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ClothingMaterial() { }

    /// <summary>
    /// Constructs a new ClothingMaterial
    /// </summary>
    public ClothingMaterial(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ClothingMaterial Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ClothingMaterial(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: SpeedThresholdOnMove
    /// </summary>
    public unsafe float SpeedThresholdOnMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// FloatProperty: SpeedThresholdOnRest
    /// </summary>
    public unsafe float SpeedThresholdOnRest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// IntProperty: NumOfCalculatedVertices
    /// </summary>
    public unsafe int NumOfCalculatedVertices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
}
