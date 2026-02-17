#pragma once

#include <string>
#include <ostream>

class XmlCommentHelper
{
  public:
    // Escapes special XML characters: &, <, >
    static std::string EscapeXml(const std::string& text);

    // Prints a multiline comment as XML summary lines (each line prefixed with "/// ")
    // Handles \n in the input text by splitting into multiple lines
    static void PrintSummaryLines(const std::string& comment, std::ostream& out, int indentLevel);

    // Prints a <param> element
    static void PrintParam(const std::string& paramName, const std::string& description, std::ostream& out,
                           int indentLevel);

  private:
    static void PrintIndent(std::ostream& out, int indentLevel);
};
