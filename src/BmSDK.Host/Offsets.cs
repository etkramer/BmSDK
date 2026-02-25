namespace BmSDK.Host;

static class Offsets
{
    public static nuint BaseAddress;

#if BATMAN2
    public const nuint EngineLoopPreInit = 0x7DB210;
#elif BATMAN3
    // TODO: Add EngineLoopPreInit offset for AO
    public const nuint EngineLoopPreInit = 0;
#endif
}
