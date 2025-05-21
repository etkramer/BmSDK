namespace BmSDK;

public static class GameInfo
{
    public static class GlobalOffsets
    {
        public const IntPtr GNames = 0x11EC5E8;
        public const IntPtr GObjObjects = 0x122E900;
        public const IntPtr GError = 0x117BF48;
    }

    public static class FuncOffsets
    {
        // UObject (static)
        public const IntPtr StaticFindObject = 0x1D88C0; // TODO: Update for BM2
        public const IntPtr StaticConstructObject = 0x98BE0;
        public const IntPtr LoadPackage = 0x1EB6C0; // TODO: Update for BM2

        // UObject (local)
        public const IntPtr ProcessEvent = 0x20C8B0;
        public const IntPtr AddObject = 0x1D4080; // TODO: Update for BM2
        public const IntPtr ObjectDtor = 0x1D30B0; // TODO: Update for BM2
        public const IntPtr FindFunction = 0x1D7C50; // TODO: Update for BM2

        // FName (local)
        public const IntPtr NameInit = 0x1D24F0; // TODO: Update for BM2

        // FString (local)
        public const IntPtr StringCtor = 0x4650;
    }

    public static class MemberOffsets
    {
        public const IntPtr Object__ObjectInternalInteger = 0x4;
        public const IntPtr Object__Outer = 0x1C;
        public const IntPtr Object__Name = 0x20;
        public const IntPtr Object__Class = 0x28;
    }
}
