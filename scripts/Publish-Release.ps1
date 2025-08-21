
Write-Host "Publishing BmSDK..." -ForegroundColor Green

# Define required files
$RequiredFiles = @{
    "README.md"                                 = "README.md"
    "bin/Binaries/Win32/dinput8.dll"            = "Binaries/Win32/dinput8.dll"
    "bin/Binaries/Win32/plugins/BmSDK.Host.asi" = "Binaries/Win32/plugins/BmSDK.Host.asi"
    "bin/Binaries/Win32/sdk"                    = "Binaries/Win32/sdk"
    "bin/BmGame/Scripts/MinimalScript.cs"       = "BmGame/Scripts/MinimalScript.cs"
    "bin/BmGame/ScriptsDev/ScriptsDev.csproj"   = "BmGame/ScriptsDev/ScriptsDev.csproj"
    "bin/BmGame/ScriptsDev/ScriptsDev.slnx"     = "BmGame/ScriptsDev/ScriptsDev.slnx"
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
    exit 1
}

# Create output directory
$Timestamp = Get-Date -Format "yyyyMMdd-HHmmss"
$ReleaseDir = "releases/BmSDK-$Timestamp"
$ZipPath = "releases/BmSDK-$Timestamp.zip"

if (Test-Path $ReleaseDir) {
    Remove-Item $ReleaseDir -Recurse -Force
}

if (Test-Path $ZipPath) {
    Remove-Item $ZipPath -Force
}

New-Item -ItemType Directory -Path $ReleaseDir -Force | Out-Null

# Copy files to release directory
Write-Host "Copying release files..." -ForegroundColor Yellow

foreach ($Source in $RequiredFiles.Keys) {
    $Destination = Join-Path $ReleaseDir $RequiredFiles[$Source]
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


# Create the zip archive
Write-Host "Creating release archive..." -ForegroundColor Yellow
Compress-Archive -Path "$ReleaseDir/*" -DestinationPath $ZipPath -CompressionLevel Optimal

# Clean up temporary directory
Remove-Item $ReleaseDir -Recurse -Force

# Output success message
$ZipSize = (Get-Item $ZipPath).Length / 1MB
Write-Host "" -ForegroundColor Green
Write-Host "✅ Release package created successfully!" -ForegroundColor Green
Write-Host "   📦 File: $ZipPath" -ForegroundColor White
Write-Host "   📏 Size: $([Math]::Round($ZipSize, 2)) MB" -ForegroundColor White
Write-Host "" -ForegroundColor Green
Write-Host "Ready for distribution! 🚀" -ForegroundColor Green
