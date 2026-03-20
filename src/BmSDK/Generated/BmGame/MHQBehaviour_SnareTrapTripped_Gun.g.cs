#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MHQBehaviour_SnareTrapTripped_Gun<br/>
/// (size = 636)
/// (flags = 8210)
/// </summary>
public partial class MHQBehaviour_SnareTrapTripped_Gun : BmSDK.BmGame.MHQBehaviour_SnareTrapTripped, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MHQBehaviour_SnareTrapTripped_Gun", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MHQBehaviour_SnareTrapTripped_Gun() { }

    /// <summary>
    /// Constructs a new MHQBehaviour_SnareTrapTripped_Gun
    /// </summary>
    public MHQBehaviour_SnareTrapTripped_Gun(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MHQBehaviour_SnareTrapTripped_Gun Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MHQBehaviour_SnareTrapTripped_Gun(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: AwareOfPlayer
    /// </summary>
    public unsafe bool AwareOfPlayer(BmSDK.Engine.Actor Player, BmSDK.Class TestDmgType = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHQBehaviour_SnareTrapTripped_Gun.AwareOfPlayer", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestDmgType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: UnAwareOfPlayer
    /// </summary>
    public unsafe bool UnAwareOfPlayer(BmSDK.Class DamageType = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHQBehaviour_SnareTrapTripped_Gun.UnAwareOfPlayer", true);
        byte* paramsPtr = stackalloc byte[13];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: Initialize
    /// </summary>
    public unsafe void Initialize(BmSDK.BmGame.RPawnPlayer Instigator, BmSDK.BmGame.MSnareTrapProjectile SnareTrap, BmSDK.Engine.AnimSet NewThugReactionAnimSet)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHQBehaviour_SnareTrapTripped_Gun.Initialize", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Instigator, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SnareTrap, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewThugReactionAnimSet, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnDeactivate
    /// </summary>
    public unsafe void OnDeactivate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MHQBehaviour_SnareTrapTripped_Gun.OnDeactivate", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
