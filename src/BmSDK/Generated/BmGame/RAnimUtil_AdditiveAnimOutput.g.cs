#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RAnimUtil_AdditiveAnimOutput<br/>
/// (size = 44)
/// (flags = 134217875)
/// </summary>
public partial class RAnimUtil_AdditiveAnimOutput : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimUtil_AdditiveAnimOutput", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimUtil_AdditiveAnimOutput() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimUtil_AdditiveAnimOutput(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AdditiveAnimOutput>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AdditiveAnimOutput>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AdditiveAnimOutput>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AdditiveAnimOutput>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AdditiveAnimOutput>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AdditiveAnimOutput>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AdditiveAnimOutput>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimUtil_AdditiveAnimOutput>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Struct: FAdditiveAnimOutput
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 3104)]
    public partial record struct FAdditiveAnimOutput
    {
        /// <summary>
        /// StructProperty: Anims
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnimArray Anims
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnimArray>((IntPtr)thisPtr + 0); } }
        }

        /// <summary>
        /// StructProperty: MirroredAnims
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnimArray MirroredAnims
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnimArray>((IntPtr)thisPtr + 1552); } }
        }
    }

    /// <summary>
    /// Struct: FFinalAdditiveAnimArray
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 1540)]
    public partial record struct FFinalAdditiveAnimArray
    {
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_0
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>((IntPtr)thisPtr + 0); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_1
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>((IntPtr)thisPtr + 96); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_2
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>((IntPtr)thisPtr + 192); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_3
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>((IntPtr)thisPtr + 288); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_4
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>((IntPtr)thisPtr + 384); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_5
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>((IntPtr)thisPtr + 480); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_6
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>((IntPtr)thisPtr + 576); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_7
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>((IntPtr)thisPtr + 672); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_8
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>((IntPtr)thisPtr + 768); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_9
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>((IntPtr)thisPtr + 864); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_10
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>((IntPtr)thisPtr + 960); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_11
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>((IntPtr)thisPtr + 1056); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_12
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>((IntPtr)thisPtr + 1152); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_13
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>((IntPtr)thisPtr + 1248); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_14
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>((IntPtr)thisPtr + 1344); } }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_15
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>((IntPtr)thisPtr + 1440); } }
        }

        /// <summary>
        /// IntProperty: Num
        /// </summary>
        public unsafe int Num
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1536); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }; }
        }
    }

    /// <summary>
    /// Struct: FFinalAdditiveAnim
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 84)]
    public partial record struct FFinalAdditiveAnim
    {
        /// <summary>
        /// StructProperty: AddMotionAtom
        /// </summary>
        public unsafe ref BmSDK.GameObject.FBoneAtom AddMotionAtom
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FBoneAtom>((IntPtr)thisPtr + 0); } }
        }

        /// <summary>
        /// StructProperty: SubtractMotionAtom
        /// </summary>
        public unsafe ref BmSDK.GameObject.FBoneAtom SubtractMotionAtom
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FBoneAtom>((IntPtr)thisPtr + 32); } }
        }

        /// <summary>
        /// ObjectProperty: Add
        /// </summary>
        public unsafe BmSDK.Engine.AnimSequence Add
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// FloatProperty: AddTime
        /// </summary>
        public unsafe float AddTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// ObjectProperty: Subtract
        /// </summary>
        public unsafe BmSDK.Engine.AnimSequence Subtract
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// FloatProperty: SubtractTime
        /// </summary>
        public unsafe float SubtractTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// StructProperty: Weight
        /// </summary>
        public unsafe ref BmSDK.BmGame.RAnimConfig.FWeight Weight
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimConfig.FWeight>((IntPtr)thisPtr + 80); } }
        }
    }
}
