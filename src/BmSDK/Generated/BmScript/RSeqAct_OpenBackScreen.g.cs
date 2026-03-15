#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_OpenBackScreen<br/>
/// (size = 244)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_OpenBackScreen : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_OpenBackScreen", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_OpenBackScreen() { }

    /// <summary>
    /// Constructs a new RSeqAct_OpenBackScreen
    /// </summary>
    public RSeqAct_OpenBackScreen(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_OpenBackScreen Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_OpenBackScreen(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_OpenBackScreen.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_OpenBackScreen.Activated", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ByteProperty: _TheScreen
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieBackScreen.BackScreenType _TheScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieBackScreen.BackScreenType>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ByteProperty: Map_ParamType
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_OpenBackScreen.EMapParamType Map_ParamType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_OpenBackScreen.EMapParamType>(Ptr + 205); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 205); }
    }

    /// <summary>
    /// ByteProperty: Map_FilterCharacter
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.EProgressCharacter Map_FilterCharacter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.EProgressCharacter>(Ptr + 206); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 206); }
    }

    /// <summary>
    /// ByteProperty: Progress_Character
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.EProgressCharacter Progress_Character
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.EProgressCharacter>(Ptr + 207); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 207); }
    }

    /// <summary>
    /// ByteProperty: Bio_Character
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.EBioCharacter Bio_Character
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.EBioCharacter>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// ByteProperty: Bio_PageId
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_OpenBackScreen.EBioPageType Bio_PageId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_OpenBackScreen.EBioPageType>(Ptr + 209); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 209); }
    }

    /// <summary>
    /// StrProperty: Map_Script
    /// </summary>
    public unsafe BmSDK.FString Map_Script
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// StrProperty: Map_Objective
    /// </summary>
    public unsafe BmSDK.FString Map_Objective
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// IntProperty: Bio_TapeId
    /// </summary>
    public unsafe int Bio_TapeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// BoolProperty: Bio_bAutoPlay
    /// </summary>
    public unsafe bool Bio_bAutoPlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: ReenablePlayerBackscreenUse
    /// </summary>
    public unsafe bool ReenablePlayerBackscreenUse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// Enum: EBioPageType
    /// </summary>
    public enum EBioPageType
    {
        BioPage_Info = 0,
        BioPage_Bio = 1,
        BioPage_Attributes = 2,
        BioPage_Tapes = 3,
        BioPage_MAX = 4,
    }

    /// <summary>
    /// Enum: EMapParamType
    /// </summary>
    public enum EMapParamType
    {
        EMPT_None = 0,
        EMPT_Script = 1,
        EMPT_Filter = 2,
        EMPT_Objective = 3,
        EMPT_MAX = 4,
    }
}
