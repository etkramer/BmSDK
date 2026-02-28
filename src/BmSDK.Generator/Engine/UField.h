#pragma once

#include "UObject.h"

CLASS(UField, 48)
class UField : public UObject
{
    FIELD(UField*, Next)

public:
    STATIC_CLASS("Core.Field")
};

CHECK_CLASS(UField)
