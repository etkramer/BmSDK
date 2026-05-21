#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RockMapHighlight<br/>
/// (size = 1044)
/// (flags = 144704146)
/// </summary>
public partial class RockMapHighlight : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RockMapHighlight", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RockMapHighlight.
    /// </summary>
    public static RockMapHighlight DefaultObject => (RockMapHighlight)StaticClass().DefaultObject;

    internal RockMapHighlight() { }

    /// <summary>
    /// Constructs a new RockMapHighlight
    /// </summary>
    public RockMapHighlight(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RockMapHighlight(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RockMapHighlight>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RockMapHighlight>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RockMapHighlight>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RockMapHighlight>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RockMapHighlight>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RockMapHighlight>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RockMapHighlight>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RockMapHighlight>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: OnToggle
    /// </summary>
    public unsafe virtual void OnToggle(BmSDK.Engine.SeqAct_Toggle Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.RockMapHighlight.OnToggle", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StructProperty: MapHighlightInfo
    /// </summary>
    public unsafe ref BmSDK.Engine.RockMapHighlight.FFMapHighlightInfo MapHighlightInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.RockMapHighlight.FFMapHighlightInfo>(Ptr + 672);

    /// <summary>
    /// ByteProperty: Style
    /// </summary>
    public unsafe BmSDK.Engine.RockMapHighlight.HighlightStyle Style
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockMapHighlight.HighlightStyle>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// ByteProperty: ColorType
    /// </summary>
    public unsafe BmSDK.Engine.RockMapHighlight.HighlightColorType ColorType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockMapHighlight.HighlightColorType>(Ptr + 913); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 913); }
    }

    /// <summary>
    /// BoolProperty: bEnabled
    /// </summary>
    public unsafe bool bEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 916); }
    }

    /// <summary>
    /// StrProperty: MapIconName
    /// </summary>
    public unsafe BmSDK.FString MapIconName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// IntProperty: MapIconRandomOffsetXYInMeters
    /// </summary>
    public unsafe int MapIconRandomOffsetXYInMeters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// StructProperty: ColorAndFadePct
    /// </summary>
    public unsafe ref System.Numerics.Vector4 ColorAndFadePct
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector4>(Ptr + 944);

    /// <summary>
    /// StructProperty: WorldToHighlight
    /// </summary>
    public unsafe ref BmSDK.GameObject.FMatrix WorldToHighlight
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FMatrix>(Ptr + 960);

    /// <summary>
    /// ComponentProperty: StyleBox
    /// </summary>
    public unsafe BmSDK.Engine.DrawVolumeBox StyleBox
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DrawVolumeBox>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// ComponentProperty: StyleMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent StyleMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// FloatProperty: FadeRange
    /// </summary>
    public unsafe float FadeRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// Struct: FFMapHighlightInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 237)]
    public partial record struct FFMapHighlightInfo
    {
        /// <summary>
        /// StructProperty: Bounds
        /// </summary>
        public unsafe BmSDK.GameObject.FBoxSphereBounds Bounds
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FBoxSphereBounds>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: HighlightBoxToUnitCube
        /// </summary>
        public unsafe BmSDK.GameObject.FMatrix HighlightBoxToUnitCube
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMatrix>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StructProperty: UnitCubeToHighlightBox
        /// </summary>
        public unsafe BmSDK.GameObject.FMatrix UnitCubeToHighlightBox
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMatrix>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }

        /// <summary>
        /// StructProperty: BoxBasis
        /// </summary>
        public unsafe BmSDK.GameObject.FMatrix BoxBasis
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMatrix>(Ptr + 160); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }; }
        }

        /// <summary>
        /// StructProperty: BoxCentre
        /// </summary>
        public unsafe System.Numerics.Vector3 BoxCentre
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 224); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }; }
        }

        /// <summary>
        /// ByteProperty: Style
        /// </summary>
        public unsafe BmSDK.Engine.RockMapHighlight.HighlightStyle Style
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockMapHighlight.HighlightStyle>(Ptr + 236); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }; }
        }
    }

    /// <summary>
    /// Enum: HighlightColorType
    /// </summary>
    public enum HighlightColorType : byte
    {
        HSC_Building = 0,
        HSC_FireCrew = 1,
        HSC_ManBat = 2,
        HSC_Azrael = 3,
        HSC_PygVictim = 4,
        HSC_RiddlerBombThug = 5,
        HSC_Cameo = 6,
        HSC_MAX = 7,
    }

    /// <summary>
    /// Enum: HighlightStyle
    /// </summary>
    public enum HighlightStyle : byte
    {
        HS_Mesh = 0,
        HS_Box = 1,
        HS_Sphere = 2,
        HS_MAX = 3,
    }
}
