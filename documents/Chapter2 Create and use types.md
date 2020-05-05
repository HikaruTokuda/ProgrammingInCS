# Skill 2.6: Manage the object life cycle

この章では以下のような事を確認します。
- [x] *unmanaged*なリソースの扱い方
- [x]  終了処理を交えた*IDisposable*の実装
- [x] *using*ステートメントを用いた*IDisposable*の扱い方
- [x] 終了処理とガベージコレクションの扱い方

## この章のサンプルプログラム
- Listening2_63.cs：Creating garbage
- Listening2_64.cs：Object finalization using finalizer method
- Listening2_65.cs：Using IDisposable and finalization on the same object
  

## 参考サイト
- [using 文と IDisposable とデストラクタと](https://qiita.com/masaru/items/c1a093f19c1557db704c)

# Skill2.7: Manipulate strings

この章では以下のような事を確認します。
- [X] StringBuilder、StringWriter、StringReaderクラスを用いた文字列操作
- [X] 文字列検索
- [X] 列挙帯の文字列メソッド
- [X] 文字列フォーマット
- [X] 文字列挿入

## この章のサンプルプログラム
- Listening2_66.cs: String interningZ(not create sample codes)
~~~ CS
string s1 = "hello";
string s2 = "hello";

string h1 = "he";
string h2 = "llo";
string s3 = h1 + h2;

s3 = string.Intern(s3);
~~~
- Listening2_67.cs StringBuilder(not create sample codes)
~~~ CS
string firstName = "Rob";
string secondName = "Miles";
string fullName = firstName + " " + secondName;

StringBuilder fullNameBuilder = new StringBuilder();
fullNameBuilder.Append(firstName);
fullNameBuilder.Append(" ");
fullNameBuilder.Append(secondName);
~~~
- Listening2_68.cs: StringWriter(not create sample codes)
~~~ CS
using System;
using System.IO;
namespace LISTENING2_68_StringWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            StringWriter writer = new StringWriter();
            writer.WriteLine("Hello World");
            writer.Close();

            Console.WriteLine(writer.ToString());
        }
    }
}
~~~
- Listening2_69.cs: StringReader(not create sample codes)
~~~ CS
using System;
using System.IO;
namespace LISTENING2_69_StringReader
{
    class Program
    {
        static void Main(string[] args)
        {

            string dataString =
@"Rob Miles
21";

            StringReader dataStringReader = new StringReader(dataString);

            string name = dataStringReader.ReadLine();
            int age = int.Parse(dataStringReader.ReadLine());

            dataStringReader.Close();

            Console.WrtiteLine("Name: {0} Age: {1}", name, age);
        }
    }
}
~~~
- Listening2_71.cs: Enumerate string method(not create sample codes)
~~~ CS
foreach(char ch in "Hello World")
{
    Console.WriteLine(ch);
}
~~~
- Listening2_72.cs: Format strings
- Listening2_73.cs: Music track formatter
- Listening2_74.cs: Format provider
- Listening2_75.cd: Use string interpolation(not create sample codes)
~~~ CS
string name "Rob";
int age = 21;

Console.WriteLine("Your name is {0} and your age is {1, -5:D}", name, age);
Console.WriteLine($"Your name is {name} and your age is {age}");
Console.WriteLine(string.Format($"Your name is {name} and your age is {age}"));
~~~

# Thought experiments
## Creating types
1. あなたは自分の会社で働いている従業員の情報を蓄積させたいです。これは値型ですか？参照型ですか？
2. １つのオブジェクトは複数の参照先を設定可能ですか？
3. オブジェクトへの空アクセス時、何が起こりますか？
4. 参照型ではなく値型を使用する場合、プログラムは引き続き正しく機能しますか？
5. 不変のデータ型をどうやって作りますか？
6. 値型は参照型よりも効率的ですか？
7. スタックとヒープの違いは何ですか？
8. 作成したオブジェクトにはそれぞれコンストラクタを作成しないといけませんか？
9. コンストラクタ見呼び出しのオブジェクトは意味がありますか？
10. 静的メンバーはどのような意味を持ちますか？
11. メソッドのすべてのパラメーターにデフォルト値を提供する必要がありますか？　←　どうゆう意味？
12. 多くのoverrideメソッドを記述すると、プログラムの処理速度が低下しますか？

## Consuming types
1. プログラム内の全ての変数が参照型の場合、値をボックス化する必要がありますか？
2. 型拡張時、キャストの必要がありますか？
3. キャストはプログラムの処理速度を低下させますか？
4. オブジェクトは複数の型変換メソッドを持つことができますか？
5. 完全に動的型付けでプログラムを記述できますか？
6. COMオブジェクトと関係する必要があるのは何故ですか？

