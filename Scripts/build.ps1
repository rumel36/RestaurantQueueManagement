<#
.SYNOPSIS
    Builds the application and creates installer.
.DESCRIPTION
    Builds the application, generates the installer. 
	By default the build would be unsigned. To sign the build make sure to include -signBuild as a parameter.
.PARAMETER config
Specifies the configuration to be used.
.PARAMETER platform
Specifies the platform to be used.
.PARAMETER signBuild
Indicates that the build should be signed.
.OUTPUTS
PolarBear installer
.EXAMPLE
.\Scripts\build.ps1
.EXAMPLE
.\Scripts\build.ps1 -config "Debug"
.EXAMPLE
.\Scripts\build.ps1 -config "Debug" -platform "x86" -createInstaller
.EXAMPLE
.\Scripts\build.ps1 -config "Release" -platform "x86" -signBuild -createInstaller
#>

param (
    [string]$KEY
)

$MSBuildBase = (Get-Command "msbuild").Definition 
$SignTool  = "CodeSignTool\CodeSignTool" 
$CurrentDirectory = Get-Location

### Functions
function Error($message){
    Write-Warning $message 
}

### Parameter Validation & Setup

if([string]::IsNullOrWhitespace($config)){
    $config = "Release"
}
if([string]::IsNullOrWhitespace($platform)){
    $platform = "x86"
}

Write-Output "`n#############################################"
Write-Output "## Starting PolarBear Demo Windows Build Script ##"
Write-Output "#############################################`n"

if($KEY -eq "12345abcd"){
  #Building  Restaurant   
& $MSBuildBase Restaurant\Restaurant.csproj

}
else{
	write-output "#Not build#"
	exit;
}