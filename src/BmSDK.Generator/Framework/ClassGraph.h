#pragma once

#include "pch.h"
#include <unordered_map>
#include <unordered_set>
#include <memory>

// Forward declarations
class UObject;
class UField;
class UStruct;
class UClass;
class UScriptStruct;
class UProperty;
class UEnum;
class UFunction;

// Property type enum for fast dispatch (eliminates string comparison)
enum class PropertyKind : uint8_t
{
    Unknown,
    Int,
    Byte,
    Float,
    Bool,
    String,
    Name,
    Struct,
    Object,
    Component,
    Class,
    Interface,
    Array,
    Map,
    Delegate
};

// Pre-computed node for any UObject
struct ObjectNode
{
    UObject* ptr = nullptr;

    // Pre-computed path information (eliminates Outer chain walks)
    string pathName;           // "Package.Class.Field"
    string packageName;        // "Engine", "BmGame", etc.
    string packageNameManaged; // "BmSDK.Engine"

    // Parent references (O(1) lookup)
    ObjectNode* outerNode = nullptr;

    virtual ~ObjectNode() = default;
};

// Extended node for UField types (classes, structs, properties, functions, enums)
struct FieldNode : ObjectNode
{
    // Pre-computed managed names (eliminates repeated computation)
    string managedName;     // "GameObject", "_System", "FVector", etc.
    string managedPathName; // "BmSDK.Engine.Actor"

    // Flattened children list (for iteration without Next pointer chasing)
    vector<FieldNode*> children;

    // For properties only: duplicate index (eliminates linear scan)
    int duplicateIndex = 0; // 0 = no duplicate, 1+ = suffix number
};

// Extended node for UStruct types (classes, script structs, functions)
struct StructNode : FieldNode
{
    // Pre-computed inheritance (eliminates SuperStruct walks)
    vector<StructNode*> superChain; // [self, parent, grandparent, ...]

    // All ancestors as set for fast IsA checks
    unordered_set<UStruct*> supers;

    // Pre-computed type checks (O(1) instead of O(depth))
    bool isActor = false; // Cached Engine.Actor check
};

// Extended node for UClass types
struct ClassNode : StructNode
{
    // Class-specific flags cached for convenience
    bool isAbstract = false;
    bool isIntrinsic = false;
};

// Extended node for UEnum types
struct EnumNode : FieldNode
{
    // De-duplicated enum names (computed once)
    vector<string> resolvedNames;
};

// Extended node for UProperty types
struct PropertyNode : FieldNode
{
    PropertyKind kind = PropertyKind::Unknown; // Fast type dispatch
    string innerTypeName;                      // Pre-computed C# type name

    // For ByteProperty with enum
    EnumNode* enumNode = nullptr;

    // For StructProperty
    StructNode* structNode = nullptr;

    // For ObjectProperty/ComponentProperty/ClassProperty/InterfaceProperty
    ClassNode* propertyClassNode = nullptr;

    // For ArrayProperty
    PropertyNode* innerPropertyNode = nullptr;

    // For BoolProperty
    int bitMask = 0;
};

// The main graph container
class ClassGraph
{
public:
    // Build the entire graph from GObjects (single pass)
    static ClassGraph* Build();

    // O(1) lookups
    ObjectNode* GetNode(UObject* obj) const;
    FieldNode* GetFieldNode(UField* field) const;
    StructNode* GetStructNode(UStruct* _struct) const;
    ClassNode* GetClassNode(UClass* _class) const;
    PropertyNode* GetPropertyNode(UProperty* prop) const;
    EnumNode* GetEnumNode(UEnum* _enum) const;

    // Get all classes (for iteration in GenerateSDK)
    const vector<ClassNode*>& GetAllClasses() const { return allClasses; }

private:
    // Node storage (owns the memory)
    unordered_map<UObject*, unique_ptr<ObjectNode>> nodes;

    // Quick access to class nodes
    vector<ClassNode*> allClasses;

    // Cached class pointers for type checking during build
    UClass* actorClass = nullptr;

    // Build helpers (called during single-pass construction)
    void RegisterObject(UObject* obj);
    void ComputePathsForNode(ObjectNode* node);
    void ComputeInheritanceForNode(StructNode* node);
    void ComputeManagedNameForNode(FieldNode* node);
    void ComputeChildrenForNode(StructNode* parentNode);
    void ComputePropertyTypeForNode(PropertyNode* node);
    void ComputeEnumNamesForNode(EnumNode* node);
    string ComputeInnerTypeName(PropertyNode* node);
};
