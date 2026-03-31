#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimNodeAimOffset<br/>
/// (size = 300)
/// (flags = 144703634)
/// </summary>
public partial class AnimNodeAimOffset : BmSDK.Engine.AnimNodeBlendBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimNodeAimOffset", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimNodeAimOffset() { }

    /// <summary>
    /// Constructs a new AnimNodeAimOffset
    /// </summary>
    public AnimNodeAimOffset(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimNodeAimOffset Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimNodeAimOffset(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AnimNodeAimOffset>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AnimNodeAimOffset>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AnimNodeAimOffset>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AnimNodeAimOffset>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AnimNodeAimOffset>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AnimNodeAimOffset>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<AnimNodeAimOffset>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<AnimNodeAimOffset>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: SetActiveProfileByIndex
    /// </summary>
    public unsafe virtual void SetActiveProfileByIndex(int ProfileIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AnimNodeAimOffset.SetActiveProfileByIndex", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileIndex, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: SetActiveProfileByName
    /// </summary>
    public unsafe virtual void SetActiveProfileByName(BmSDK.FName ProfileName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AnimNodeAimOffset.SetActiveProfileByName", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProfileName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Struct: FAimOffsetProfile
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 108)]
    public partial record struct FAimOffsetProfile
    {
        /// <summary>
        /// NameProperty: ProfileName
        /// </summary>
        public unsafe BmSDK.FName ProfileName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: HorizontalRange
        /// </summary>
        public unsafe ref System.Numerics.Vector2 HorizontalRange
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector2>((IntPtr)thisPtr + 8); } }
        }

        /// <summary>
        /// StructProperty: VerticalRange
        /// </summary>
        public unsafe ref System.Numerics.Vector2 VerticalRange
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector2>((IntPtr)thisPtr + 16); } }
        }

        /// <summary>
        /// ArrayProperty: AimComponents
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.AnimNodeAimOffset.FAimComponent> AimComponents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimNodeAimOffset.FAimComponent>>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// NameProperty: AnimName_LU
        /// </summary>
        public unsafe BmSDK.FName AnimName_LU
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// NameProperty: AnimName_LC
        /// </summary>
        public unsafe BmSDK.FName AnimName_LC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// NameProperty: AnimName_LD
        /// </summary>
        public unsafe BmSDK.FName AnimName_LD
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// NameProperty: AnimName_CU
        /// </summary>
        public unsafe BmSDK.FName AnimName_CU
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// NameProperty: AnimName_CC
        /// </summary>
        public unsafe BmSDK.FName AnimName_CC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// NameProperty: AnimName_CD
        /// </summary>
        public unsafe BmSDK.FName AnimName_CD
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// NameProperty: AnimName_RU
        /// </summary>
        public unsafe BmSDK.FName AnimName_RU
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// NameProperty: AnimName_RC
        /// </summary>
        public unsafe BmSDK.FName AnimName_RC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 92); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }; }
        }

        /// <summary>
        /// NameProperty: AnimName_RD
        /// </summary>
        public unsafe BmSDK.FName AnimName_RD
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 100); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }; }
        }
    }

    /// <summary>
    /// StructProperty: Aim
    /// </summary>
    public unsafe ref System.Numerics.Vector2 Aim
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector2>(Ptr + 228);

    /// <summary>
    /// StructProperty: AngleOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector2 AngleOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector2>(Ptr + 236);

    /// <summary>
    /// BoolProperty: bForceAimDir
    /// </summary>
    public unsafe bool bForceAimDir
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 244); }
    }

    /// <summary>
    /// BoolProperty: bBakeFromAnimations
    /// </summary>
    public unsafe bool bBakeFromAnimations
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 244); }
    }

    /// <summary>
    /// BoolProperty: bPassThroughWhenNotRendered
    /// </summary>
    public unsafe bool bPassThroughWhenNotRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 244); }
    }

    /// <summary>
    /// BoolProperty: bSynchronizeNodesInEditor
    /// </summary>
    public unsafe bool bSynchronizeNodesInEditor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 244); }
    }

    /// <summary>
    /// IntProperty: PassThroughAtOrAboveLOD
    /// </summary>
    public unsafe int PassThroughAtOrAboveLOD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// ByteProperty: ForcedAimDir
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeAimOffset.EAnimAimDir ForcedAimDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeAimOffset.EAnimAimDir>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// ArrayProperty: RequiredBones
    /// </summary>
    public unsafe BmSDK.TArray<byte> RequiredBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// ArrayProperty: AimCpntIndexLUT
    /// </summary>
    public unsafe BmSDK.TArray<byte> AimCpntIndexLUT
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// ObjectProperty: TemplateNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeAimOffset TemplateNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeAimOffset>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// ArrayProperty: Profiles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimNodeAimOffset.FAimOffsetProfile> Profiles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimNodeAimOffset.FAimOffsetProfile>>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// IntProperty: CurrentProfileIndex
    /// </summary>
    public unsafe int CurrentProfileIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// Enum: EAimID
    /// </summary>
    public enum EAimID
    {
        EAID_LeftUp = 0,
        EAID_LeftDown = 1,
        EAID_RightUp = 2,
        EAID_RightDown = 3,
        EAID_ZeroUp = 4,
        EAID_ZeroDown = 5,
        EAID_ZeroLeft = 6,
        EAID_ZeroRight = 7,
        EAID_CellLU = 8,
        EAID_CellCU = 9,
        EAID_CellRU = 10,
        EAID_CellLC = 11,
        EAID_CellCC = 12,
        EAID_CellRC = 13,
        EAID_CellLD = 14,
        EAID_CellCD = 15,
        EAID_CellRD = 16,
        EAID_MAX = 17,
    }

    /// <summary>
    /// Enum: EAnimAimDir
    /// </summary>
    public enum EAnimAimDir
    {
        ANIMAIM_LEFTUP = 0,
        ANIMAIM_CENTERUP = 1,
        ANIMAIM_RIGHTUP = 2,
        ANIMAIM_LEFTCENTER = 3,
        ANIMAIM_CENTERCENTER = 4,
        ANIMAIM_RIGHTCENTER = 5,
        ANIMAIM_LEFTDOWN = 6,
        ANIMAIM_CENTERDOWN = 7,
        ANIMAIM_RIGHTDOWN = 8,
        ANIMAIM_MAX = 9,
    }

    /// <summary>
    /// Struct: FAimComponent
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 304)]
    public partial record struct FAimComponent
    {
        /// <summary>
        /// NameProperty: BoneName
        /// </summary>
        public unsafe BmSDK.FName BoneName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: LU
        /// </summary>
        public unsafe ref BmSDK.Engine.AnimNodeAimOffset.FAimTransform LU
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AnimNodeAimOffset.FAimTransform>((IntPtr)thisPtr + 16); } }
        }

        /// <summary>
        /// StructProperty: LC
        /// </summary>
        public unsafe ref BmSDK.Engine.AnimNodeAimOffset.FAimTransform LC
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AnimNodeAimOffset.FAimTransform>((IntPtr)thisPtr + 48); } }
        }

        /// <summary>
        /// StructProperty: LD
        /// </summary>
        public unsafe ref BmSDK.Engine.AnimNodeAimOffset.FAimTransform LD
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AnimNodeAimOffset.FAimTransform>((IntPtr)thisPtr + 80); } }
        }

        /// <summary>
        /// StructProperty: CU
        /// </summary>
        public unsafe ref BmSDK.Engine.AnimNodeAimOffset.FAimTransform CU
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AnimNodeAimOffset.FAimTransform>((IntPtr)thisPtr + 112); } }
        }

        /// <summary>
        /// StructProperty: CC
        /// </summary>
        public unsafe ref BmSDK.Engine.AnimNodeAimOffset.FAimTransform CC
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AnimNodeAimOffset.FAimTransform>((IntPtr)thisPtr + 144); } }
        }

        /// <summary>
        /// StructProperty: CD
        /// </summary>
        public unsafe ref BmSDK.Engine.AnimNodeAimOffset.FAimTransform CD
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AnimNodeAimOffset.FAimTransform>((IntPtr)thisPtr + 176); } }
        }

        /// <summary>
        /// StructProperty: RU
        /// </summary>
        public unsafe ref BmSDK.Engine.AnimNodeAimOffset.FAimTransform RU
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AnimNodeAimOffset.FAimTransform>((IntPtr)thisPtr + 208); } }
        }

        /// <summary>
        /// StructProperty: RC
        /// </summary>
        public unsafe ref BmSDK.Engine.AnimNodeAimOffset.FAimTransform RC
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AnimNodeAimOffset.FAimTransform>((IntPtr)thisPtr + 240); } }
        }

        /// <summary>
        /// StructProperty: RD
        /// </summary>
        public unsafe ref BmSDK.Engine.AnimNodeAimOffset.FAimTransform RD
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.AnimNodeAimOffset.FAimTransform>((IntPtr)thisPtr + 272); } }
        }
    }

    /// <summary>
    /// Struct: FAimTransform
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FAimTransform
    {
        /// <summary>
        /// StructProperty: Quaternion
        /// </summary>
        public unsafe ref BmSDK.GameObject.FQuat Quaternion
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FQuat>((IntPtr)thisPtr + 0); } }
        }

        /// <summary>
        /// StructProperty: Translation
        /// </summary>
        public unsafe ref System.Numerics.Vector3 Translation
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>((IntPtr)thisPtr + 16); } }
        }
    }
}
