#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RParticleModuleSpawnOnDeath<br/>
/// (size = 104)
/// (flags = 0)
/// </summary>
public partial class RParticleModuleSpawnOnDeath : BmSDK.BmGame.RParticleModuleOnDeathBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RParticleModuleSpawnOnDeath", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RParticleModuleSpawnOnDeath() { }

    /// <summary>
    /// Constructs a new RParticleModuleSpawnOnDeath
    /// </summary>
    public RParticleModuleSpawnOnDeath(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RParticleModuleSpawnOnDeath Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RParticleModuleSpawnOnDeath(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: SpawnParticles
    /// </summary>
    public unsafe void SpawnParticles(BmSDK.Engine.Actor OwningActor, System.Numerics.Vector3 Position)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RParticleModuleSpawnOnDeath.SpawnParticles", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OwningActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: ParticleEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ParticleEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
}
