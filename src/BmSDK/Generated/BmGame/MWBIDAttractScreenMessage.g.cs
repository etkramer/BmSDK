#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MWBIDAttractScreenMessage<br/>
/// (size = 92)
/// (flags = 134217874)
/// </summary>
public partial class MWBIDAttractScreenMessage : BmSDK.BmGame.MWBIDDataMessage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MWBIDAttractScreenMessage", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MWBIDAttractScreenMessage() { }

    /// <summary>
    /// Constructs a new MWBIDAttractScreenMessage
    /// </summary>
    public MWBIDAttractScreenMessage(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MWBIDAttractScreenMessage Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MWBIDAttractScreenMessage(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: Flush
    /// </summary>
    public unsafe override void Flush()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MWBIDAttractScreenMessage.Flush", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe override void Init()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.MWBIDAttractScreenMessage.Init", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: ButtonGroup_Create
    /// </summary>
    public enum ButtonGroup_Create
    {
        BGC_Create = 0,
        BGC_Link = 1,
        BGC_Cancel = 2,
        BGC_Ignore = 3,
        BGC_MAX = 4,
    }
}
