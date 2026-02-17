#pragma once

#include <optional>
#include <string>
#include <map>

struct PropertyDoc
{
    std::string comment;
};

struct FunctionDoc
{
    std::string comment;
    std::map<std::string, std::string> params; // paramName -> description
};

struct StructDoc
{
    std::string comment;
    std::map<std::string, PropertyDoc> properties;
};

struct ClassDoc
{
    std::string comment;
    std::map<std::string, PropertyDoc> properties;
    std::map<std::string, FunctionDoc> functions;
    std::map<std::string, StructDoc> structs;
};

class DocProvider
{
  private:
    DocProvider() = delete;
    static bool initialized;
    static std::map<std::string, std::map<std::string, ClassDoc>> docData; // packageName -> className -> ClassDoc

  public:
    // Initialize by loading and parsing api-reference.json
    static bool Initialize(const std::string& jsonPath);

    // Lookup methods - return empty optional if not found
    static std::optional<std::string> GetClassComment(const std::string& packageName,
                                                      const std::string& className);

    static std::optional<std::string> GetPropertyComment(const std::string& packageName,
                                                         const std::string& className,
                                                         const std::string& propertyName);

    static std::optional<FunctionDoc> GetFunctionDoc(const std::string& packageName,
                                                     const std::string& className,
                                                     const std::string& functionName);

    static std::optional<std::string> GetStructComment(const std::string& packageName,
                                                       const std::string& className,
                                                       const std::string& structName);

    static std::optional<std::string> GetStructPropertyComment(const std::string& packageName,
                                                               const std::string& className,
                                                               const std::string& structName,
                                                               const std::string& propertyName);
};
