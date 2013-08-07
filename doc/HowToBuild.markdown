ビルド方法
==========
ビルド環境
----------
LangExtのビルドには、Visual Studio 2012と、
Microsoft Visual Studio 2012 Visualization & Modeling SDK
がインストールされた環境が必要です。

後者に関しては、
[Download Center][dlcenter]
からexeをダウンロードして、インストールしてください。

[dlcenter]: https://www.microsoft.com/en-us/download/details.aspx?id=30680

ビルド手順
----------
上記の環境さえ導入済みであれば、
tools配下のNew-Package.ps1をPowerShellで実行することでビルドできます。
ビルドされたものは、トップのディレクトリのnuget-packagesの中に格納されます。
