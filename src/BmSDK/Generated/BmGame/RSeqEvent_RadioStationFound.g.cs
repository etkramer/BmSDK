#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_RadioStationFound<br/>
/// (size = 240)
/// (flags = 134217874)
/// </summary>
public partial class RSeqEvent_RadioStationFound : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_RadioStationFound", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_RadioStationFound() { }

    /// <summary>
    /// Constructs a new RSeqEvent_RadioStationFound
    /// </summary>
    public RSeqEvent_RadioStationFound(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_RadioStationFound Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_RadioStationFound(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqEvent_RadioStationFound.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Handle
    /// </summary>
    public unsafe virtual bool Handle(BmSDK.Engine.Actor InOriginator, int typeNo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqEvent_RadioStationFound.Handle", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InOriginator, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(typeNo, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// StrProperty: RadioStationName
    /// </summary>
    public unsafe BmSDK.FString RadioStationName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }
}
