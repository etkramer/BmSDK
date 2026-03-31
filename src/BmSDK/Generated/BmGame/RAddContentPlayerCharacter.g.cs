#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAddContentPlayerCharacter<br/>
/// (size = 324)
/// (flags = 134217874)
/// </summary>
public partial class RAddContentPlayerCharacter : BmSDK.BmGame.RAdditionalContent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAddContentPlayerCharacter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAddContentPlayerCharacter() { }

    /// <summary>
    /// Constructs a new RAddContentPlayerCharacter
    /// </summary>
    public RAddContentPlayerCharacter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAddContentPlayerCharacter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAddContentPlayerCharacter(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAddContentPlayerCharacter>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAddContentPlayerCharacter>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAddContentPlayerCharacter>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAddContentPlayerCharacter>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAddContentPlayerCharacter>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAddContentPlayerCharacter>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RAddContentPlayerCharacter>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RAddContentPlayerCharacter>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: HUD
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie HUD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// ObjectProperty: HealthHUD
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie HealthHUD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// ObjectProperty: StoryModeHUD
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie StoryModeHUD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// ObjectProperty: GadgetsHUD
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie GadgetsHUD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// ObjectProperty: TargetsHUD
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie TargetsHUD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// ObjectProperty: SpecialForensicsHud
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie SpecialForensicsHud
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// ClassProperty: PlayerClass
    /// </summary>
    public unsafe BmSDK.Class PlayerClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// ObjectProperty: JammedDetectiveModeHUD
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie JammedDetectiveModeHUD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// NameProperty: GadgetsConsoleInner
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleInner_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleInner
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleInner_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleInner
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleInner_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleInner
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleInner_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleInner
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleInner_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleInner
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleInner_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleInner
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleInner_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleInner
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleInner_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// NameProperty: GadgetsConsoleOuter
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOuter_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOuter
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOuter_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOuter
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOuter_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOuter
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOuter_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOuter
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOuter_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOuter
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOuter_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOuter
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOuter_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }
    /// <summary>
    /// NameProperty: GadgetsConsoleOuter
    /// </summary>
    public unsafe BmSDK.FName GadgetsConsoleOuter_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// NameProperty: GadgetsPC
    /// </summary>
    public unsafe BmSDK.FName GadgetsPC_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }
    /// <summary>
    /// NameProperty: GadgetsPC
    /// </summary>
    public unsafe BmSDK.FName GadgetsPC_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }
    /// <summary>
    /// NameProperty: GadgetsPC
    /// </summary>
    public unsafe BmSDK.FName GadgetsPC_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }
    /// <summary>
    /// NameProperty: GadgetsPC
    /// </summary>
    public unsafe BmSDK.FName GadgetsPC_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }
    /// <summary>
    /// NameProperty: GadgetsPC
    /// </summary>
    public unsafe BmSDK.FName GadgetsPC_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }
    /// <summary>
    /// NameProperty: GadgetsPC
    /// </summary>
    public unsafe BmSDK.FName GadgetsPC_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }
    /// <summary>
    /// NameProperty: GadgetsPC
    /// </summary>
    public unsafe BmSDK.FName GadgetsPC_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }
    /// <summary>
    /// NameProperty: GadgetsPC
    /// </summary>
    public unsafe BmSDK.FName GadgetsPC_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }
    /// <summary>
    /// NameProperty: GadgetsPC
    /// </summary>
    public unsafe BmSDK.FName GadgetsPC_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }
    /// <summary>
    /// NameProperty: GadgetsPC
    /// </summary>
    public unsafe BmSDK.FName GadgetsPC_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }
    /// <summary>
    /// NameProperty: GadgetsPC
    /// </summary>
    public unsafe BmSDK.FName GadgetsPC_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }
    /// <summary>
    /// NameProperty: GadgetsPC
    /// </summary>
    public unsafe BmSDK.FName GadgetsPC_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// StrProperty: CharacterAcronym
    /// </summary>
    public unsafe BmSDK.FString CharacterAcronym
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// ObjectProperty: AudioStateSwitch
    /// </summary>
    public unsafe BmSDK.Engine.AkStateName AudioStateSwitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkStateName>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// IntProperty: ReferenceCount
    /// </summary>
    public unsafe int ReferenceCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }
}
