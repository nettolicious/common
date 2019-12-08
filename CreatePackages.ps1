Param()

function PublishCorePackage([Parameter(Mandatory = $true)][string]$Project, [Parameter(Mandatory = $true)][string]$Name, [Parameter(Mandatory = $true)][string]$AssemblyDir) {
    [string]$packageName = ""
	#$distPath = $null
	$currentLocation = Get-Location 
	Write-Host $currentLocation
	Set-Location -Path ".\$($Project)"
	$currentLocation = Get-Location 
	Write-Host $currentLocation
    $assemblyPath = Join-Path -Path $AssemblyDir -ChildPath  "$($Name).dll"
    if (-Not(Test-Path $assemblyPath)) {
        throw "Assembly could not be found at $($AssemblyPath)"
    }
    [string]$version = (Get-Item -Path $AssemblyPath).VersionInfo.FileVersion
	$version = $version.Substring(0, $version.LastIndexOf("."))
	Write-Host "Package version $($version)"
    Write-Host "Creating $($Name) package"
    $args = @(".\$($Project).csproj", "/t:pack", "/p:Configuration=Release;PackageVersion=$($version)")
    & $MSBUILD $args
    $packageName = "$($Name).$($version).nupkg"
    $distPath = Join-Path -Path $REPO -ChildPath $packageName
    if (Test-Path $distPath) {
        Remove-Item $distPath
    }
    Move-Item ".\bin\Release\$($packageName)" $REPO
    Set-Location -Path ..
}

function PublishNuGetPackage([Parameter(Mandatory = $true)][string]$Project, [Parameter(Mandatory = $true)][string]$Name) {
    [string]$packageName = ""
    $distPath = $null

    Set-Location -Path ".\$($Project)"
    Write-Host "Creating $($Name) package"
    & $NUGET pack "$($Project).csproj" -Properties "Configuration=Release;PackageVersion=$($VERSION)"
    $packageName = "$($Name).$($VERSION).nupkg"
    $distPath = Join-Path -Path $REPO -ChildPath $packageName
    if (Test-Path $distPath) {
        Remove-Item $distPath
    }
    Move-Item ".\$($packageName)" $REPO
    Set-Location -Path ..
}

Write-Host "Creating NuGet packages with version $($Version)"

[string]$global:REPO = "C:\NUGET"
[string]$global:MSBUILD = "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\Bin\msbuild.exe"
[string]$global:NUGET = "C:\Program Files (x86)\NuGet\bin\nuget.exe"

PublishCorePackage -Project "Common" -Name "Nettolicious.Common" -AssemblyDir ".\bin\Release\netstandard2.0"
PublishCorePackage -Project "Common.AspNetCore" -Name "Nettolicious.Common.AspNetCore" -AssemblyDir ".\bin\Release\netcoreapp2.2"
PublishCorePackage -Project "Common.Data" -Name "Nettolicious.Common.Data" -AssemblyDir ".\bin\Release\netstandard2.0"
PublishCorePackage -Project "Common.Data.Autofac" -Name "Nettolicious.Common.Data.Autofac" -AssemblyDir ".\bin\Release\netstandard2.0"
PublishCorePackage -Project "Common.Logging.NLog" -Name "Nettolicious.Common.Logging.NLog" -AssemblyDir ".\bin\Release\netstandard2.0"
PublishCorePackage -Project "Common.Logging.NLog.Autofac" -Name "Nettolicious.Common.Logging.NLog.Autofac" -AssemblyDir ".\bin\Release\netstandard2.0"