#include "pch.h"
#include "DocProvider.h"

#include <fstream>
#include <nlohmann/json.hpp>

using json = nlohmann::json;

bool DocProvider::initialized = false;
std::map<std::string, std::map<std::string, ClassDoc>> DocProvider::docData;

bool DocProvider::Initialize(const std::string& jsonPath)
{
    if (initialized)
        return true;

    std::ifstream file(jsonPath);
    if (!file.is_open())
    {
        TRACE("DocProvider: Failed to open api-reference.json at: {}", jsonPath);
        return false;
    }

    try
    {
        json root;
        file >> root;

        // Parse the JSON structure: { packageName: { className: { ... } } }
        for (auto& [packageName, packageContent] : root.items())
        {
            std::map<std::string, ClassDoc> packageClasses;

            for (auto& [className, classContent] : packageContent.items())
            {
                ClassDoc classDoc;

                // Parse class comment
                if (classContent.contains("comment") && classContent["comment"].is_string())
                {
                    classDoc.comment = classContent["comment"].get<std::string>();
                }

                // Parse properties
                if (classContent.contains("properties") && classContent["properties"].is_object())
                {
                    for (auto& [propName, propContent] : classContent["properties"].items())
                    {
                        PropertyDoc propDoc;
                        if (propContent.contains("comment") && propContent["comment"].is_string())
                        {
                            propDoc.comment = propContent["comment"].get<std::string>();
                        }
                        classDoc.properties[propName] = propDoc;
                    }
                }

                // Parse functions
                if (classContent.contains("functions") && classContent["functions"].is_object())
                {
                    for (auto& [funcName, funcContent] : classContent["functions"].items())
                    {
                        FunctionDoc funcDoc;
                        if (funcContent.contains("comment") && funcContent["comment"].is_string())
                        {
                            funcDoc.comment = funcContent["comment"].get<std::string>();
                        }
                        if (funcContent.contains("params") && funcContent["params"].is_object())
                        {
                            for (auto& [paramName, paramDesc] : funcContent["params"].items())
                            {
                                if (paramDesc.is_string())
                                {
                                    funcDoc.params[paramName] = paramDesc.get<std::string>();
                                }
                            }
                        }
                        classDoc.functions[funcName] = funcDoc;
                    }
                }

                // Parse structs
                if (classContent.contains("structs") && classContent["structs"].is_object())
                {
                    for (auto& [structName, structContent] : classContent["structs"].items())
                    {
                        StructDoc structDoc;
                        if (structContent.contains("comment") && structContent["comment"].is_string())
                        {
                            structDoc.comment = structContent["comment"].get<std::string>();
                        }
                        if (structContent.contains("properties") && structContent["properties"].is_object())
                        {
                            for (auto& [propName, propContent] : structContent["properties"].items())
                            {
                                PropertyDoc propDoc;
                                if (propContent.contains("comment") && propContent["comment"].is_string())
                                {
                                    propDoc.comment = propContent["comment"].get<std::string>();
                                }
                                structDoc.properties[propName] = propDoc;
                            }
                        }
                        classDoc.structs[structName] = structDoc;
                    }
                }

                packageClasses[className] = classDoc;
            }

            docData[packageName] = packageClasses;
        }

        initialized = true;
        TRACE("DocProvider: Loaded api-reference.json successfully ({} packages)", docData.size());
        return true;
    }
    catch (const json::parse_error& e)
    {
        TRACE("DocProvider: JSON parse error: {}", e.what());
        return false;
    }
    catch (const std::exception& e)
    {
        TRACE("DocProvider: Error loading documentation: {}", e.what());
        return false;
    }
}

std::optional<std::string> DocProvider::GetClassComment(const std::string& packageName,
                                                        const std::string& className)
{
    if (!initialized)
        return std::nullopt;

    auto pkgIt = docData.find(packageName);
    if (pkgIt == docData.end())
        return std::nullopt;

    auto clsIt = pkgIt->second.find(className);
    if (clsIt == pkgIt->second.end())
        return std::nullopt;

    if (clsIt->second.comment.empty())
        return std::nullopt;

    return clsIt->second.comment;
}

std::optional<std::string> DocProvider::GetPropertyComment(const std::string& packageName,
                                                           const std::string& className,
                                                           const std::string& propertyName)
{
    if (!initialized)
        return std::nullopt;

    auto pkgIt = docData.find(packageName);
    if (pkgIt == docData.end())
        return std::nullopt;

    auto clsIt = pkgIt->second.find(className);
    if (clsIt == pkgIt->second.end())
        return std::nullopt;

    auto propIt = clsIt->second.properties.find(propertyName);
    if (propIt == clsIt->second.properties.end())
        return std::nullopt;

    if (propIt->second.comment.empty())
        return std::nullopt;

    return propIt->second.comment;
}

std::optional<FunctionDoc> DocProvider::GetFunctionDoc(const std::string& packageName,
                                                       const std::string& className,
                                                       const std::string& functionName)
{
    if (!initialized)
        return std::nullopt;

    auto pkgIt = docData.find(packageName);
    if (pkgIt == docData.end())
        return std::nullopt;

    auto clsIt = pkgIt->second.find(className);
    if (clsIt == pkgIt->second.end())
        return std::nullopt;

    auto funcIt = clsIt->second.functions.find(functionName);
    if (funcIt == clsIt->second.functions.end())
        return std::nullopt;

    return funcIt->second;
}

std::optional<std::string> DocProvider::GetStructComment(const std::string& packageName,
                                                         const std::string& className,
                                                         const std::string& structName)
{
    if (!initialized)
        return std::nullopt;

    auto pkgIt = docData.find(packageName);
    if (pkgIt == docData.end())
        return std::nullopt;

    auto clsIt = pkgIt->second.find(className);
    if (clsIt == pkgIt->second.end())
        return std::nullopt;

    auto structIt = clsIt->second.structs.find(structName);
    if (structIt == clsIt->second.structs.end())
        return std::nullopt;

    if (structIt->second.comment.empty())
        return std::nullopt;

    return structIt->second.comment;
}

std::optional<std::string> DocProvider::GetStructPropertyComment(const std::string& packageName,
                                                                 const std::string& className,
                                                                 const std::string& structName,
                                                                 const std::string& propertyName)
{
    if (!initialized)
        return std::nullopt;

    auto pkgIt = docData.find(packageName);
    if (pkgIt == docData.end())
        return std::nullopt;

    auto clsIt = pkgIt->second.find(className);
    if (clsIt == pkgIt->second.end())
        return std::nullopt;

    auto structIt = clsIt->second.structs.find(structName);
    if (structIt == clsIt->second.structs.end())
        return std::nullopt;

    auto propIt = structIt->second.properties.find(propertyName);
    if (propIt == structIt->second.properties.end())
        return std::nullopt;

    if (propIt->second.comment.empty())
        return std::nullopt;

    return propIt->second.comment;
}
