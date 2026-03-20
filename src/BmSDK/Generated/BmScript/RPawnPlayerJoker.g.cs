#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnPlayerJoker<br/>
/// (size = 10100)
/// (flags = 10486326)
/// </summary>
public partial class RPawnPlayerJoker : BmSDK.BmGame.RPawnPlayerJokerBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnPlayerJoker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnPlayerJoker() { }

    /// <summary>
    /// Constructs a new RPawnPlayerJoker
    /// </summary>
    public RPawnPlayerJoker(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnPlayerJoker Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerJoker(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerJoker>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerJoker>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerJoker>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerJoker>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerJoker>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerJoker>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerJoker>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: PlayShotReaction
    /// </summary>
    public unsafe void PlayShotReaction(System.Numerics.Vector3 HitDir)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerJoker.PlayShotReaction", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitDir, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShotBy
    /// </summary>
    public unsafe void ShotBy(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo, System.Numerics.Vector3 HitLocation = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerJoker.ShotBy", true);
        byte* paramsPtr = stackalloc byte[264];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 248);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddDefaultInventory
    /// </summary>
    public unsafe void AddDefaultInventory()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerJoker.AddDefaultInventory", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BeginBatmanSurprise
    /// </summary>
    public unsafe void BeginBatmanSurprise(BmSDK.Engine.Volume Vol)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerJoker.BeginBatmanSurprise", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Vol, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnableGunCursor
    /// </summary>
    public unsafe void EnableGunCursor()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerJoker.EnableGunCursor", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugGiveAllGadgets
    /// </summary>
    public unsafe void DebugGiveAllGadgets()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerJoker.DebugGiveAllGadgets", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetGunOut
    /// </summary>
    public unsafe void GetGunOut()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerJoker.GetGunOut", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerJoker.Tick", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetJokerSickVector
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor GetJokerSickVector()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerJoker.GetJokerSickVector", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: UpdateSickMaterials
    /// </summary>
    public unsafe void UpdateSickMaterials()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerJoker.UpdateSickMaterials", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AllowScreenShakeOnShot
    /// </summary>
    public unsafe bool AllowScreenShakeOnShot()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerJoker.AllowScreenShakeOnShot", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerJoker.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: EJokerGadgetList
    /// </summary>
    public enum EJokerGadgetList
    {
        JGL_JokerGun = 0,
        JGL_MAX = 1,
    }

    /// <summary>
    /// BoolProperty: bDoingSurprise
    /// </summary>
    public unsafe bool bDoingSurprise
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10060) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10060); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10060); }
    }

    /// <summary>
    /// BoolProperty: bHasLockedHud
    /// </summary>
    public unsafe bool bHasLockedHud
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10060) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10060); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10060); }
    }

    /// <summary>
    /// ObjectProperty: SurpriseVolume
    /// </summary>
    public unsafe BmSDK.Engine.Volume SurpriseVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 10064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10064); }
    }

    /// <summary>
    /// ObjectProperty: GunStep1
    /// </summary>
    public unsafe BmSDK.BmGame.REnvironmentSpecialMoveWrapper GunStep1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentSpecialMoveWrapper>(Ptr + 10072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10072); }
    }

    /// <summary>
    /// ObjectProperty: GunStep2
    /// </summary>
    public unsafe BmSDK.BmGame.REnvironmentSpecialMoveWrapper GunStep2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentSpecialMoveWrapper>(Ptr + 10080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10080); }
    }

    /// <summary>
    /// StructProperty: CurrentSurpriseTestPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 CurrentSurpriseTestPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 10088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10088); }
    }
}
