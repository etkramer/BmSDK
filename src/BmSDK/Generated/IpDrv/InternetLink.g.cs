#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.IpDrv;

/// <summary>
/// Class: InternetLink<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class InternetLink : BmSDK.Engine.Info, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "IpDrv.InternetLink", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InternetLink() { }

    /// <summary>
    /// Constructs a new InternetLink
    /// </summary>
    public InternetLink(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InternetLink Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InternetLink(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<InternetLink>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<InternetLink>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<InternetLink>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<InternetLink>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<InternetLink>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<InternetLink>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<InternetLink>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ByteProperty: LinkMode
    /// </summary>
    public unsafe byte LinkMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ByteProperty: InLineMode
    /// </summary>
    public unsafe byte InLineMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 669); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 669); }
    }

    /// <summary>
    /// ByteProperty: OutLineMode
    /// </summary>
    public unsafe byte OutLineMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 670); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 670); }
    }

    /// <summary>
    /// ByteProperty: ReceiveMode
    /// </summary>
    public unsafe byte ReceiveMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 671); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 671); }
    }

    /// <summary>
    /// StructProperty: Socket
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Socket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// IntProperty: Port
    /// </summary>
    public unsafe int Port
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// StructProperty: RemoteSocket
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RemoteSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// StructProperty: PrivateResolveInfo
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PrivateResolveInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// IntProperty: DataPending
    /// </summary>
    public unsafe int DataPending
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// Enum: ELinkMode
    /// </summary>
    public enum ELinkMode
    {
        MODE_Text = 0,
        MODE_Line = 1,
        MODE_Binary = 2,
        MODE_MAX = 3,
    }

    /// <summary>
    /// Struct: FIpAddr
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FIpAddr
    {
        /// <summary>
        /// IntProperty: Addr
        /// </summary>
        public unsafe int Addr
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Port
        /// </summary>
        public unsafe int Port
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }
}
