param([string[]] $targets)

$processors = $(Get-WmiObject Win32_Processor).NumberOfLogicalProcessors

$myDir = [System.IO.Path]::GetDirectoryName($MyInvocation.MyCommand.Path)
$projectRoot = [System.IO.Path]::GetDirectoryName($myDir)
$packageDir = [System.IO.Path]::Combine($projectRoot, 'nuget-packages')

$nuget = 'NuGet.exe'
try {
  NuGet.exe help > $nul
} catch [Exception] {
  $nuget = [System.IO.Path]::Combine($projectRoot, '.nuget', 'NuGet.exe')
}

if (Test-Path 'C:\Windows\Microsoft.NET\Framework64') {
  $msbuild = 'C:\Windows\Microsoft.NET\Framework64\v4.0.30319\msbuild.exe'
} else {
  $msbuild = 'C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe'
}

function RemoveIfExists($path) {
  if (Test-Path $path) {
    rm -Recurse -Force $path
  }
}

function Build([string] $target) {
  RemoveIfExists $([System.IO.Path]::Combine($target, 'bin'))
  RemoveIfExists $([System.IO.Path]::Combine($target, 'obj'))
  &$msbuild $($target + '.sln') /t:Build /p:Configuration=Release /p:VisualStudioVersion=11.0 /m:$processors
  if (-not $?) {
    throw "build error. target: $target"
  }
}

function Pack($target) {
  $orgDir = $(pwd).Path
  cd $target
  $fsproj = "$target.fsproj"
  if (Test-Path $fsproj) {
    &$nuget pack $fsproj -Symbols -Properties 'VisualStudioVersion=11.0'
  } else {
    &$nuget pack "$target.csproj" -Symbols -Properties 'VisualStudioVersion=11.0'
  }
  $res = $?
  mv *.nupkg $packageDir
  cd $orgDir
  if (-not $res) {
    throw "nuget pack error. target: $target"
  }
}

function NewPackages($targets) {
  $orgDir = $(pwd).Path
  cd $projectRoot
  RemoveIfExists $packageDir
  mkdir $packageDir

  if ($targets -eq $null) {
    $targets = ls *.sln | sort -Descending | %{ [System.IO.Path]::GetFileNameWithoutExtension($_.Name) }
  }
  $targets | %{
    Build $_
    Pack $_
  }

  cd $orgDir
  trap { cd $orgDir; break }
}

NewPackages $targets
