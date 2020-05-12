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
-Listening3_19.cs:Machine level keys

**補足**  
Symmetric KeyとAsymmetriv Key  
[秘密鍵方式](https://www.pentasecurity.co.jp/pentapro/entry/2017/06/21/%E3%80%903%E5%88%86IT%E3%82%AD%E3%83%BC%E3%83%AF%E3%83%BC%E3%83%89%E3%80%91_%E5%AF%BE%E7%A7%B0%E9%8D%B5_%28Symmetric_Key%29)  
[公開鍵方式](https://udemy.benesse.co.jp/development/blockchain/public-key-cryptography.html)  
[AES](https://wa3.i-3-i.info/word15121.html)  
[X.509証明書](https://www.atmarkit.co.jp/ait/articles/0401/01/news098.html)  





