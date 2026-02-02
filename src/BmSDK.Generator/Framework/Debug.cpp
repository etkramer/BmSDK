#include "pch.h"
#include "Debug.h"

static Debug::DebugStream stream;

void Debug::Init()
{
	// Redirect stdout to the debug console
	cout.rdbuf(&stream);
}
