@'
ページ一覧
==========
'@ | Out-File index.markdown -Encoding UTF8
 
@'
LangExtについて
---------------
* [LangExtの概要](LangExt.html)
* [LangExt.Legacyの概要](LangExt.Legacy.html)
* [ビルド方法](HowToBuild.html)
'@ | Out-File index.markdown -Encoding UTF8 -Append
 
@'
 
設計選択について
----------------
'@ | Out-File index.markdown -Encoding UTF8 -Append
 
ls DesignChoice_*.markdown | %{
  $title = $(cat $_.Name -Encoding UTF8)[0]
  "* [$title]($([System.IO.Path]::ChangeExtension($_.Name, '.html')))"
} | Out-File index.markdown -Encoding UTF8 -Append
 
@'
 
標準ライブラリとの比較
----------------------
'@ | Out-File index.markdown -Encoding UTF8 -Append
 
ls cmp_*.markdown | %{
  $title = $(cat $_.Name -Encoding UTF8)[0]
  "* [$title]($([System.IO.Path]::ChangeExtension($_.Name, '.html')))"
} | Out-File index.markdown -Encoding UTF8 -Append
 
@'
 
外部リンク
----------
* [ソースコード(Github)](https://github.com/LangExt/LangExt)
* NuGetパッケージ
    * [LangExt](https://nuget.org/packages/LangExt/)
    * [LangExt.Compatibility.FSharp](https://nuget.org/packages/LangExt.Compatibility.FSharp/)
    * [LangExt.Legacy](https://nuget.org/packages/LangExt.Legacy/)
* [Qiitaでの記事](http://qiita.com/tags/LangExt)
'@ | Out-File index.markdown -Encoding UTF8 -Append
 
ls *.markdown | %{
  $out = $([System.IO.Path]::ChangeExtension($_.Name, '.html'))
  if ($_.Name -eq 'index.markdown') {
    pandoc -s -o $out --css=style.css $_.Name
  } else {
    pandoc -s -o $out --css=style.css --include-before-body=header.html --include-after-body=footer.html $_.Name
  }
}
