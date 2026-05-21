#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBatmobileRemote<br/>
/// (size = 2328)
/// (flags = 144703666)
/// </summary>
public partial class RBatmobileRemote : BmSDK.BmGame.RInventoryGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBatmobileRemote", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBatmobileRemote.
    /// </summary>
    public static RBatmobileRemote DefaultObject => (RBatmobileRemote)StaticClass().DefaultObject;

    internal RBatmobileRemote() { }

    /// <summary>
    /// Constructs a new RBatmobileRemote
    /// </summary>
    public RBatmobileRemote(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBatmobileRemote(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileRemote>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileRemote>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileRemote>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileRemote>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileRemote>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileRemote>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileRemote>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileRemote>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: NotifyReachedHardRemoteLimit
    /// </summary>
    public unsafe virtual void NotifyReachedHardRemoteLimit()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBatmobileRemote.NotifyReachedHardRemoteLimit", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetAutoTargetRotation
    /// </summary>
    public unsafe override BmSDK.Rotator GetAutoTargetRotation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBatmobileRemote.GetAutoTargetRotation", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: NotifyRemoteDriveCancelled
    /// </summary>
    public unsafe virtual void NotifyRemoteDriveCancelled()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBatmobileRemote.NotifyRemoteDriveCancelled", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyCallBatmobileToMe
    /// </summary>
    public unsafe virtual void NotifyCallBatmobileToMe()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBatmobileRemote.NotifyCallBatmobileToMe", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyBatmanPickedUp
    /// </summary>
    public unsafe virtual void NotifyBatmanPickedUp()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBatmobileRemote.NotifyBatmanPickedUp", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// BoolProperty: bUseBehindBack
    /// </summary>
    public unsafe bool bUseBehindBack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2068); }
    }

    /// <summary>
    /// StructProperty: ForcedBackUseRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator ForcedBackUseRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2072);

    /// <summary>
    /// StructProperty: AimPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AimPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2084);

    /// <summary>
    /// StructProperty: AimVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AimVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2096);

    /// <summary>
    /// StructProperty: WorldAimPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WorldAimPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2108);

    /// <summary>
    /// InlineArray{StructProperty}: ThrowDirectionTypes
    /// </summary>
    public InlineArray<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer> ThrowDirectionTypes => new(13, Ptr + 2120);

    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 2120);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 2136);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 2152);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 2168);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 2184);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 2200);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 2216);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 2232);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 2248);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_9
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 2264);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_10
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 2280);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_11
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 2296);
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer ThrowDirectionTypes_12
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBatarang.FBatarangThrowDirectionsContainer>(Ptr + 2312);
}