## Enforce encapsulation(カプセル化)
1. privateなデータメンバに対して、get/setメソッドを使用するよりもプロパティを使った方が良いですか？
2. 構造体はprivateなデータを持つことができますか？
3. プロパティを使用するとプログラムのパフォーマンスは落ちますか？
4. クラスのメンバに対してより多くアクセスするのは、proetctedとinternalのどちらですか？
5. オブジェクトでメソッドの明示的な実装を使用しない理由はありますか？

## Create and implement a class hierarchy
1. インターフェースの設計はアプリケーションの設計が終わってから設計するべきですか？
2. C#のinterfaceはメソッド以外にも宣言できますか？
3. C#のinterfaceは拡張可能ですか？
4. interface内の全てのメソッドはpublicですか？
5. interfaceを批准するクラスはそのinterfaceに宣言されている全てのメソッドの実装が必要ですか？
6. interfaceはコンストラクタを宣言できますか？
7. １つのオブジェクトは複数のinterfaceを批准できますか？
8. interfaceを批准できるのは基底クラスだけですか？
9. 仮想メソッドの定義は処理速度を低下させますか？
10. 仮想メソッドの定義はプログラムの安全性を低下させますか？
11. interfaceとabstractの違いは何ですか？
12. 作成した全てのクラスはクラス構造の一部ですか？
13. overrideとoverloadを同時に実装できますか？
14. 構造体にoverrideメソッドを定義できますか？
15. 構造体はinterfaceを批准できますか？
16. クラスの隠蔽とはどのような意味ですか？
17. 全てのオブジェクトはIEnumerableインターフェースを批准できますか？
18. yieldキーワードはプログラムを停止させますか？
19. Disposeメソッドはオブジェクトがメモリから解放される際に呼び出されますか？
20. IDisposeを使用する場合、自身のメモリ解放のためにDisposeメソッドを呼び出さなければいけませんか？
21. IDisposeインターフェイスを使用してオブジェクトを整理する場合、これは、ガベージコレクターによってオブジェクトがより迅速に削除されることを意味しますか？

## Find, excute, and create types at runtime by using reflection
1. 属性値はどこに蓄積されますか？
2. プログラムの実行中に属性値を変更するとなにが起こりますか？
3. Attributeクラスは属性を持てますか？
4. クラスの型情報はどこに蓄積されますか？
5. *typeof*と*GetType*の違いは何ですか？
6. 値型に対しても*GetType*メソッドを使用できますか？
7. *GetType*によって取得した型情報を変更できますか？
8. リフレクションを使用して、オブジェクト内のプライベートアイテムの詳細を取得できますか？
9. CodeDOMを用いて作成したプログラムを通常通り作成したプログラムよりも処理速度が遅いですか？
10. アセンブリファイルから、プログラムの詳細はわかりますか？
11. 特定のインターフェイスを実行するためのクラスをCodeDOMで作成できますか？
12. CodeDOMで作成されたオブジェクトに対して、リフレクションは使用できますか？

## Manage the object life cycle
1. 参照型でなく値型を使用する場合、ガベージコレクターは停止しますか？
2. 値型の配列の作成と解放はガベージコレクターの動作に関係がありますか？
3. ガベージコレクターはスタック領域のゴミも監視しますか？
4. Disposeメソッドがコールされる前に終了処理を呼び出すことはできますか？
5. 終了処理メソッドのオーバーロードは可能ですか？
6. 子クラスの終了処理メソッドは親クラスの終了処理メソッドを呼び出しますか？
7. Disposeメソッドを複数回呼び出せますか？
8. 1つの終了処理の実行に時間がかかるとどうなりますか？
9. 終了処理内で新しいインスタンスを生成した場合、どうなりますか？
10. アプリケーションの設計時に最小限のメモリで動作するよう設計するべきですか？

## Manipulate strings
1. 本全体のテキストを単一の文字列インスタンスに保持できますか？
2. 1つのstringオブジェクトは不変です。これは、１度生成したstring型の変数に新しい値を設定できないことを意味しますか？
3. C#のプログラムは文字列の挿入において、なにか不利な点がありますか？
4. StringBuilder型はstring型を継承していますか？
5. 常時StringBuilderクラスを用いると処理速度が向上しますか？
6. StringWriterクラスはバイナリデータを扱えますか？
7. Trimメソッドは文字列の内容を変更できますか？
8. IFormattableを批准するとどうなりますか？
9. CultureInfoクラスは実際には何を含みますか？
10. プログラムの実行時に作成されるテキストの文字列で文字列補間を使用できますか？