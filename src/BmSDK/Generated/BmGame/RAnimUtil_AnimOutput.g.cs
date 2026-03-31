#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RAnimUtil_AnimOutput<br/>
/// (size = 44)
/// (flags = 134217875)
/// </summary>
public partial class RAnimUtil_AnimOutput : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimUtil_AnimOutput", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimUtil_AnimOutput() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimUtil_AnimOutput(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AnimOutput>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AnimOutput>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AnimOutput>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AnimOutput>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AnimOutput>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AnimOutput>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AnimOutput>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AnimOutput>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Struct: FAnimOutput
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 2976)]
    public partial record struct FAnimOutput
    {
        /// <summary>
        /// StructProperty: Anims
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnimArrays Anims
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnimArrays>((IntPtr)thisPtr + 0); } }
        }

        /// <summary>
        /// StructProperty: MirroredAnims
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnimArrays MirroredAnims
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnimArrays>((IntPtr)thisPtr + 1488); } }
        }
    }

    /// <summary>
    /// Struct: FFinalAnimArrays
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 1488)]
    public partial record struct FFinalAnimArrays
    {
        /// <summary>
        /// StructProperty: FullBody
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnimArray FullBody
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnimArray>((IntPtr)thisPtr + 0); } }
        }

        /// <summary>
        /// StructProperty: LowerBody
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnimArray LowerBody
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnimArray>((IntPtr)thisPtr + 496); } }
        }

        /// <summary>
        /// StructProperty: UpperBody
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnimArray UpperBody
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnimArray>((IntPtr)thisPtr + 992); } }
        }
    }

    /// <summary>
    /// Struct: FFinalAnimArray
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 496)]
    public partial record struct FFinalAnimArray
    {
        /// <summary>
        /// IntProperty: Num
        /// </summary>
        public unsafe int Num
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnim Data_0
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnim>((IntPtr)thisPtr + 16); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnim Data_1
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnim>((IntPtr)thisPtr + 64); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnim Data_2
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnim>((IntPtr)thisPtr + 112); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnim Data_3
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnim>((IntPtr)thisPtr + 160); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnim Data_4
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnim>((IntPtr)thisPtr + 208); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnim Data_5
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnim>((IntPtr)thisPtr + 256); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnim Data_6
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnim>((IntPtr)thisPtr + 304); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnim Data_7
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnim>((IntPtr)thisPtr + 352); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnim Data_8
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnim>((IntPtr)thisPtr + 400); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnim Data_9
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AnimOutput.FFinalAnim>((IntPtr)thisPtr + 448); } }
        }
    }

    /// <summary>
    /// Struct: FFinalAnim
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FFinalAnim
    {
        /// <summary>
        /// StructProperty: MotionAtom
        /// </summary>
        public unsafe ref BmSDK.GameObject.FBoneAtom MotionAtom
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FBoneAtom>((IntPtr)thisPtr + 0); } }
        }

        /// <summary>
        /// ObjectProperty: Sequence
        /// </summary>
        public unsafe BmSDK.Engine.AnimSequence Sequence
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: Time
        /// </summary>
        public unsafe float Time
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// StructProperty: Weight
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimConfig.FWeight Weight
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimConfig.FWeight>((IntPtr)thisPtr + 40); } }
        }

        /// <summary>
        /// ObjectProperty: PerAnimAimingConfig
        /// </summary>
        public unsafe BmSDK.BmGame.RAimingConfig PerAnimAimingConfig
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAimingConfig>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }
    }
}
