#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_PDLC1_Map<br/>
/// (size = 676)
/// (flags = 18)
/// </summary>
public partial class RGFxMovieUI_PDLC1_Map : BmSDK.BmGame.RGFxMovieUI_CustomBackScreen, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_PDLC1_Map", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_PDLC1_Map() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_PDLC1_Map
    /// </summary>
    public RGFxMovieUI_PDLC1_Map(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_PDLC1_Map Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_PDLC1_Map(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PDLC1_Map>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PDLC1_Map>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PDLC1_Map>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PDLC1_Map>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PDLC1_Map>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PDLC1_Map>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PDLC1_Map>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGFxMovieUI_PDLC1_Map>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: GetStickAngMag
    /// </summary>
    public unsafe virtual void GetStickAngMag(BmSDK.FString TargetBasePath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_PDLC1_Map.GetStickAngMag", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBasePath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetCameraRotation
    /// </summary>
    public unsafe virtual float GetCameraRotation(int Axis)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_PDLC1_Map.GetCameraRotation", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Axis, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetPlayerRotation
    /// </summary>
    public unsafe virtual float GetPlayerRotation(int Axis)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_PDLC1_Map.GetPlayerRotation", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Axis, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetPlayerRoomDescription
    /// </summary>
    public unsafe virtual BmSDK.FString GetPlayerRoomDescription()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_PDLC1_Map.GetPlayerRoomDescription", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetCustomWaypoint
    /// </summary>
    public unsafe virtual void SetCustomWaypoint(bool bEnabled, float atX, float atY, float atZ, BmSDK.FString WayPointName, BmSDK.FString WayPointTypeName, BmSDK.FString WayPointSubTypeName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_PDLC1_Map.SetCustomWaypoint", true);
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atZ, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WayPointName, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WayPointTypeName, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WayPointSubTypeName, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveMapObj
    /// </summary>
    public unsafe virtual void RemoveMapObj(BmSDK.FString ItemName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_PDLC1_Map.RemoveMapObj", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RequestPMapIconData
    /// </summary>
    public unsafe virtual void RequestPMapIconData(BmSDK.FString MapName, BmSDK.FString TargetBasePath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_PDLC1_Map.RequestPMapIconData", true);
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBasePath, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RequestMapFlagData
    /// </summary>
    public unsafe virtual void RequestMapFlagData(BmSDK.FString TargetBasePath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_PDLC1_Map.RequestMapFlagData", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBasePath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RequestMapData
    /// </summary>
    public unsafe virtual void RequestMapData(BmSDK.FString TargetBasePath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_PDLC1_Map.RequestMapData", true);
        byte* paramsPtr = stackalloc byte[88];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBasePath, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RequestObjectiveData
    /// </summary>
    public unsafe virtual void RequestObjectiveData(BmSDK.FString TargetObjectiveNames)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_PDLC1_Map.RequestObjectiveData", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetObjectiveNames, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_FlashCallsCloseScreen
    /// </summary>
    public unsafe virtual void XI_FlashCallsCloseScreen()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_PDLC1_Map.XI_FlashCallsCloseScreen", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RGFxMovieUI_PDLC1_Map.Init", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bMovedUserMarker
    /// </summary>
    public unsafe bool bMovedUserMarker
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 660); }
    }

    /// <summary>
    /// StrProperty: MapScript
    /// </summary>
    public unsafe BmSDK.FString MapScript
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }
}
