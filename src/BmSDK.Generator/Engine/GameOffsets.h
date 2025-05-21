#pragma once

class GameOffsets
{
private:
	GameOffsets() = delete;

public:
	// Globals
	static const uintptr_t GObjects = 0x122E900;
	static const uintptr_t GNames = 0x11EC5E8;

	// Functions
	static const uintptr_t UObject_ProcessEvent = 0x20C8B0;
};
