param(
    [Parameter(Position = 0)]
    [ValidateSet("Prebuild", "Build", "Clean", "Publish")]
    [string]$Task,
    
    [Parameter(Position = 1)]
    [ValidateSet("Debug", "Release")]
    [string]$Configuration = "Debug"
)

function Show-Help {
    Write-Host "Usage: Build.ps1 <task> [configuration]"
    Write-Host ""
    Write-Host "Tasks:"
    Write-Host "  Prebuild"
    Write-Host "  Build"
    Write-Host "  Clean"
    Write-Host "  Publish"
    Write-Host ""
    Write-Host "Configurations:"
    Write-Host "  Debug (default)"
    Write-Host "  Release"
}

function Install-VSEnvironment {
    param([string]$Config)
    
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
        
        # Preserve current working directory
        $OriginalPath = Get-Location
        
        # Enter VS Developer Shell with x86 architecture
        Enter-VsDevShell -VsInstallPath $VsPath -DevCmdArguments '-arch=x86'
        
        # Restore original working directory
        Set-Location $OriginalPath
        
        return $true
    }
    catch {
        Write-Error "Failed to set up Visual Studio environment: $_"
        return $false
    }
}

function Invoke-MSBuild {
    param(
        [string]$SolutionFile,
        [string[]]$Targets,
        [string]$Configuration
    )
    
    $ConfigParam = $Configuration
    
    $TargetArgs = $Targets | ForEach-Object { "/t:$_" }
    
    $AllArgs = @($SolutionFile) + $TargetArgs + @(
        "/p:Configuration=$ConfigParam"
        '/p:Platform=x86'
        '/nologo'
        '/verbosity:m'
    )
    
    Write-Host "Building with MSBuild..."
    Write-Host "Targets: $($Targets -join ', ')"
    Write-Host "Configuration: $ConfigParam"
    
    # Capture both stdout and stderr
    $Output = & msbuild.exe @AllArgs 2>&1
    $ExitCode = $LASTEXITCODE
    
    # Display all output
    $Output | ForEach-Object { Write-Host $_ }
    
    Write-Host ""
    if ($ExitCode -eq 0) {
        Write-Host "Build successful!" -ForegroundColor Green
    }
    else {
        Write-Host "Build failed (exit code $ExitCode)" -ForegroundColor Red
        Write-Host "Check the above output for compilation errors." -ForegroundColor Yellow
    }
    
    return $ExitCode
}

function Invoke-Clean {
    $PluginsDir = "bin\Binaries\Win32\plugins"
    $SdkDir = "bin\Binaries\Win32\sdk"
    
    Write-Host "Cleaning binaries..."
    
    if (Test-Path $PluginsDir) {
        Write-Host "Deleting files in $PluginsDir"
        Get-ChildItem $PluginsDir | Remove-Item -Force -Recurse
    }
    
    if (Test-Path $SdkDir) {
        Write-Host "Deleting files in $SdkDir"
        Get-ChildItem $SdkDir | Remove-Item -Force -Recurse
    }
    
    Write-Host "Clean completed."
}

# Main script logic
$SolutionFile = "BmSDK.slnx"

switch ($Task) {
    "Clean" {
        Invoke-Clean
        exit 0
    }
    
    "Prebuild" {
        if (-not (Install-VSEnvironment $Configuration)) {
            exit 1
        }
        
        $ExitCode = Invoke-MSBuild $SolutionFile @("BmSDK_Generator") $Configuration
        exit $ExitCode
    }
    
    "Build" {
        if (-not (Install-VSEnvironment $Configuration)) {
            exit 1
        }
        
        $ExitCode = Invoke-MSBuild $SolutionFile @("BmSDK", "BmSDK_Host") $Configuration
        exit $ExitCode
    }
    
    default {
        Write-Error "Unknown task: $Task"
        Show-Help
        exit 1
    }
}
