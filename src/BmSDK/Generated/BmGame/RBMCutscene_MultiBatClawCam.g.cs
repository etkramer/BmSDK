#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMCutscene_MultiBatClawCam<br/>
/// (size = 180)
/// (flags = 18)
/// </summary>
public partial class RBMCutscene_MultiBatClawCam : BmSDK.BmGame.RBMCutscene_BatClawCam, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMCutscene_MultiBatClawCam", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMCutscene_MultiBatClawCam() { }

    /// <summary>
    /// Constructs a new RBMCutscene_MultiBatClawCam
    /// </summary>
    public RBMCutscene_MultiBatClawCam(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMCutscene_MultiBatClawCam Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMCutscene_MultiBatClawCam(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: CanUseCam
    /// </summary>
    public unsafe static bool CanUseCam(BmSDK.BmGame.RBMCutsceneBase CheckCutscene)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMCutscene_MultiBatClawCam.CanUseCam", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckCutscene, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }
}
