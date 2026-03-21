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

    /// <summary>
    /// Struct: FAdditiveAnimOutput
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 3104)]
    public partial record struct FAdditiveAnimOutput
    {
        /// <summary>
        /// StructProperty: Anims
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnimArray Anims
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnimArray>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: MirroredAnims
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnimArray MirroredAnims
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnimArray>(Ptr + 1552); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1552); }; }
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
        public unsafe BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>(Ptr + 192); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>(Ptr + 288); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_4
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>(Ptr + 384); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_5
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>(Ptr + 480); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_6
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>(Ptr + 576); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_7
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>(Ptr + 672); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_8
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>(Ptr + 768); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_9
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>(Ptr + 864); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_10
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>(Ptr + 960); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_11
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>(Ptr + 1056); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_12
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>(Ptr + 1152); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_13
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>(Ptr + 1248); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_14
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>(Ptr + 1344); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }; }
        }
        /// <summary>
        /// StructProperty: Data
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim Data_15
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_AdditiveAnimOutput.FFinalAdditiveAnim>(Ptr + 1440); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }; }
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
        public unsafe BmSDK.GameObject.FBoneAtom AddMotionAtom
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FBoneAtom>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: SubtractMotionAtom
        /// </summary>
        public unsafe BmSDK.GameObject.FBoneAtom SubtractMotionAtom
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FBoneAtom>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
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
        public unsafe BmSDK.BmGame.RAnimConfig.FWeight Weight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimConfig.FWeight>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }
    }
}
