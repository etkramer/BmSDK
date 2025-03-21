using System.Xml;

namespace BmSDK.Generator;

partial class ClassGenerator
{
    public static void GenerateProjectFile(Stream stream)
    {
        using var writer = XmlWriter.Create(
            stream,
            new XmlWriterSettings { Indent = true, OmitXmlDeclaration = true }
        );

        // Start document
        writer.WriteStartDocument();

        // <Project>
        writer.WriteStartElement("Project");
        writer.WriteAttributeString("Sdk", "Microsoft.NET.Sdk");
        {
            // <PropertyGroup>
            writer.WriteStartElement("PropertyGroup");
            {
                writer.WriteElementString("TargetFramework", "net9.0");
                writer.WriteElementString("Nullable", "enable");
                writer.WriteElementString("AllowUnsafeBlocks", "true");
            }
            writer.WriteEndElement();
        }
        writer.WriteEndElement();
        
        // End document
        writer.WriteEndDocument();
    }
}
