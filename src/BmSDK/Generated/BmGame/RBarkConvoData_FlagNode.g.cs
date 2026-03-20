#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkConvoData_FlagNode<br/>
/// (flags = 0)
/// </summary>
public partial class RBarkConvoData_FlagNode : BmSDK.Engine.AkHash, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBarkConvoData_FlagNode", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBarkConvoData_FlagNode() { }

    /// <summary>
    /// Constructs a new RBarkConvoData_FlagNode
    /// </summary>
    public RBarkConvoData_FlagNode(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBarkConvoData_FlagNode Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBarkConvoData_FlagNode(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetVoiceList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkDialogueVoice> GetVoiceList()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBarkConvoData_FlagNode.GetVoiceList", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkDialogueVoice>>(paramsPtr + 0);
    }

    /// <summary>
    /// ArrayProperty: FlagLineData
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkConvoData_FlagNode.FFlagLineEntry> FlagLineData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkConvoData_FlagNode.FFlagLineEntry>>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// Struct: FFlagLineEntry
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FFlagLineEntry
    {
        /// <summary>
        /// ObjectProperty: AKDynLine
        /// </summary>
        public unsafe BmSDK.Engine.AkDialogueLineDynamic AKDynLine
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueLineDynamic>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: AKSingleLine
        /// </summary>
        public unsafe BmSDK.Engine.AkDialogueLine AKSingleLine
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueLine>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ObjectProperty: FlagBase
        /// </summary>
        public unsafe BmSDK.BmGame.RBarkFlagBase FlagBase
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkFlagBase>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }
}
