using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace BmSDK.Analyzers;

/// <summary>
/// Analyzer that enforces the relationship between the [Script] attribute and BmSDK.Script inheritance.
/// </summary>
[DiagnosticAnalyzer(LanguageNames.CSharp)]
public class ScriptAttributeAnalyzer : DiagnosticAnalyzer
{
    public const string MissingAttributeDiagnosticId = "BMSDK001";
    public const string MissingInheritanceDiagnosticId = "BMSDK002";

    private static readonly LocalizableString MissingAttributeTitle = 
        "Missing [Script] attribute";
    private static readonly LocalizableString MissingAttributeMessageFormat = 
        "Class '{0}' inherits from Script but is missing the [Script] attribute";
    private static readonly LocalizableString MissingAttributeDescription = 
        "Classes that inherit from BmSDK.Script must have the [Script] attribute.";

    private static readonly LocalizableString MissingInheritanceTitle = 
        "Missing Script inheritance";
    private static readonly LocalizableString MissingInheritanceMessageFormat = 
        "Class '{0}' has [Script] attribute but does not inherit from Script";
    private static readonly LocalizableString MissingInheritanceDescription = 
        "Classes with the [Script] attribute must inherit from BmSDK.Script.";

    private static readonly DiagnosticDescriptor MissingAttributeRule = new(
        MissingAttributeDiagnosticId,
        MissingAttributeTitle,
        MissingAttributeMessageFormat,
        "Usage",
        DiagnosticSeverity.Error,
        isEnabledByDefault: true,
        description: MissingAttributeDescription);

    private static readonly DiagnosticDescriptor MissingInheritanceRule = new(
        MissingInheritanceDiagnosticId,
        MissingInheritanceTitle,
        MissingInheritanceMessageFormat,
        "Usage",
        DiagnosticSeverity.Error,
        isEnabledByDefault: true,
        description: MissingInheritanceDescription);

    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => 
        ImmutableArray.Create(MissingAttributeRule, MissingInheritanceRule);

    public override void Initialize(AnalysisContext context)
    {
        context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
        context.EnableConcurrentExecution();
        context.RegisterSymbolAction(AnalyzeNamedType, SymbolKind.NamedType);
    }

    private static void AnalyzeNamedType(SymbolAnalysisContext context)
    {
        var namedTypeSymbol = (INamedTypeSymbol)context.Symbol;

        // Skip non-class types (interfaces, structs, etc.)
        if (namedTypeSymbol.TypeKind != TypeKind.Class)
        {
            return;
        }

        // Skip abstract classes
        if (namedTypeSymbol.IsAbstract)
        {
            return;
        }

        // Check if the class has [Script] attribute
        var hasScriptAttribute = HasScriptAttribute(namedTypeSymbol);

        // Check if the class inherits from Script
        var inheritsFromScript = InheritsFromScript(namedTypeSymbol, context.Compilation);

        // Case 1: Has [Script] but doesn't inherit from Script
        if (hasScriptAttribute && !inheritsFromScript)
        {
            var diagnostic = Diagnostic.Create(
                MissingInheritanceRule,
                namedTypeSymbol.Locations[0],
                namedTypeSymbol.Name);
            context.ReportDiagnostic(diagnostic);
        }

        // Case 2: Inherits from Script but doesn't have [Script]
        if (!hasScriptAttribute && inheritsFromScript)
        {
            var diagnostic = Diagnostic.Create(
                MissingAttributeRule,
                namedTypeSymbol.Locations[0],
                namedTypeSymbol.Name);
            context.ReportDiagnostic(diagnostic);
        }
    }

    private static bool HasScriptAttribute(INamedTypeSymbol typeSymbol)
    {
        foreach (var attribute in typeSymbol.GetAttributes())
        {
            var attributeClass = attribute.AttributeClass;
            if (attributeClass?.Name == "ScriptAttribute" && 
                attributeClass.ContainingNamespace?.ToString() == "BmSDK.Framework")
            {
                return true;
            }
        }
        return false;
    }

    private static bool InheritsFromScript(INamedTypeSymbol typeSymbol, Compilation compilation)
    {
        // Get the Script base class symbol
        var scriptType = compilation.GetTypeByMetadataName("BmSDK.Framework.Script");
        if (scriptType == null)
        {
            return false;
        }

        // Check if the type inherits from Script
        var currentType = typeSymbol.BaseType;
        while (currentType != null)
        {
            if (SymbolEqualityComparer.Default.Equals(currentType, scriptType))
            {
                return true;
            }
            currentType = currentType.BaseType;
        }

        return false;
    }
}
