#pragma once

class Offsets {
private:
    Offsets() = delete;

public:
    // Globals
    static const uintptr_t GObjects = 0x2231BE4;

    // Functions
	static const uintptr_t UObject_ProcessEvent = 0x1A7040;
};