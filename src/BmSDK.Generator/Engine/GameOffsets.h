#pragma once

class GameOffsets
{
private:
	GameOffsets() = delete;

public:
	// Globals
	static const uintptr_t GObjects = 0x340CBE4;
	static const uintptr_t GNames = 0x3A208B8;
    static const uintptr_t StaticFindObject = 0xF3B7F0;
	static const uintptr_t LoadPackage = 0xF46DA0;
    static const uintptr_t CollectGarbage = 0xF2C280;

	// UObject
	static const uintptr_t ProcessEvent = 0xF90CD0;
};
