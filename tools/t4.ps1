function runT4($name) {
  # x86がある場合はそちらを使わないといけない
  $cpf = ${env:CommonProgramFiles(x86)}
  if ($cpf -eq $null) { $cpf = $env:CommonProgramFiles }
  $t4 = $cpf + '\Microsoft Shared\TextTemplating\10.0\TextTransform.exe'
  # こっちも
  $ref = ${env:ProgramFiles(x86)}
  if ($ref -eq $null) { $ref = $env:ProgramFiles }

  $ref += '\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0'
  $cs = $name + '.cs'
  $tt = $name + '.tt'
  & $t4 -out $cs -P $ref $tt
}

ls -r | where {
  $_.Name.EndsWith('.tt')
} | foreach {
  $_.DirectoryName
} | Unique | foreach {
  $initDir = pwd
}{
  cd $_
  ls | where {
    $_.Name.EndsWith('.tt')
  } | foreach {
    $name = $_.Name
    $name = [string]::Join('', $name[0..($name.Length - 4)])
    runT4 $name
  }
}{
  cd $initDir
}

