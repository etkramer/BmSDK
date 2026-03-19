#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Interaction<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class Interaction : BmSDK.Engine.UIRoot, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Interaction", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Interaction() { }

    /// <summary>
    /// Constructs a new Interaction
    /// </summary>
    public Interaction(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Interaction Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Interaction(nint ptr) : base(ptr) { }

    /// <summary>
    /// DelegateProperty: __OnReceivedNativeInputKey__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReceivedNativeInputKey__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// DelegateProperty: __OnReceivedNativeInputAxis__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReceivedNativeInputAxis__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// DelegateProperty: __OnReceivedNativeInputChar__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReceivedNativeInputChar__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// DelegateProperty: __OnInitialize__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnInitialize__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// Function: OnReceivedNativeInputKey
    /// </summary>
    public unsafe bool OnReceivedNativeInputKey(int ControllerId, BmSDK.FName Key, byte EventType, float AmountDepressed = default, bool bGamepad = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.Interaction.OnReceivedNativeInputKey", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ControllerId, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventType, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AmountDepressed, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGamepad, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Enum: ETouchType
    /// </summary>
    public enum ETouchType
    {
        Touch_Began = 0,
        Touch_Moved = 1,
        Touch_Stationary = 2,
        Touch_Ended = 3,
        Touch_Cancelled = 4,
        Touch_MAX = 5,
    }
}
