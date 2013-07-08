LangExt
=======
LangExtは、C#での関数プログラミングをサポートすることを主な目的としたライブラリです。
LangExtを使用することで、冗長な記述を極力排し、かつバグを埋め込みにくいプログラミングが可能となります。

LangExtはC#が目指せなかった(目指さなかった)場所を目指すためのライブラリになっています。
程度の差はあれ、ライブラリを使うためには、そのライブラリが提供する語彙を覚えるか知っている必要があります。
LangExtは関数型言語(主にF#)から語彙を借りてきているため、標準的なC#の流儀からは反するものもいくつかあります。
そのあたりを理解して使用してください。

導入方法
--------
NuGetに[LangExt](https://nuget.org/packages/LangExt/)という名前で登録してあります。
Visual Studio 2012の場合は、
「NuGetパッケージの管理」から「オンラインの検索」に「LangExt」と入力すれば見つかるので、
そこからインストールするのが手軽です。

また、サブプロジェクトとして、

* [LangExt.Compatibility.FSharp](https://nuget.org/packages/LangExt.Compatibility.FSharp/)
* [LangExt.Legacy](https://nuget.org/packages/LangExt.Legacy/)

があります。
これらも、NuGetで導入できます。

ドキュメント
------------
docディレクトリに各種ドキュメントを作っていく予定です。
これらのドキュメントは、GithubではなくPandocを対象に書かれています。
[Github pages](http://langext.github.io/LangExt/)にて最新版が閲覧可能ですので、
そちらを参照してください。
