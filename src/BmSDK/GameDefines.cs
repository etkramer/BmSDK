using System;

namespace BmSDK;

public static class GameDefines
{
    public static class GlobalOffsets
    {
        public const IntPtr GNames = 0x2231BB4;
        public const IntPtr GObjObjects = 0x2231BE4;
    }

    public static class FuncOffsets
    {
        public const IntPtr ProcessEvent = 0x1A7040;
    }

    public static class MemberOffsets
    {
        public const IntPtr Object__Name = 0x20;
        public const IntPtr Object__Class = 0x28;
    }
}
