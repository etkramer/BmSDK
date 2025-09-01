#pragma once

class GameOffsets
{
private:
	GameOffsets() = delete;

public:
	// Globals
#if BATMAN2
	static const uintptr_t GObjects = 0x122E900;
	static const uintptr_t GNames = 0x11EC5E8;
#elif BATMAN3
	static const uintptr_t GObjects = 0x14B1ACC;
	static const uintptr_t GNames = 0x14B1A98;
#endif
};
