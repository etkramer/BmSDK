#include "pch.h"
#include "ClassGraph.h"
#include "Runtime.h"
#include "Engine/UObject.h"
#include "Engine/UField.h"
#include "Engine/UStruct.h"
#include "Engine/UClass.h"
#include "Engine/UProperty.h"
#include "Engine/UEnum.h"
#include "Engine/UFunction.h"

#include <algorithm>

ClassGraph* ClassGraph::Build()
{
    auto graph = new ClassGraph();

    // Cache the Actor class for derivation checks
    graph->actorClass = UObject::FindClass("Class Engine.Actor");

    // ===== PHASE 1: Register all objects =====
    for (INT i = 0; i < Runtime::GObjects->Num; i++)
    {
        UObject* obj = Runtime::GObjects->ElementAt(i);
        if (!obj)
            continue;

        // Validate object
        if (Runtime::GObjects->ElementAt(obj->Index) != obj)
            continue;

        graph->RegisterObject(obj);
    }

    // ===== PHASE 2: Link outer references and compute paths =====
    for (auto& [ptr, node] : graph->nodes)
    {
        // Link to outer
        if (ptr->Outer)
        {
            node->outerNode = graph->GetNode(ptr->Outer);
        }

        // Compute paths by walking outer chain ONCE
        graph->ComputePathsForNode(node.get());
    }

    // ===== PHASE 3: Compute inheritance chains for structs =====
    for (auto& [ptr, node] : graph->nodes)
    {
        if (auto structNode = dynamic_cast<StructNode*>(node.get()))
        {
            graph->ComputeInheritanceForNode(structNode);
        }
    }

    // ===== PHASE 4: Compute managed names =====
    for (auto& [ptr, node] : graph->nodes)
    {
        if (auto fieldNode = dynamic_cast<FieldNode*>(node.get()))
        {
            graph->ComputeManagedNameForNode(fieldNode);
        }
    }

    // ===== PHASE 5: Compute children and duplicate indices =====
    for (auto& [ptr, node] : graph->nodes)
    {
        if (auto structNode = dynamic_cast<StructNode*>(node.get()))
        {
            graph->ComputeChildrenForNode(structNode);
        }
    }

    // ===== PHASE 6: Compute managed path names (after children/duplicates) =====
    for (auto& [ptr, node] : graph->nodes)
    {
        if (auto fieldNode = dynamic_cast<FieldNode*>(node.get()))
        {
            if (ptr->IsA(UClass::StaticClass()))
            {
                fieldNode->managedPathName = fieldNode->packageNameManaged + "." + fieldNode->managedName;
            }
            else if (fieldNode->outerNode)
            {
                auto outerField = dynamic_cast<FieldNode*>(fieldNode->outerNode);
                if (outerField)
                {
                    fieldNode->managedPathName = outerField->managedPathName + "." + fieldNode->managedName;
                }
            }
        }
    }

    // ===== PHASE 7: Compute enum names =====
    for (auto& [ptr, node] : graph->nodes)
    {
        if (auto enumNode = dynamic_cast<EnumNode*>(node.get()))
        {
            graph->ComputeEnumNamesForNode(enumNode);
        }
    }

    // ===== PHASE 8: Compute property types =====
    for (auto& [ptr, node] : graph->nodes)
    {
        if (auto propNode = dynamic_cast<PropertyNode*>(node.get()))
        {
            graph->ComputePropertyTypeForNode(propNode);
        }
    }

    // ===== PHASE 9: Collect all class nodes =====
    for (auto& [ptr, node] : graph->nodes)
    {
        if (auto classNode = dynamic_cast<ClassNode*>(node.get()))
        {
            // Skip Default__Class CDO
            if (ptr->GetName() != "Default__Class")
            {
                graph->allClasses.push_back(classNode);
            }
        }
    }

    return graph;
}

void ClassGraph::RegisterObject(UObject* obj)
{
    unique_ptr<ObjectNode> node;

    if (obj->IsA(UClass::StaticClass()))
    {
        auto classNode = new ClassNode();
        auto uclass = reinterpret_cast<UClass*>(obj);
        classNode->isAbstract = (DWORD)uclass->ClassFlags & (DWORD)EClassFlags::CLASS_Abstract;
        classNode->isIntrinsic = (DWORD)uclass->ClassFlags & (DWORD)EClassFlags::CLASS_Intrinsic;
        node.reset(classNode);
    }
    else if (obj->IsA(UScriptStruct::StaticClass()) || obj->IsA(UFunction::StaticClass()))
    {
        node = make_unique<StructNode>();
    }
    else if (obj->IsA(UEnum::StaticClass()))
    {
        node = make_unique<EnumNode>();
    }
    else if (obj->IsA(UProperty::StaticClass()))
    {
        auto propNode = new PropertyNode();

        // Cache bitmask for bool properties
        if (obj->IsA(UBoolProperty::StaticClass()))
        {
            propNode->bitMask = reinterpret_cast<UBoolProperty*>(obj)->BitMask;
        }

        node.reset(propNode);
    }
    else if (obj->IsA(UField::StaticClass()))
    {
        node = make_unique<FieldNode>();
    }
    else
    {
        node = make_unique<ObjectNode>();
    }

    node->ptr = obj;
    nodes[obj] = std::move(node);
}

