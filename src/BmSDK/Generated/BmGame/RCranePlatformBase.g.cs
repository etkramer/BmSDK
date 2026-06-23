#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCranePlatformBase<br/>
/// (size = 1132)
/// (flags = 144704146)
/// </summary>
public partial class RCranePlatformBase : BmSDK.Engine.KActorSpawnable, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCranePlatformBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCranePlatformBase.
    /// </summary>
    public static RCranePlatformBase DefaultObject => (RCranePlatformBase)StaticClass().DefaultObject;

    internal RCranePlatformBase() { }

    /// <summary>
    /// Constructs a new RCranePlatformBase
    /// </summary>
    public RCranePlatformBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCranePlatformBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCranePlatformBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCranePlatformBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCranePlatformBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCranePlatformBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCranePlatformBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCranePlatformBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCranePlatformBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCranePlatformBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// InlineArray{StructProperty}: AttachPoint
    /// </summary>
    public InlineArray<System.Numerics.Vector3> AttachPoint => new(4, Ptr + 996, 12, this);

    /// <summary>
    /// StructProperty: AttachPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AttachPoint_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 996);
    /// <summary>
    /// StructProperty: AttachPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AttachPoint_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1008);
    /// <summary>
    /// StructProperty: AttachPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AttachPoint_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1020);
    /// <summary>
    /// StructProperty: AttachPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AttachPoint_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1032);

    /// <summary>
    /// InlineArray{FloatProperty}: AttachPointLength
    /// </summary>
    public InlineArray<float> AttachPointLength => new(4, Ptr + 1044, 4, this);

    /// <summary>
    /// FloatProperty: AttachPointLength
    /// </summary>
    public unsafe float AttachPointLength_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }
    /// <summary>
    /// FloatProperty: AttachPointLength
    /// </summary>
    public unsafe float AttachPointLength_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }
    /// <summary>
    /// FloatProperty: AttachPointLength
    /// </summary>
    public unsafe float AttachPointLength_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }
    /// <summary>
    /// FloatProperty: AttachPointLength
    /// </summary>
    public unsafe float AttachPointLength_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// FloatProperty: LaunchRotOffset
    /// </summary>
    public unsafe float LaunchRotOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// StructProperty: LaunchPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LaunchPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1064);

    /// <summary>
    /// InlineArray{StructProperty}: FloorTestPoints
    /// </summary>
    public InlineArray<System.Numerics.Vector3> FloorTestPoints => new(2, Ptr + 1076, 12, this);

    /// <summary>
    /// StructProperty: FloorTestPoints
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FloorTestPoints_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1076);
    /// <summary>
    /// StructProperty: FloorTestPoints
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FloorTestPoints_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1088);

    /// <summary>
    /// StructProperty: FloorOffsetCheck
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FloorOffsetCheck
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1100);

    /// <summary>
    /// StructProperty: LastTouchNormal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastTouchNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1112);

    /// <summary>
    /// FloatProperty: LastTouchTime
    /// </summary>
    public unsafe float LastTouchTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// FloatProperty: LastFloorTouchTime
    /// </summary>
    public unsafe float LastFloorTouchTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }
}
