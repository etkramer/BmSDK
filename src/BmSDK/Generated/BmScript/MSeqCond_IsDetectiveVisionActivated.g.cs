#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MSeqCond_IsDetectiveVisionActivated<br/>
/// (size = 324)
/// (flags = 0)
/// </summary>
public partial class MSeqCond_IsDetectiveVisionActivated : BmSDK.Engine.SequenceCondition, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MSeqCond_IsDetectiveVisionActivated", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MSeqCond_IsDetectiveVisionActivated() { }

    /// <summary>
    /// Constructs a new MSeqCond_IsDetectiveVisionActivated
    /// </summary>
    public MSeqCond_IsDetectiveVisionActivated(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MSeqCond_IsDetectiveVisionActivated Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MSeqCond_IsDetectiveVisionActivated(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.MSeqCond_IsDetectiveVisionActivated.Activated", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }
}