void ClassGraph::ComputePathsForNode(ObjectNode* node)
{
    // Build path by walking outer chain once
    vector<string> pathParts;
    UObject* current = node->ptr;

    while (current)
    {
        pathParts.push_back(current->GetName());

        // Check if this is the package
        if (current->Class && current->Class->GetPathName() == "Core.Package")
        {
            node->packageName = current->GetName();
        }

        current = current->Outer;
    }

    // Reverse and join for path name
    reverse(pathParts.begin(), pathParts.end());
    node->pathName = "";
    for (size_t i = 0; i < pathParts.size(); i++)
    {
        if (i > 0)
            node->pathName += ".";
        node->pathName += pathParts[i];
    }

    // Compute managed package name
    if (node->packageName == "Core")
    {
        node->packageNameManaged = "BmSDK";
    }
    else if (!node->packageName.empty())
    {
        node->packageNameManaged = "BmSDK." + node->packageName;
    }
}

void ClassGraph::ComputeInheritanceForNode(StructNode* node)
{
    auto _struct = reinterpret_cast<UStruct*>(node->ptr);

    // Walk SuperStruct chain once, store in vector
    UStruct* current = _struct;
    while (current)
    {
        auto superNode = dynamic_cast<StructNode*>(GetNode(current));
        if (superNode)
        {
            node->superChain.push_back(superNode);
        }
        node->supers.insert(current);
        current = current->SuperStruct;
    }

    // Pre-compute Actor derivation
    if (actorClass)
    {
        node->isActor = node->supers.contains(reinterpret_cast<UStruct*>(actorClass));
    }
}

void ClassGraph::ComputeManagedNameForNode(FieldNode* node)
{
    auto field = reinterpret_cast<UField*>(node->ptr);

    // Special renames to avoid conflicts with System namespace
    if (node->pathName == "Core.Object")
    {
        node->managedName = "GameObject";
        return;
    }
    else if (node->pathName == "Core.System")
    {
        node->managedName = "_System";
        return;
    }
    else if (node->pathName == "Engine.Console")
    {
        node->managedName = "_Console";
        return;
    }

    // Prefix structs with F
    if (field->IsA(UScriptStruct::StaticClass()))
    {
        node->managedName = "F" + field->GetName();
        return;
    }

    // Workaround fields with same name as their outer
    if (field->Outer && field->GetName() == field->Outer->GetName())
    {
        node->managedName = "_" + field->GetName();
        return;
    }

    // Default: use the field name
    node->managedName = field->GetName();
}

void ClassGraph::ComputeChildrenForNode(StructNode* parentNode)
{
    auto parent = reinterpret_cast<UStruct*>(parentNode->ptr);

    // Build children vector and compute duplicates in one pass
    unordered_map<string, int> nameCounts;

    for (UField* child = parent->Children; child; child = child->Next)
    {
        auto childNode = dynamic_cast<FieldNode*>(GetNode(child));
        if (!childNode)
            continue;

        parentNode->children.push_back(childNode);

        // Only count duplicates for properties in functions/structs
        if (child->IsA(UProperty::StaticClass()) &&
            (parent->IsA(UFunction::StaticClass()) || parent->IsA(UScriptStruct::StaticClass())))
        {
            string name = child->GetName();
            int count = nameCounts[name];
            nameCounts[name] = count + 1;

            if (count > 0)
            {
                childNode->duplicateIndex = count;
                childNode->managedName = name + "_" + to_string(count);
            }
        }
    }
}

void ClassGraph::ComputeEnumNamesForNode(EnumNode* node)
{
    auto _enum = reinterpret_cast<UEnum*>(node->ptr);

    // De-duplicate enum names
    unordered_map<string, int> enumNameFreqs;

    for (auto i = 0; i < _enum->Names.Num; i++)
    {
        auto nameStr = _enum->Names.ElementAt(i).ToString();

        if (enumNameFreqs.find(nameStr) == enumNameFreqs.end())
        {
            enumNameFreqs[nameStr] = 1;
            node->resolvedNames.push_back(nameStr);
        }
        else
        {
            enumNameFreqs[nameStr]++;
            node->resolvedNames.push_back(nameStr + "_" + to_string(enumNameFreqs[nameStr]));
        }
    }
}

