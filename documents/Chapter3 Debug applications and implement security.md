# Skill 3.1: Validate application input

この章では以下のような事を確認します。
- [x] JSONデータを検証します
- [x] コレクションから適切なデータを抽出
- [x] データの整合性管理
- [x] 入力データのフォーマット検証時の標準的な例外評価
- [x] 組み込み関数を使用して型とデータ内容を検証

## この章のサンプルプログラム
- Listening3_1.cs:JSON and C#
- Listening3_2.cs:Creating XML
- Listening3_3.cs:Validating JSON

**注意** 
NuGetコマンド`Install-Package Microsoft.EntityFrameworkCore`は最新バージョン(3.1.1)がインストールされ、VisualStudio2017が対応する.NETCore2.1.*の範囲を超える。
そのため、上記コマンドでのMicrosoft.EntityFrameworkCoreのインストールはVisualStudio2019で行う必要がある。

# Skill 3.2: Perform symmetric and asymmetric encryption
この章では以下のような事を確認します。
- [x] 最適な暗号化アルゴリズムの選定
- [x] 証書の生成と管理
- [x] キー制御の実装
- [x] System.Securityの実装
- [x] データのハッシュ化
- [x] 文字列の暗号化

## この章のサンプルプログラム
- Listening3_14.cs:AES encryption
- Listening3_15.cs:AES descryption
- Listening3_16.cs:RSA encryption
- Listening3_17.cs:RSA key management
- Listening3_18.cs:RSA stored key clear(not create codes)
~~~ CS
rsaStore.PersistKeyInCsp = false;
rsaStore.Clear();
~~~
- Listening3_19.cs:Machine level keys
- Listening3_20.cs:Signing data
- Listening3_21.cs:Checksums
- Listening3_22.cs:Hashing
~~~ CS
static void ShowHash(string source)
{
    Console.WriteLine("Hash for {0} is {1:X}", source, source.GetHashCode());
}
~~~
- Listening3_23.cs:SHA2
- Listening3_24.cs:Encrypt a stream

**補足**  
[秘密鍵方式](https://www.pentasecurity.co.jp/pentapro/entry/2017/06/21/%E3%80%903%E5%88%86IT%E3%82%AD%E3%83%BC%E3%83%AF%E3%83%BC%E3%83%89%E3%80%91_%E5%AF%BE%E7%A7%B0%E9%8D%B5_%28Symmetric_Key%29)  
[公開鍵方式](https://udemy.benesse.co.jp/development/blockchain/public-key-cryptography.html)  
[AES](https://wa3.i-3-i.info/word15121.html)  
[X.509証明書](https://www.atmarkit.co.jp/ait/articles/0401/01/news098.html)  
[ハッシュ](https://wa3.i-3-i.info/word11949.html)
[チェックさむ](https://wa3.i-3-i.info/word1240.html)  
[MD5](https://qiita.com/mogulla3/items/720c9c9731de0e906af2)  
[SHA1/SHA2](https://geechs-magazine.com/tag/lifehack/20160822_2/2)  

# Skill3.3 Manage assemblies

この章では以下のような事を確認します。
- [x] アセンブリのバージョン管理
- [x] 厳密な名前を使用してアセンブリに署名する
- [x] side-by-side実行の実装方法
- [x] グローバルアセンブリキャッシュにアセンブリを格納する
- [x] WinMDアセンブリの生成

## この章のサンプルプログラム
- Listening3_25.cs:Assemblies(create at directory "Listening3_25_Assemblies")  
- Listening3_26.cs:Strong names(create at directory "Listening3_25_Assemblies")  
  Assembly Password:Thisiskey
- Listening3_27.cs:EinRT(create at directory "Litening3_27_WinRT")

**補足**  
[side-by-side実行](https://docs.microsoft.com/ja-jp/dotnet/framework/deployment/side-by-side-execution)  
[グローバルアセンブリキャッシュ](https://docs.microsoft.com/ja-jp/dotnet/framework/app-domains/gac)  
[DLL地獄](https://ja.wikipedia.org/wiki/DLL%E5%9C%B0%E7%8D%84)  
[厳密な名前付きアセンブリ](http://surferonwww.info/BlogEngine/post/2011/09/13/Strong-named-assembly.aspx)  
[マネージ アプリケーションに対する厳密な名前による署名](https://docs.microsoft.com/ja-jp/previous-versions/visualstudio/visual-studio-2010/h4fa028b(v=vs.100)?redirectedfrom=MSDN)  
[アセンブリへの遅延署名](https://docs.microsoft.com/ja-jp/dotnet/standard/assembly/)
[アセンブリバージョンのリダイレクト](https://docs.microsoft.com/ja-jp/dotnet/framework/configure-apps/redirect-assembly-versions)

**Memo**
- ildasmの使い方
1. VisualStudio開発者コマンドプロンプトを起動
2. *ildasm*を入力
3. ildasmが起動するので、dllを食わせる  

