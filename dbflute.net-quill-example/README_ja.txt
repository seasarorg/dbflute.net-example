
【データベースのセットアップ】

1. MySQLの準備

MySQL本体は「dfnet-basic-example/localdb/mysql」に配置されることを前提とする。

  e.g. MySQL本体の配置

    |- workspace
        |- dbflute.net-quill-example
                     |- dbflute_exampledb
                     |- lib
                     |- mydbflute
                     |- localdb ☆
                          |- mysql ☆
                              |- bin
                              |- data


2. MySQLの起動

boot-mysql.batを実行する。
反応がないが、起動しているのでしばらくしたらプロンプトは閉じてよい。

※Port番号は「53306」を利用する。
  もし、他のプロジェクトで利用しているMySQLとバッティングするようであれば、適切に調整すること。


3. ReplaceSchemaタスクを実行する。

dbflute_exampledb/replace-schema.batを実行することで、
ExampleDBのデータベースに作成され、テストデータも登録される。
(DBFluteが実行できる環境(Java)が存在することが前提)



【MbUnitのセットアップ】

1. MbUnitの準備

「./lib/unit」配下の「mbunit.zip」を解凍し、
任意のディレクトリに配置する。


2. MbUnit.GUI.exeを起動する。

起動時にエラーダイアログで出ることがあるので、
そのダイアログは「OK」を押した後に、
メニューの「Assemblies」-「Remove Assemblies」を選択する。


3. テストプロジェクトを読み込む。

メニューの「Assemblies」-「Add Assemblies...」において、
「source/DfExampleTest/bin/Release/DfExampleTest.dll」を選択すると
テストが読み込まれる。
(VisualStudioでコンパイルされていることが前提)


4. テストを実行する。

「Run」ボタンを押すことでテストが実行される。
(MySQLが起動していることが前提)
