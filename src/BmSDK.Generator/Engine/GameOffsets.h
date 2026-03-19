#pragma once

class GameOffsets
{
private:
	GameOffsets() = delete;

public:
	// Globals
	static const uintptr_t GObjects = 0x340CBE4;
	static const uintptr_t GNames = 0x3A208B8;
	// TODO: Update for BM4
	static const uintptr_t LoadPackage = 0x9FCA0;

	// UObject
	static const uintptr_t ProcessEvent = 0xF90CD0;
};
