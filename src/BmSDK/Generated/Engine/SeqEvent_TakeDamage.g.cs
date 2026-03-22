#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqEvent_TakeDamage<br/>
/// (size = 268)
/// (flags = 134217874)
/// </summary>
public partial class SeqEvent_TakeDamage : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqEvent_TakeDamage", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqEvent_TakeDamage() { }

    /// <summary>
    /// Constructs a new SeqEvent_TakeDamage
    /// </summary>
    public SeqEvent_TakeDamage(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqEvent_TakeDamage Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqEvent_TakeDamage(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: Toggled
    /// </summary>
    public unsafe override void Toggled()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SeqEvent_TakeDamage.Toggled", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SeqEvent_TakeDamage.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Reset
    /// </summary>
    public unsafe override void Reset()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SeqEvent_TakeDamage.Reset", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HandleDamage
    /// </summary>
    public unsafe virtual void HandleDamage(BmSDK.Engine.Actor InOriginator, BmSDK.Engine.Actor InInstigator, BmSDK.Class inDamageType, int inAmount, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SeqEvent_TakeDamage.HandleDamage", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InOriginator, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InInstigator, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inDamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inAmount, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsValidDamageType
    /// </summary>
    public unsafe virtual bool IsValidDamageType(BmSDK.Class inDamageType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SeqEvent_TakeDamage.IsValidDamageType", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inDamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// FloatProperty: MinDamageAmount
    /// </summary>
    public unsafe float MinDamageAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// FloatProperty: DamageThreshold
    /// </summary>
    public unsafe float DamageThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// ArrayProperty: DamageTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> DamageTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ArrayProperty: IgnoreDamageTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> IgnoreDamageTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// FloatProperty: CurrentDamage
    /// </summary>
    public unsafe float CurrentDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bResetDamageOnToggle
    /// </summary>
    public unsafe bool bResetDamageOnToggle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }
}
