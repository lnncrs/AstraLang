# PowerShell 

$Url = 'https://www.antlr.org/download/antlr-4.13.0-complete.jar'
$FileName = [System.IO.Path]::GetFileName($Url)
$OutputFolder = Join-Path -Path $PWD -ChildPath 'bin'
$OutputFile = Join-Path -Path $OutputFolder -ChildPath $FileName

if (-not (Test-Path -Path $OutputFolder)) {
    New-Item -Path $OutputFolder -ItemType Directory
}

Invoke-WebRequest -Uri $Url -OutFile $OutputFile
