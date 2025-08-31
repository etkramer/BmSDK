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

function Invoke-Publish {
    Write-Host "Publishing BmSDK..." -ForegroundColor Green

    # Set up Visual Studio environment
    if (-not (Install-VSEnvironment "Release")) {
        return $false
    }

    # Build BmSDK in Release mode
    Write-Host "Building BmSDK, BmSDK.Host in Release mode..." -ForegroundColor Yellow
    $ExitCode = Invoke-MSBuild $SolutionFile @("BmSDK", "BmSDK_Host") "Release"
    if ($ExitCode -ne 0) {
        Write-Error "Failed to build BmSDK"
        return $false
    }

    # Publish BmSDK to populate publish directory
    Write-Host "Publishing BmSDK project..." -ForegroundColor Yellow
    $PublishPath = Join-Path (Get-Location) "publish\Binaries\Win32\sdk"
    $PublishOutput = & dotnet publish "src/BmSDK/BmSDK.csproj" --configuration Release --output $PublishPath --verbosity minimal 2>&1
    $ExitCode = $LASTEXITCODE
    
    # Display publish output
    $PublishOutput | ForEach-Object { Write-Host $_ }
    
    if ($ExitCode -ne 0) {
        Write-Error "Failed to publish BmSDK project"
        return $false
    }

    # Define required files
    $RequiredFiles = @{
        "README.md"                               = "README.md"
        "bin/Binaries/Win32/dinput8.dll"          = "Binaries/Win32/dinput8.dll"
        "publish/Binaries/Win32/plugins"          = "Binaries/Win32/plugins"
        "publish/Binaries/Win32/sdk"              = "Binaries/Win32/sdk"
        "bin/BmGame/Scripts/MinimalScript.cs"     = "BmGame/Scripts/MinimalScript.cs"
        "bin/BmGame/ScriptsDev/ScriptsDev.csproj" = "BmGame/ScriptsDev/ScriptsDev.csproj"
        "bin/BmGame/ScriptsDev/ScriptsDev.slnx"   = "BmGame/ScriptsDev/ScriptsDev.slnx"
        "bin/BmGame/ScriptsDev/Properties"        = "BmGame/ScriptsDev/Properties"
    }

    # Define Steam-specific files (includes BatmanAC.exe)
    $SteamFiles = @{
        "bin/Binaries/Win32/BatmanAC.exe" = "Binaries/Win32/BatmanAC.exe"
    }

    # Validate all required files exist
    Write-Host "Validating build artifacts..." -ForegroundColor Yellow
    $MissingFiles = @()

    foreach ($SourcePath in $RequiredFiles.Keys) {
        if (-not (Test-Path $SourcePath)) {
            $MissingFiles += $SourcePath
        }
    }

    if ($MissingFiles.Count -gt 0) {
        Write-Error "Missing required files:"
        $MissingFiles | ForEach-Object { Write-Error "  - $_" }
        Write-Error "Please ensure you have built all components and run BmSDK.Generator to generate bindings."
        return $false
    }

    # Get latest git version tag
    $GitTag = ""
    try {
        $GitTag = git describe --tags --abbrev=0 2>$null
        if ($LASTEXITCODE -ne 0) {
            Write-Error "Couldn't determine git tag name"
            return $false
        }
    }
    catch {
        Write-Error "Couldn't determine git tag name"
        return $false
    }
    
    # Create output directory
    $TempDir = "releases/$GitTag-BmSDK"
    $ZipPath = "releases/$GitTag-BmSDK.zip"
    $TempDirSteam = "releases/$GitTag-SteamPatch"
    $ZipPathSteam = "releases/$GitTag-SteamPatch.zip"

    if (Test-Path $TempDir) {
        Remove-Item $TempDir -Recurse -Force
    }

    if (Test-Path $ZipPath) {
        Remove-Item $ZipPath -Force
    }

    New-Item -ItemType Directory -Path $TempDir -Force | Out-Null

    # Copy files to release directory
    Write-Host "Copying release files..." -ForegroundColor Yellow

    foreach ($Source in $RequiredFiles.Keys) {
        $Destination = Join-Path $TempDir $RequiredFiles[$Source]
        $DestinationDir = Split-Path $Destination -Parent
        
        if (-not (Test-Path $DestinationDir)) {
            New-Item -ItemType Directory -Path $DestinationDir -Force | Out-Null
        }
        
        if (Test-Path $Source -PathType Container) {
            # Copy directory recursively
            Copy-Item $Source $DestinationDir -Recurse -Force
        }
        else {
            # Copy file
            Copy-Item $Source $Destination -Force
        }
        
        Write-Host "  ✓ $Source -> $($RequiredFiles[$Source])" -ForegroundColor Gray
    }

    # Create the main release zip archive
    Write-Host "Creating release archive..." -ForegroundColor Yellow
    Compress-Archive -Path "$TempDir/*" -DestinationPath $ZipPath -CompressionLevel Optimal

    # Create Steam patch archive with only BatmanAC.exe
    if (Test-Path $TempDirSteam) {
        Remove-Item $TempDirSteam -Recurse -Force
    }

    if (Test-Path $ZipPathSteam) {
        Remove-Item $ZipPathSteam -Force
    }

    Write-Host "Creating Steam patch..." -ForegroundColor Yellow
    
    New-Item -ItemType Directory -Path $TempDirSteam -Force | Out-Null

    # Copy only Steam-specific files (BatmanAC.exe)
    foreach ($Source in $SteamFiles.Keys) {
        $Destination = Join-Path $TempDirSteam $SteamFiles[$Source]
        $DestinationDir = Split-Path $Destination -Parent
        
        if (-not (Test-Path $DestinationDir)) {
            New-Item -ItemType Directory -Path $DestinationDir -Force | Out-Null
        }
        
        Copy-Item $Source $Destination -Force
        Write-Host "  ✓ $Source -> $($SteamFiles[$Source])" -ForegroundColor Gray
    }

    # Create the Steam patch zip archive
    Compress-Archive -Path "$TempDirSteam/*" -DestinationPath $ZipPathSteam -CompressionLevel Optimal

    # Clean up Steam patch temporary directory
    Remove-Item $TempDirSteam -Recurse -Force

    $SteamPatchZipSize = (Get-Item $ZipPathSteam).Length / 1MB
    Write-Host "Steam patch package created: $ZipPathSteam ($([Math]::Round($SteamPatchZipSize, 2)) MB)" -ForegroundColor Green

    # Clean up main temporary directory
    Remove-Item $TempDir -Recurse -Force

    # Output success message
    $ZipSize = (Get-Item $ZipPath).Length / 1MB
    $ZipSizeSteam = (Get-Item $ZipPathSteam).Length / 1MB
    Write-Host "" -ForegroundColor Green
    Write-Host "Release package(s) created successfully!" -ForegroundColor Green
    Write-Host "   📦 $ZipPath ($([Math]::Round($ZipSize, 2)) MB)" -ForegroundColor White
    if (Test-Path $ZipPathSteam) {
        Write-Host "   📦 $ZipPathSteam ($([Math]::Round($ZipSizeSteam, 2)) MB)" -ForegroundColor White
    }
    Write-Host "" -ForegroundColor Green
    Write-Host "Ready for distribution! 🚀" -ForegroundColor Green
    
    return $true
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
    
    "Publish" {
        Invoke-Publish
        exit 0
    }
    
    default {
        Write-Error "Unknown task: $Task"
        Show-Help
        exit 1
    }
}
