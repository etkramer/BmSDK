namespace BmSDK;

public static class GameOffsets
{
    public static class GlobalOffsets
    {
        public const IntPtr GNames = 0x2231BB4;
        public const IntPtr GObjObjects = 0x2231BE4;
        public const IntPtr GError = 0x021F66E8;
    }

    public static class FuncOffsets
    {
        public const IntPtr ProcessEvent = 0x1A7040;
        public const IntPtr AddObject = 0x1D4080;
        public const IntPtr ObjectDtor = 0x1D30B0;

        public const IntPtr StaticFindObject = 0x1D88C0;
        public const IntPtr StaticConstructObject = 0x1E44E0;
        public const IntPtr GetDefaultObject = 0x172B3B;

        public const IntPtr NameInit = 0x1D24F0;
    }

    public static class MemberOffsets
    {
        public const IntPtr Object__ObjectInternalInteger = 0x4;
        public const IntPtr Object__Outer = 0x1C;
        public const IntPtr Object__Name = 0x20;
        public const IntPtr Object__Class = 0x28;
    }
}