void ClassGraph::ComputePropertyTypeForNode(PropertyNode* node)
{
    auto prop = reinterpret_cast<UProperty*>(node->ptr);
    string classPath = prop->Class->GetPathName();

    // Map class path to PropertyKind
    static unordered_map<string, PropertyKind> kindMap = {
        {"Core.IntProperty", PropertyKind::Int},
        {"Core.ByteProperty", PropertyKind::Byte},
        {"Core.FloatProperty", PropertyKind::Float},
        {"Core.BoolProperty", PropertyKind::Bool},
        {"Core.StrProperty", PropertyKind::String},
        {"Core.StringProperty", PropertyKind::String},
        {"Core.NameProperty", PropertyKind::Name},
        {"Core.StructProperty", PropertyKind::Struct},
        {"Core.ObjectProperty", PropertyKind::Object},
        {"Core.ComponentProperty", PropertyKind::Component},
        {"Core.ClassProperty", PropertyKind::Class},
        {"Core.InterfaceProperty", PropertyKind::Interface},
        {"Core.ArrayProperty", PropertyKind::Array},
        {"Core.MapProperty", PropertyKind::Map},
        {"Core.DelegateProperty", PropertyKind::Delegate}};

    auto it = kindMap.find(classPath);
    node->kind = (it != kindMap.end()) ? it->second : PropertyKind::Unknown;

    // Link related nodes
    switch (node->kind)
    {
    case PropertyKind::Byte: {
        auto byteProp = reinterpret_cast<UByteProperty*>(prop);
        if (byteProp->Enum)
        {
            node->enumNode = dynamic_cast<EnumNode*>(GetNode(byteProp->Enum));
        }
        break;
    }
    case PropertyKind::Struct: {
        auto structProp = reinterpret_cast<UStructProperty*>(prop);
        node->structNode = dynamic_cast<StructNode*>(GetNode(structProp->Struct));
        break;
    }
    case PropertyKind::Object:
    case PropertyKind::Component:
    case PropertyKind::Class:
    case PropertyKind::Interface: {
        auto objProp = reinterpret_cast<UObjectProperty*>(prop);
        node->propertyClassNode = dynamic_cast<ClassNode*>(GetNode(objProp->PropertyClass));
        break;
    }
    case PropertyKind::Array: {
        auto arrayProp = reinterpret_cast<UArrayProperty*>(prop);
        node->innerPropertyNode = dynamic_cast<PropertyNode*>(GetNode(arrayProp->Inner));
        break;
    }
    default:
        break;
    }

    // Pre-compute inner type name
    node->innerTypeName = ComputeInnerTypeName(node);
}

string ClassGraph::ComputeInnerTypeName(PropertyNode* node)
{
    // Special case
    if (node->pathName == "Core.Object.ObjectFlags")
    {
        return "BmSDK.GameObject.EObjectFlags";
    }

    switch (node->kind)
    {
    case PropertyKind::Int:
        return "int";

    case PropertyKind::Byte:
        if (node->enumNode)
        {
            return node->enumNode->managedPathName;
        }
        return "byte";

    case PropertyKind::Float:
        return "float";

    case PropertyKind::Bool:
        return "bool";

    case PropertyKind::String:
        return "BmSDK.FString";

    case PropertyKind::Name:
        return "BmSDK.FName";

    case PropertyKind::Struct: {
        if (!node->structNode)
            return "UNKNOWN";

        // Handle special struct mappings
        string structName = node->structNode->ptr->GetName();
        if (structName == "Pointer")
            return "System.IntPtr";
        if (structName == "Double")
            return "double";
        if (structName == "QWord")
            return "ulong";
        if (structName == "Vector")
            return "System.Numerics.Vector3";
        if (structName == "Vector4")
            return "System.Numerics.Vector4";
        if (structName == "Vector2D")
            return "System.Numerics.Vector2";
        if (structName == "Rotator")
            return "BmSDK.Rotator";

        return node->structNode->managedPathName;
    }

    case PropertyKind::Object:
    case PropertyKind::Component:
    case PropertyKind::Class:
    case PropertyKind::Interface:
        if (node->propertyClassNode)
        {
            return node->propertyClassNode->managedPathName;
        }
        return "UNKNOWN";

    case PropertyKind::Array:
        if (node->innerPropertyNode)
        {
            return "BmSDK.TArray<" + node->innerPropertyNode->innerTypeName + ">";
        }
        return "BmSDK.TArray<UNKNOWN>";

    case PropertyKind::Map:
        return "BmSDK.TMap<object, object> /* TODO */";

    case PropertyKind::Delegate:
        return "System.IntPtr";

    default:
        return "UNKNOWN";
    }
}

// O(1) lookups
ObjectNode* ClassGraph::GetNode(UObject* obj) const
{
    auto it = nodes.find(obj);
    return (it != nodes.end()) ? it->second.get() : nullptr;
}

FieldNode* ClassGraph::GetFieldNode(UField* field) const
{
    return dynamic_cast<FieldNode*>(GetNode(field));
}

StructNode* ClassGraph::GetStructNode(UStruct* _struct) const
{
    return dynamic_cast<StructNode*>(GetNode(_struct));
}

ClassNode* ClassGraph::GetClassNode(UClass* _class) const
{
    return dynamic_cast<ClassNode*>(GetNode(_class));
}

PropertyNode* ClassGraph::GetPropertyNode(UProperty* prop) const
{
    return dynamic_cast<PropertyNode*>(GetNode(prop));
}

EnumNode* ClassGraph::GetEnumNode(UEnum* _enum) const
{
    return dynamic_cast<EnumNode*>(GetNode(_enum));
}
