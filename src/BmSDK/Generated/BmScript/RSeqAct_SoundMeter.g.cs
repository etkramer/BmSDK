#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_SoundMeter<br/>
/// (size = 292)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_SoundMeter : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_SoundMeter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SoundMeter() { }

    /// <summary>
    /// Constructs a new RSeqAct_SoundMeter
    /// </summary>
    public RSeqAct_SoundMeter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SoundMeter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SoundMeter(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_SoundMeter.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: BatmanExceedsAmbient
    /// </summary>
    public unsafe virtual bool BatmanExceedsAmbient()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_SoundMeter.BatmanExceedsAmbient", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: AddAmbientSound
    /// </summary>
    public unsafe virtual void AddAmbientSound(BmSDK.BmScript.RSeqAct_SoundMeter.SoundMeterVolume ffv)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_SoundMeter.AddAmbientSound", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ffv, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddBatmanSound
    /// </summary>
    public unsafe virtual void AddBatmanSound(BmSDK.BmScript.RSeqAct_SoundMeter.SoundMeterVolume ffv)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_SoundMeter.AddBatmanSound", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ffv, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateHud
    /// </summary>
    public unsafe virtual void UpdateHud()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_SoundMeter.UpdateHud", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Update
    /// </summary>
    public unsafe override bool Update(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_SoundMeter.Update", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: UpdateNoiseLevel
    /// </summary>
    public unsafe virtual void UpdateNoiseLevel()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_SoundMeter.UpdateNoiseLevel", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe override void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_SoundMeter.Activated", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// FloatProperty: AmbientLevel
    /// </summary>
    public unsafe float AmbientLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// FloatProperty: AmbientLevelExtra
    /// </summary>
    public unsafe float AmbientLevelExtra
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// FloatProperty: AmbientLevelDeviation
    /// </summary>
    public unsafe float AmbientLevelDeviation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// FloatProperty: AmbientLevelTarget
    /// </summary>
    public unsafe float AmbientLevelTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// FloatProperty: AmbientLevelFallOffTime
    /// </summary>
    public unsafe float AmbientLevelFallOffTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// FloatProperty: BatmanLevel
    /// </summary>
    public unsafe float BatmanLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// FloatProperty: BatmanLevelExtra
    /// </summary>
    public unsafe float BatmanLevelExtra
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// FloatProperty: BatmanLevelDeviation
    /// </summary>
    public unsafe float BatmanLevelDeviation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// FloatProperty: BatmanLevelTarget
    /// </summary>
    public unsafe float BatmanLevelTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// FloatProperty: BatmanLevelFallOffTime
    /// </summary>
    public unsafe float BatmanLevelFallOffTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// FloatProperty: AmbientLevelPlusDeviation
    /// </summary>
    public unsafe float AmbientLevelPlusDeviation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// FloatProperty: BatmanLevelPlusDeviation
    /// </summary>
    public unsafe float BatmanLevelPlusDeviation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// FloatProperty: BatmanExceedingAmbientTimer
    /// </summary>
    public unsafe float BatmanExceedingAmbientTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// FloatProperty: BatmanLastNoiseTimer
    /// </summary>
    public unsafe float BatmanLastNoiseTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// IntProperty: LastBiggestNoise
    /// </summary>
    public unsafe int LastBiggestNoise
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// IntProperty: LastBiggestAmbientNoise
    /// </summary>
    public unsafe int LastBiggestAmbientNoise
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// FloatProperty: TimeTillUpdate
    /// </summary>
    public unsafe float TimeTillUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// BoolProperty: bHasTripped
    /// </summary>
    public unsafe bool bHasTripped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 288) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 288); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 288); }
    }

    /// <summary>
    /// Enum: SoundMeterVolume
    /// </summary>
    public enum SoundMeterVolume
    {
        CSMV_Quiet = 0,
        CSMV_Medium = 1,
        CSMV_Loud = 2,
        CSMV_MAX = 3,
    }
}
