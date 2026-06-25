#include "pch.h"
#include "GameFunctions.h"
#include "GameOffsets.h"

LoadPackageFn GameFunctions::LoadPackage = 0;
CollectGarbageFn GameFunctions::CollectGarbage = 0;
StaticFindObjectFn GameFunctions::StaticFindObject = 0;

void GameFunctions::Init(uintptr_t baseAddress)
{
    StaticFindObject = (StaticFindObjectFn)(baseAddress + GameOffsets::StaticFindObject);
    LoadPackage = (LoadPackageFn)(baseAddress + GameOffsets::LoadPackage);
    CollectGarbage = (CollectGarbageFn)(baseAddress + GameOffsets::CollectGarbage);
}
