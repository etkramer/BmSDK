#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimNotify_Footstep<br/>
/// (size = 47)
/// (flags = 134230162)
/// </summary>
public partial class RAnimNotify_Footstep : BmSDK.Engine.AnimNotify, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimNotify_Footstep", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimNotify_Footstep() { }

    /// <summary>
    /// Constructs a new RAnimNotify_Footstep
    /// </summary>
    public RAnimNotify_Footstep(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimNotify_Footstep Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimNotify_Footstep(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimNotify_Footstep>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimNotify_Footstep>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimNotify_Footstep>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimNotify_Footstep>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimNotify_Footstep>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimNotify_Footstep>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAnimNotify_Footstep>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAnimNotify_Footstep>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// ByteProperty: Foot
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNotify_Footstep.EFoot Foot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNotify_Footstep.EFoot>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// ByteProperty: Contact
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNotify_Footstep.EContactType Contact
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNotify_Footstep.EContactType>(Ptr + 45); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 45); }
    }

    /// <summary>
    /// ByteProperty: SurfaceFinder
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNotify_Footstep.EFootstepSurfaceFinder SurfaceFinder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNotify_Footstep.EFootstepSurfaceFinder>(Ptr + 46); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 46); }
    }

    /// <summary>
    /// Enum: EFootstepSurfaceFinder
    /// </summary>
    public enum EFootstepSurfaceFinder
    {
        FSF_Auto = 0,
        FSF_Floor = 1,
        FSF_Ceiling = 2,
        FSF_Ledge = 3,
        FSF_Forward = 4,
        FSF_MAX = 5,
    }

    /// <summary>
    /// Enum: EContactType
    /// </summary>
    public enum EContactType
    {
        Contact_Normal = 0,
        Contact_Land = 1,
        Contact_Jump = 2,
        Contact_Turn180A = 3,
        Contact_Turn180B = 4,
        Contact_Turn180C = 5,
        Contact_Turn180D = 6,
        Contact_Turn90A = 7,
        Contact_Turn90B = 8,
        Contact_Turn45A = 9,
        Contact_Turn45B = 10,
        Contact_TurnCoverA = 11,
        Contact_TurnCoverB = 12,
        Contact_TurnCoverC = 13,
        Contact_TurnRunA = 14,
        Contact_TurnRunB = 15,
        Contact_TurnWalkA = 16,
        Contact_TurnWalkB = 17,
        Contact_SlideStop = 18,
        Contact_WalkBack = 19,
        Contact_HandSlide = 20,
        Contact_Body = 21,
        Contact_MAX = 22,
    }

    /// <summary>
    /// Enum: EFoot
    /// </summary>
    public enum EFoot
    {
        Foot_Left = 0,
        Foot_Right = 1,
        Foot_Both = 2,
        Hand_Left = 3,
        Hand_Right = 4,
        Hand_Both = 5,
        FOOT_Body = 6,
        EFoot_MAX = 7,
    }
}
