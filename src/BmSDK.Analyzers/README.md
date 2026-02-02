# BmSDK.Analyzers

This package contains Roslyn analyzers that enforce correct usage of the BmSDK scripting framework.

## Analyzers

### BMSDK001: Missing [Script] attribute

**Severity:** Error

**Description:** A class that inherits from `BmSDK.Script` must have the `[Script]` attribute applied to it.

**Example of invalid code:**

```csharp
using BmSDK.Framework;

// Error: Missing [Script] attribute
public class MyScript : Script
{
    public override void Main()
    {
        Debug.Log("Hello!");
    }
}
```

**Fixed code:**

```csharp
using BmSDK.Framework;

[Script]
public class MyScript : Script
{
    public override void Main()
    {
        Debug.Log("Hello!");
    }
}
```

**Note:** Abstract classes are exempt from this rule and can inherit from `Script` without the `[Script]` attribute.

### BMSDK002: Missing Script inheritance

**Severity:** Error

**Description:** A class that has the `[Script]` attribute must inherit from `BmSDK.Script`.

**Example of invalid code:**

```csharp
using BmSDK.Framework;

// Error: Has [Script] attribute but doesn't inherit from Script
[Script]
public class MyScript
{
    public void Main()
    {
        Debug.Log("Hello!");
    }
}
```

**Fixed code:**

```csharp
using BmSDK.Framework;

[Script]
public class MyScript : Script
{
    public override void Main()
    {
        Debug.Log("Hello!");
    }
}
```

## Usage

The analyzer is automatically applied when:

1. **Design-time:** When developing scripts in the ScriptsDev project, Visual Studio/VS Code will show errors in the editor
2. **Runtime:** When BmSDK compiles scripts at runtime, compilation will fail with clear error messages

## Testing

The analyzer includes comprehensive unit tests in `BmSDK.Analyzers.Tests`. Run tests with:

```bash
cd src/BmSDK.Analyzers.Tests
dotnet test
```

## Technical Details

- **Target Framework:** netstandard2.0 (required for Roslyn analyzers)
- **Roslyn Version:** 4.8.0
- **Execution:** Runs during both design-time and runtime compilation
- **Performance:** Optimized with concurrent execution enabled
