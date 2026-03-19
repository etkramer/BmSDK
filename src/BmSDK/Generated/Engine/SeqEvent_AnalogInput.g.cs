#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqEvent_AnalogInput<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqEvent_AnalogInput : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqEvent_AnalogInput", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqEvent_AnalogInput() { }

    /// <summary>
    /// Constructs a new SeqEvent_AnalogInput
    /// </summary>
    public SeqEvent_AnalogInput(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqEvent_AnalogInput Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqEvent_AnalogInput(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bTrapInput
    /// </summary>
    public unsafe bool bTrapInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 380); }
    }

    /// <summary>
    /// IntProperty: AllowedPlayerIndex
    /// </summary>
    public unsafe int AllowedPlayerIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ArrayProperty: InputNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> InputNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }
}
