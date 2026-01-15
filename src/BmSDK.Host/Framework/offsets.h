#pragma once

#include <cstdint>

namespace offsets {
	inline uintptr_t BaseAddress = 0;
#if BATMAN2
	inline constexpr uintptr_t EngineLoopPreInit = 0x7DB210;
#elif BATMAN3
	// TODO: Add EngineLoopPreInit offset for AO
	inline constexpr uintptr_t EngineLoopPreInit =
#endif
}
