#pragma once

#include "UState.h"
#include "UProperty.h"

enum class EClassFlags : DWORD
{
    CLASS_Abstract = 0x1,
    CLASS_Intrinsic = 0x10000000,
    CLASS_Interface = 0x00004000,
};

struct FImplementedInterface
{
    UClass* Class;
    UProperty* PointerProperty;
};

class UClass : public UState
{
    // TODO
    FIELD(EClassFlags, ClassFlags)
    BYTE UNK[196];
    FIELD(TArray<FImplementedInterface>, Interfaces)

public:
    STATIC_CLASS("Core.Class")
};
