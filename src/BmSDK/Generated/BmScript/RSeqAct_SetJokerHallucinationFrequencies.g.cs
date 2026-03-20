#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_SetJokerHallucinationFrequencies<br/>
/// (size = 380)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_SetJokerHallucinationFrequencies : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_SetJokerHallucinationFrequencies", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetJokerHallucinationFrequencies() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetJokerHallucinationFrequencies
    /// </summary>
    public RSeqAct_SetJokerHallucinationFrequencies(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetJokerHallucinationFrequencies Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetJokerHallucinationFrequencies(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_SetJokerHallucinationFrequencies.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_SetJokerHallucinationFrequencies.Activated", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bPerminant
    /// </summary>
    public unsafe bool bPerminant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bAssignedAnims
    /// </summary>
    public unsafe bool bAssignedAnims
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// ArrayProperty: FrequencyOverrides
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RSeqAct_SetJokerHallucinationFrequencies.FCustomFreq> FrequencyOverrides
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RSeqAct_SetJokerHallucinationFrequencies.FCustomFreq>>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// ObjectProperty: CustomAnims
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CustomAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// Struct: FCustomFreq
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 5)]
    public partial record struct FCustomFreq
    {
        /// <summary>
        /// IntProperty: PercentChance
        /// </summary>
        public unsafe int PercentChance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: HallucinationType
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnJokerHallucination.TypesOfHallucination HallucinationType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnJokerHallucination.TypesOfHallucination>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }
}
