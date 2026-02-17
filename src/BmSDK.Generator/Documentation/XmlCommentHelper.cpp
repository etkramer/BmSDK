#include "pch.h"
#include "XmlCommentHelper.h"

#include <sstream>

std::string XmlCommentHelper::EscapeXml(const std::string& text)
{
    std::string result;
    result.reserve(text.size());

    for (char c : text)
    {
        switch (c)
        {
            case '&':
                result += "&amp;";
                break;
            case '<':
                result += "&lt;";
                break;
            case '>':
                result += "&gt;";
                break;
            case '"':
                result += "&quot;";
                break;
            default:
                result += c;
                break;
        }
    }

    return result;
}

void XmlCommentHelper::PrintIndent(std::ostream& out, int indentLevel)
{
    for (int i = 0; i < indentLevel; i++)
    {
        out << "    ";
    }
}

void XmlCommentHelper::PrintSummaryLines(const std::string& comment, std::ostream& out, int indentLevel)
{
    if (comment.empty())
        return;

    std::string escaped = EscapeXml(comment);

    // Split by \n and print each line
    std::istringstream stream(escaped);
    std::string line;
    bool firstLine = true;

    while (std::getline(stream, line))
    {
        // Trim leading whitespace from continuation lines
        if (!firstLine)
        {
            size_t start = line.find_first_not_of(" \t");
            if (start != std::string::npos)
            {
                line = line.substr(start);
            }
            else
            {
                line.clear();
            }
        }

        // Skip empty lines but add a <br/> for paragraph breaks
        if (line.empty())
        {
            PrintIndent(out, indentLevel);
            out << "/// <br/>" << std::endl;
        }
        else
        {
            PrintIndent(out, indentLevel);
            out << "/// " << line << std::endl;
        }

        firstLine = false;
    }
}

void XmlCommentHelper::PrintParam(const std::string& paramName, const std::string& description, std::ostream& out,
                                  int indentLevel)
{
    if (description.empty())
        return;

    std::string escaped = EscapeXml(description);

    // Replace newlines with spaces for param descriptions (keep them single-line)
    for (char& c : escaped)
    {
        if (c == '\n')
            c = ' ';
    }

    PrintIndent(out, indentLevel);
    out << "/// <param name=\"" << paramName << "\">" << escaped << "</param>" << std::endl;
}
