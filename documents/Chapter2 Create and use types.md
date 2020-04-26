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
