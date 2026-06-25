#pragma once

class GameOffsets
{
private:
    GameOffsets() = delete;

public:
    // Globals
    static const uintptr_t GObjects = 0x122E900;
    static const uintptr_t GNames = 0x11EC5E8;
    static const uintptr_t LoadPackage = 0x9FCA0;
};
