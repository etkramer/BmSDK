#pragma once

class GameOffsets
{
private:
	GameOffsets() = delete;

public:
	// Globals
	static const uintptr_t GObjects = 0x2231BE4;
	static const uintptr_t GNames = 0x2231BB4;

	// Functions
	static const uintptr_t UObject_ProcessEvent = 0x1A7040;
};
