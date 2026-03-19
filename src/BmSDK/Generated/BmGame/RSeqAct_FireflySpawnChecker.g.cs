#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_FireflySpawnChecker<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_FireflySpawnChecker : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_FireflySpawnChecker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_FireflySpawnChecker() { }

    /// <summary>
    /// Constructs a new RSeqAct_FireflySpawnChecker
    /// </summary>
    public RSeqAct_FireflySpawnChecker(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_FireflySpawnChecker Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_FireflySpawnChecker(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: flagSuffixes
    /// </summary>
    public unsafe BmSDK.FString flagSuffixes_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
    /// <summary>
    /// StrProperty: flagSuffixes
    /// </summary>
    public unsafe BmSDK.FString flagSuffixes_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }
    /// <summary>
    /// StrProperty: flagSuffixes
    /// </summary>
    public unsafe BmSDK.FString flagSuffixes_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// IntProperty: encounterIndex
    /// </summary>
    public unsafe int encounterIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

}
