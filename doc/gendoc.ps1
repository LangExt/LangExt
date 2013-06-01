@'
ページ一覧
==========
'@ | Out-File index.markdown -Encoding UTF8

@'
LangExtについて
---------------
* [LangExtの概要](LangExt.html)
* [ビルド方法](HowToBuild.html)

'@ | Out-File index.markdown -Encoding UTF8 -Append

@'
設計選択について
----------------
'@ | Out-File index.markdown -Encoding UTF8 -Append

ls DesignChoice_*.markdown -Exclude index.markdown, LangExt.markdown, HowToBuild.markdown  | %{
  $title = $(cat $_.Name -Encoding UTF8)[0]
  "* [$title]($([System.IO.Path]::ChangeExtension($_.Name, '.html')))"
} | Out-File index.markdown -Encoding UTF8 -Append

ls *.markdown | %{
  pandoc -s -o $([System.IO.Path]::ChangeExtension($_.Name, '.html')) --css=style.css $_.Name
}
