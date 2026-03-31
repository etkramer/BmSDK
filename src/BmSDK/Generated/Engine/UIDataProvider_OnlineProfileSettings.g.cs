#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UIDataProvider_OnlineProfileSettings<br/>
/// (size = 112)
/// (flags = 134217886)
/// </summary>
public partial class UIDataProvider_OnlineProfileSettings : BmSDK.Engine.UIDataProvider_OnlinePlayerStorage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UIDataProvider_OnlineProfileSettings", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal UIDataProvider_OnlineProfileSettings() { }

    /// <summary>
    /// Constructs a new UIDataProvider_OnlineProfileSettings
    /// </summary>
    public UIDataProvider_OnlineProfileSettings(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UIDataProvider_OnlineProfileSettings Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UIDataProvider_OnlineProfileSettings(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UIDataProvider_OnlineProfileSettings>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDataProvider_OnlineProfileSettings>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UIDataProvider_OnlineProfileSettings>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDataProvider_OnlineProfileSettings>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDataProvider_OnlineProfileSettings>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDataProvider_OnlineProfileSettings>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UIDataProvider_OnlineProfileSettings>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDataProvider_OnlineProfileSettings>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: RefreshStorageData
    /// </summary>
    public unsafe override void RefreshStorageData()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataProvider_OnlineProfileSettings.RefreshStorageData", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearReadCompleteDelegate
    /// </summary>
    public unsafe override void ClearReadCompleteDelegate(BmSDK.Engine.OnlinePlayerInterface PlayerInterface, byte LocalUserNum)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataProvider_OnlineProfileSettings.ClearReadCompleteDelegate", true);
        byte* paramsPtr = stackalloc byte[9];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerInterface, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddReadCompleteDelegate
    /// </summary>
    public unsafe override void AddReadCompleteDelegate(BmSDK.Engine.OnlinePlayerInterface PlayerInterface, byte LocalUserNum)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataProvider_OnlineProfileSettings.AddReadCompleteDelegate", true);
        byte* paramsPtr = stackalloc byte[9];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerInterface, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetData
    /// </summary>
    public unsafe override bool GetData(BmSDK.Engine.OnlinePlayerInterface PlayerInterface, byte LocalUserNum, BmSDK.Engine.OnlinePlayerStorage PlayerStorage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataProvider_OnlineProfileSettings.GetData", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerInterface, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerStorage, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: ReadData
    /// </summary>
    public unsafe override bool ReadData(BmSDK.Engine.OnlinePlayerInterface PlayerInterface, byte LocalUserNum, int DeviceID, BmSDK.Engine.OnlinePlayerStorage PlayerStorage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataProvider_OnlineProfileSettings.ReadData", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerInterface, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeviceID, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerStorage, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }
}
