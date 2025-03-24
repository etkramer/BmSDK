namespace BmSDK;

public static class GameInfo
{
    public static class GlobalOffsets
    {
        public const IntPtr GNames = 0x2231BB4;
        public const IntPtr GObjObjects = 0x2231BE4;
    }

    public static class FuncOffsets
    {
        public const IntPtr ProcessEvent = 0x1A7040;
        public const IntPtr AddObject = 0x1D4080;
        public const IntPtr ObjectDtor = 0x1D30B0;

        public const IntPtr StaticFindObject = 0x1D88C0;
        public const IntPtr GetDefaultObject = 0x172B3B;
    }

    public static class MemberOffsets
    {
        public const IntPtr Object__ObjectInternalInteger = 0x4;
        public const IntPtr Object__Outer = 0x1C;
        public const IntPtr Object__Name = 0x20;
        public const IntPtr Object__Class = 0x28;
    }
}
