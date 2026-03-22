#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_ControlMovieTexture<br/>
/// (size = 208)
/// (flags = 8210)
/// </summary>
public partial class SeqAct_ControlMovieTexture : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_ControlMovieTexture", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_ControlMovieTexture() { }

    /// <summary>
    /// Constructs a new SeqAct_ControlMovieTexture
    /// </summary>
    public SeqAct_ControlMovieTexture(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_ControlMovieTexture Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_ControlMovieTexture(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe override void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.SeqAct_ControlMovieTexture.Activated", true);
        byte* paramsPtr = stackalloc byte[5];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: MovieTexture
    /// </summary>
    public unsafe BmSDK.Engine.TextureMovie MovieTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.TextureMovie>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// Enum: EMovieControlType
    /// </summary>
    public enum EMovieControlType
    {
        MCT_Play = 0,
        MCT_Stop = 1,
        MCT_Pause = 2,
        MCT_MAX = 3,
    }
}
