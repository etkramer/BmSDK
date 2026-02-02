using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Testing;
using Microsoft.CodeAnalysis.Testing;
using Microsoft.CodeAnalysis.Testing.Verifiers;
using BmSDK.Analyzers;

namespace BmSDK.Analyzers.Tests;

public class ScriptAttributeAnalyzerTests
{
    // Helper method to create test with simplified API
    private static async Task VerifyAnalyzerAsync(string testCode, params DiagnosticResult[] expected)
    {
        var test = new CSharpAnalyzerTest<ScriptAttributeAnalyzer, XUnitVerifier>
        {
            TestCode = testCode,
            ReferenceAssemblies = ReferenceAssemblies.Net.Net80,
        };

        // Add the BmSDK framework types as source code since we don't have the compiled assembly
        test.TestState.Sources.Add(@"
namespace BmSDK.Framework
{
    public abstract class Script
    {
        public string Name { get; set; } = ""Script"";
        public virtual void Main() { }
    }

    [System.AttributeUsage(System.AttributeTargets.Class)]
    public sealed class ScriptAttribute : System.Attribute
    {
        public ScriptAttribute(string? name = null) { Name = name; }
        public string? Name { get; }
    }
}
");

        test.ExpectedDiagnostics.AddRange(expected);
        await test.RunAsync();
    }

    [Fact]
    public async Task ValidScript_WithAttributeAndInheritance_NoDiagnostic()
    {
        var testCode = @"
using BmSDK.Framework;

[Script]
public class ValidScript : Script
{
    public override void Main()
    {
    }
}";

        await VerifyAnalyzerAsync(testCode);
    }

    [Fact]
    public async Task Script_WithAttribute_WithoutInheritance_ReportsDiagnostic()
    {
        var testCode = @"
using BmSDK.Framework;

[Script]
public class {|#0:InvalidScript|}
{
    public void Main()
    {
    }
}";

        var expected = new DiagnosticResult(
            ScriptAttributeAnalyzer.MissingInheritanceDiagnosticId,
            DiagnosticSeverity.Error)
            .WithLocation(0)
            .WithArguments("InvalidScript");

        await VerifyAnalyzerAsync(testCode, expected);
    }

    [Fact]
    public async Task Script_WithInheritance_WithoutAttribute_ReportsDiagnostic()
    {
        var testCode = @"
using BmSDK.Framework;

public class {|#0:InvalidScript|} : Script
{
    public override void Main()
    {
    }
}";

        var expected = new DiagnosticResult(
            ScriptAttributeAnalyzer.MissingAttributeDiagnosticId,
            DiagnosticSeverity.Error)
            .WithLocation(0)
            .WithArguments("InvalidScript");

        await VerifyAnalyzerAsync(testCode, expected);
    }

    [Fact]
    public async Task AbstractScript_WithInheritance_WithoutAttribute_NoDiagnostic()
    {
        // Abstract classes are allowed to not have the [Script] attribute
        var testCode = @"
using BmSDK.Framework;

public abstract class BaseScript : Script
{
    public override void Main()
    {
    }
}";

        await VerifyAnalyzerAsync(testCode);
    }

    [Fact]
    public async Task MultipleScripts_WithMixedValidity_ReportsCorrectDiagnostics()
    {
        var testCode = @"
using BmSDK.Framework;

[Script]
public class ValidScript : Script
{
}

[Script]
public class {|#0:MissingInheritance|}
{
}

public class {|#1:MissingAttribute|} : Script
{
}";

        var expected1 = new DiagnosticResult(
            ScriptAttributeAnalyzer.MissingInheritanceDiagnosticId,
            DiagnosticSeverity.Error)
            .WithLocation(0)
            .WithArguments("MissingInheritance");

        var expected2 = new DiagnosticResult(
            ScriptAttributeAnalyzer.MissingAttributeDiagnosticId,
            DiagnosticSeverity.Error)
            .WithLocation(1)
            .WithArguments("MissingAttribute");

        await VerifyAnalyzerAsync(testCode, expected1, expected2);
    }

    [Fact]
    public async Task DerivedScript_WithAttribute_InheritingFromScriptIndirectly_NoDiagnostic()
    {
        var testCode = @"
using BmSDK.Framework;

public abstract class BaseScript : Script
{
}

[Script]
public class DerivedScript : BaseScript
{
}";

        await VerifyAnalyzerAsync(testCode);
    }
}
