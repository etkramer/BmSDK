param(
    [Parameter(Mandatory = $true, Position = 0)]
    [string]$SolutionFile,
    
    [Parameter(ValueFromRemainingArguments = $true)]
    [string[]]$MSBuildArgs
)

# Find Visual Studio installation
$VsWhere = "${env:ProgramFiles(x86)}\Microsoft Visual Studio\Installer\vswhere.exe"
if (-not (Test-Path $VsWhere)) {
    Write-Error "vswhere.exe not found. Visual Studio 2022 may not be installed."
    exit 1
}

# Get VS installation path
$VsPath = & $VsWhere -latest -products * -requires Microsoft.VisualStudio.Component.VC.Tools.x86.x64 -property installationPath

# Import VS Developer Shell module
$DevShellModule = Join-Path $VsPath "Common7\Tools\Microsoft.VisualStudio.DevShell.dll"

try {
    Import-Module $DevShellModule -Force
    
    # Enter VS Developer Shell with x86 architecture
    Enter-VsDevShell -VsInstallPath $VsPath -DevCmdArguments '-arch=x86'
    
    # Build arguments array
    $AllArgs = @($SolutionFile) + $MSBuildArgs + @(
        '/p:Configuration=Debug'
        '/p:Platform=x86'
        '/nologo'
        '/verbosity:m'
    )
    
    Write-Host "Building with MSBuild in VS Developer environment..."
    
    # Execute MSBuild (now available in PATH)
    & msbuild.exe @AllArgs
    exit $LASTEXITCODE
}
catch {
    Write-Error "Failed to set up Visual Studio environment: $_"
    exit 1
}
