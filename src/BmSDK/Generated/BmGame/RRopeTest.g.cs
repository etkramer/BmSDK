#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRopeTest<br/>
/// (size = 824)
/// (flags = 144704146)
/// </summary>
public partial class RRopeTest : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRopeTest", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RRopeTest.
    /// </summary>
    public static RRopeTest DefaultObject => (RRopeTest)StaticClass().DefaultObject;

    internal RRopeTest() { }

    /// <summary>
    /// Constructs a new RRopeTest
    /// </summary>
    public RRopeTest(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRopeTest(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRopeTest>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRopeTest>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRopeTest>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRopeTest>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRopeTest>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRopeTest>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRopeTest>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRopeTest>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: ConnectActor1
    /// </summary>
    public unsafe BmSDK.Engine.Actor ConnectActor1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: ConnectActor2
    /// </summary>
    public unsafe BmSDK.Engine.Actor ConnectActor2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: ConnectActor3
    /// </summary>
    public unsafe BmSDK.Engine.Actor ConnectActor3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ObjectProperty: Rope
    /// </summary>
    public unsafe BmSDK.BmGame.RRopeBase Rope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRopeBase>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: Rope2
    /// </summary>
    public unsafe BmSDK.BmGame.RRopeBase Rope2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRopeBase>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: StretchTestActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor StretchTestActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: StretchBreakRope
    /// </summary>
    public unsafe BmSDK.BmGame.RRopeBase StretchBreakRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRopeBase>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// StructProperty: AttachPos1
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AttachPos1
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 724);

    /// <summary>
    /// StructProperty: AttachPos2
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AttachPos2
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 736);

    /// <summary>
    /// StructProperty: AttachPos3
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AttachPos3
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 748);

    /// <summary>
    /// FloatProperty: MaxLength1
    /// </summary>
    public unsafe float MaxLength1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// FloatProperty: Length1
    /// </summary>
    public unsafe float Length1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// FloatProperty: ChangeToInstantlyLength
    /// </summary>
    public unsafe float ChangeToInstantlyLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// FloatProperty: GradualChangeLength
    /// </summary>
    public unsafe float GradualChangeLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// FloatProperty: GradualChangeDuration
    /// </summary>
    public unsafe float GradualChangeDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// StructProperty: StretchActorWorldAttachPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StretchActorWorldAttachPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 780);

    /// <summary>
    /// StructProperty: StretchActorActorAttachPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StretchActorActorAttachPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 792);

    /// <summary>
    /// FloatProperty: StretchBreakRatio
    /// </summary>
    public unsafe float StretchBreakRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// FloatProperty: StretchRopeLength
    /// </summary>
    public unsafe float StretchRopeLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// ByteProperty: StretchRopeEnd
    /// </summary>
    public unsafe BmSDK.BmGame.RRopeComponentBase.ERopeEndType StretchRopeEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRopeComponentBase.ERopeEndType>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ByteProperty: CurrentTestState
    /// </summary>
    public unsafe BmSDK.BmGame.RRopeTest.ERopeTestState CurrentTestState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRopeTest.ERopeTestState>(Ptr + 813); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 813); }
    }

    /// <summary>
    /// ByteProperty: WaitForwardState
    /// </summary>
    public unsafe BmSDK.BmGame.RRopeTest.ERopeTestState WaitForwardState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRopeTest.ERopeTestState>(Ptr + 814); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 814); }
    }

    /// <summary>
    /// FloatProperty: waitDuration
    /// </summary>
    public unsafe float waitDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// FloatProperty: StateWaitDuration
    /// </summary>
    public unsafe float StateWaitDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// Enum: ERopeTestState
    /// </summary>
    public enum ERopeTestState : byte
    {
        ROPETEST_Wait = 0,
        ROPETEST_Initialise = 1,
        ROPETEST_PosOnRope = 2,
        ROPETEST_ChangeLength = 3,
        ROPETEST_GradualChangeLength = 4,
        ROPETEST_ChangeAttachment = 5,
        ROPETEST_SplitRope = 6,
        ROPETEST_JoinRope = 7,
        ROPETEST_DestroyRope = 8,
        ROPETEST_EndState = 9,
        ROPETEST_MAX = 10,
    }
}
