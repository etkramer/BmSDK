#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RWeaponConfig<br/>
/// (flags = 0)
/// </summary>
public partial class RWeaponConfig : BmSDK.BmGame.RConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RWeaponConfig", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RWeaponConfig() { }

    /// <summary>
    /// Constructs a new RWeaponConfig
    /// </summary>
    public RWeaponConfig(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RWeaponConfig Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RWeaponConfig(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: DebugName
    /// </summary>
    public unsafe BmSDK.FString DebugName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: AnimSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> AnimSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: PoseConfigs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPoseConfig> PoseConfigs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPoseConfig>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: Extends
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RWeaponConfig> Extends
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RWeaponConfig>>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: PreviewSkeletalMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh PreviewSkeletalMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ObjectProperty: PreviewExtraSkelMeshes
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh PreviewExtraSkelMeshes_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
    /// <summary>
    /// ObjectProperty: PreviewExtraSkelMeshes
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh PreviewExtraSkelMeshes_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }
    /// <summary>
    /// ObjectProperty: PreviewExtraSkelMeshes
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh PreviewExtraSkelMeshes_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: PreviewCamPos
    /// </summary>
    public unsafe System.Numerics.Vector3 PreviewCamPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// StructProperty: PreviewCamRot
    /// </summary>
    public unsafe BmSDK.Rotator PreviewCamRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// StrProperty: Notes
    /// </summary>
    public unsafe BmSDK.FString Notes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

}
