#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: FaceFXAsset<br/>
/// (flags = 0)
/// </summary>
public partial class FaceFXAsset : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.FaceFXAsset", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal FaceFXAsset() { }

    /// <summary>
    /// Constructs a new FaceFXAsset
    /// </summary>
    public FaceFXAsset(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, FaceFXAsset Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected FaceFXAsset(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: DefaultSkelMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh DefaultSkelMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StructProperty: FaceFXActor
    /// </summary>
    public unsafe System.IntPtr FaceFXActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: RawFaceFXActorBytes
    /// </summary>
    public unsafe BmSDK.TArray<byte> RawFaceFXActorBytes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: RawFaceFXSessionBytes
    /// </summary>
    public unsafe BmSDK.TArray<byte> RawFaceFXSessionBytes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: PreviewMorphSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MorphTargetSet> PreviewMorphSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MorphTargetSet>>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ArrayProperty: MountedFaceFXAnimSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.FaceFXAnimSet> MountedFaceFXAnimSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.FaceFXAnimSet>>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ArrayProperty: ReferencedSoundCues
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SoundCue> ReferencedSoundCues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SoundCue>>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// IntProperty: NumLoadErrors
    /// </summary>
    public unsafe int NumLoadErrors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// BoolProperty: RequiresRefBoneClientIndexCleanup
    /// </summary>
    public unsafe bool RequiresRefBoneClientIndexCleanup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 184); }
    }

    /// <summary>
    /// BoolProperty: RequiresDependentVariableUpdate
    /// </summary>
    public unsafe bool RequiresDependentVariableUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 184); }
    }

    /// <summary>
    /// ArrayProperty: MirrorSwapTable
    /// </summary>
    public unsafe BmSDK.TArray<int> MirrorSwapTable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ArrayProperty: MirrorFlipTable
    /// </summary>
    public unsafe BmSDK.TArray<float> MirrorFlipTable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// MapProperty: RegisterNameToIndex
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ RegisterNameToIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }
}
