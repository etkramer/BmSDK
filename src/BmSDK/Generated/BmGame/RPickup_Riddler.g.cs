#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPickup_Riddler<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPickup_Riddler : BmSDK.BmGame.RPickupBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPickup_Riddler", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPickup_Riddler() { }

    /// <summary>
    /// Constructs a new RPickup_Riddler
    /// </summary>
    public RPickup_Riddler(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPickup_Riddler Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPickup_Riddler(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPickup_Riddler>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPickup_Riddler>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPickup_Riddler>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPickup_Riddler>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPickup_Riddler>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPickup_Riddler>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPickup_Riddler>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ByteProperty: UnlockTape
    /// </summary>
    public unsafe byte UnlockTape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// ByteProperty: UnlockBioCharacter
    /// </summary>
    public unsafe byte UnlockBioCharacter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 801); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 801); }
    }

    /// <summary>
    /// ByteProperty: UnlockShowcaseCharacter
    /// </summary>
    public unsafe byte UnlockShowcaseCharacter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 802); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 802); }
    }

    /// <summary>
    /// ByteProperty: UnlockShowcaseVehicle
    /// </summary>
    public unsafe byte UnlockShowcaseVehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 803); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 803); }
    }

    /// <summary>
    /// ByteProperty: UnlockConceptArt
    /// </summary>
    public unsafe byte UnlockConceptArt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// BoolProperty: bAutoSaveWhenCollected
    /// </summary>
    public unsafe bool bAutoSaveWhenCollected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bHasBeenPickedUp
    /// </summary>
    public unsafe bool bHasBeenPickedUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bIsVoiceSynthPickup
    /// </summary>
    public unsafe bool bIsVoiceSynthPickup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bIsRiddlerRobotPickup
    /// </summary>
    public unsafe bool bIsRiddlerRobotPickup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// ComponentProperty: Light
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Light
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }
}
