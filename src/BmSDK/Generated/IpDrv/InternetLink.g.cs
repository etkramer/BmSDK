#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.IpDrv;

/// <summary>
/// Class: InternetLink<br/>
/// (size = 704)
/// (flags = 144703642)
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
    /// Function: ResolveFailed
    /// </summary>
    public unsafe virtual void ResolveFailed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.InternetLink.ResolveFailed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Resolved
    /// </summary>
    public unsafe virtual void Resolved(BmSDK.IpDrv.InternetLink.FIpAddr Addr)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.InternetLink.Resolved", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Addr, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetLocalIP
    /// </summary>
    public unsafe virtual void GetLocalIP(out BmSDK.IpDrv.InternetLink.FIpAddr Arg)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.InternetLink.GetLocalIP", true);
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Arg = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.InternetLink.FIpAddr>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: StringToIpAddr
    /// </summary>
    public unsafe virtual bool StringToIpAddr(BmSDK.FString Str, out BmSDK.IpDrv.InternetLink.FIpAddr Addr)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.InternetLink.StringToIpAddr", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Str, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Addr = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.InternetLink.FIpAddr>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: IpAddrToString
    /// </summary>
    public unsafe virtual BmSDK.FString IpAddrToString(BmSDK.IpDrv.InternetLink.FIpAddr Arg)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.InternetLink.IpAddrToString", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Arg, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetLastError
    /// </summary>
    public unsafe virtual int GetLastError()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.InternetLink.GetLastError", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Resolve
    /// </summary>
    public unsafe virtual void Resolve(BmSDK.FString Domain)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.InternetLink.Resolve", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Domain, paramsPtr + 0);
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
    /// Function: ParseURL
    /// </summary>
    public unsafe virtual bool ParseURL(BmSDK.FString URL, out BmSDK.FString Addr, out int PortNum, out BmSDK.FString LevelName, out BmSDK.FString EntryName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.InternetLink.ParseURL", true);
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(URL, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Addr = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 16);
        PortNum = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 32);
        LevelName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 36);
        EntryName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 52);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 68);
    }

    /// <summary>
    /// Function: IsDataPending
    /// </summary>
    public unsafe virtual bool IsDataPending()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "IpDrv.InternetLink.IsDataPending", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Enum: EReceiveMode
    /// </summary>
    public enum EReceiveMode
    {
        RMODE_Manual = 0,
        RMODE_Event = 1,
        RMODE_MAX = 2,
    }

    /// <summary>
    /// Enum: ELineMode
    /// </summary>
    public enum ELineMode
    {
        LMODE_auto = 0,
        LMODE_DOS = 1,
        LMODE_UNIX = 2,
        LMODE_MAC = 3,
        LMODE_MAX = 4,
    }

    /// <summary>
    /// ByteProperty: LinkMode
    /// </summary>
    public unsafe BmSDK.IpDrv.InternetLink.ELinkMode LinkMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.InternetLink.ELinkMode>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ByteProperty: InLineMode
    /// </summary>
    public unsafe BmSDK.IpDrv.InternetLink.ELineMode InLineMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.InternetLink.ELineMode>(Ptr + 669); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 669); }
    }

    /// <summary>
    /// ByteProperty: OutLineMode
    /// </summary>
    public unsafe BmSDK.IpDrv.InternetLink.ELineMode OutLineMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.InternetLink.ELineMode>(Ptr + 670); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 670); }
    }

    /// <summary>
    /// ByteProperty: ReceiveMode
    /// </summary>
    public unsafe BmSDK.IpDrv.InternetLink.EReceiveMode ReceiveMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.InternetLink.EReceiveMode>(Ptr + 671); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 671); }
    }

    /// <summary>
    /// StructProperty: Socket
    /// </summary>
    public unsafe System.IntPtr Socket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 672); }
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
    public unsafe System.IntPtr RemoteSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// StructProperty: PrivateResolveInfo
    /// </summary>
    public unsafe System.IntPtr PrivateResolveInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 692); }
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
    [StructLayout(LayoutKind.Explicit, Size = 8)]
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
