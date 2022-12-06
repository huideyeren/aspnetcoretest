# ASP.NET Core のテスト

これは小江戸らぐ 2022年12月の研究発表会およびコミックマーケット101の新刊のネタです。

## 以下悪戦苦闘の備忘録

Windows で試しに起動

```
> dotnet run
ビルドしています...
C:\Users\yuu_t\aspnetcoretest\AspNetCoreSample\Program.cs(4,1): warning IL2026: Using member 'Microsoft.AspNetCore.Buil
der.EndpointRouteBuilderExtensions.MapGet(IEndpointRouteBuilder, String, Delegate)' which has 'RequiresUnreferencedCode
Attribute' can break functionality when trimming application code. This API may perform reflection on the supplied dele
gate and its parameters. These types may be trimmed if not directly referenced. [C:\Users\yuu_t\aspnetcoretest\AspNetCo
reSample\AspNetCoreSample.csproj]
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5165
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: C:\Users\yuu_t\aspnetcoretest\AspNetCoreSample
```

Windows でビルド

```
> dotnet build --configuration Release
MSBuild version 17.4.0+18d5aef85 for .NET
  復元対象のプロジェクトを決定しています...
  復元対象のすべてのプロジェクトは最新です。
C:\Users\yuu_t\aspnetcoretest\AspNetCoreSample\Program.cs(4,1): warning IL2026: Using member 'Microsoft.AspNetCore.Buil
der.EndpointRouteBuilderExtensions.MapGet(IEndpointRouteBuilder, String, Delegate)' which has 'RequiresUnreferencedCode
Attribute' can break functionality when trimming application code. This API may perform reflection on the supplied dele
gate and its parameters. These types may be trimmed if not directly referenced. [C:\Users\yuu_t\aspnetcoretest\AspNetCo
reSample\AspNetCoreSample.csproj]
  AspNetCoreSample -> C:\Users\yuu_t\aspnetcoretest\AspNetCoreSample\bin\Release\net7.0\win-x64\AspNetCoreSample.dll

ビルドに成功しました。

C:\Users\yuu_t\aspnetcoretest\AspNetCoreSample\Program.cs(4,1): warning IL2026: Using member 'Microsoft.AspNetCore.Buil
der.EndpointRouteBuilderExtensions.MapGet(IEndpointRouteBuilder, String, Delegate)' which has 'RequiresUnreferencedCode
Attribute' can break functionality when trimming application code. This API may perform reflection on the supplied dele
gate and its parameters. These types may be trimmed if not directly referenced. [C:\Users\yuu_t\aspnetcoretest\AspNetCo
reSample\AspNetCoreSample.csproj]
    1 個の警告
    0 エラー

経過時間 00:00:02.41

> .\bin\Release\net7.0\win-x64\AspNetCoreSample.exe
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5000
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Production
info: Microsoft.Hosting.Lifetime[0]
      Content root path: C:\Users\yuu_t\aspnetcoretest\AspNetCoreSample

> curl http://localhost:5000

StatusCode        : 200
StatusDescription : OK
Content           : This platform is "Microsoft Windows NT 10.0.22621.0"
RawContent        : HTTP/1.1 200 OK
                    Transfer-Encoding: chunked
                    Content-Type: text/plain; charset=utf-8
                    Date: Tue, 06 Dec 2022 12:58:26 GMT
                    Server: Kestrel

                    This platform is "Microsoft Windows NT 10.0.22621.0"
Forms             : {}
Headers           : {[Transfer-Encoding, chunked], [Content-Type, text/plain; charset=utf-8], [Date, Tue, 06 Dec 2022 1
                    2:58:26 GMT], [Server, Kestrel]}
Images            : {}
InputFields       : {}
Links             : {}
ParsedHtml        : mshtml.HTMLDocumentClass
RawContentLength  : 53
```

Linux で実行

```
$ dotnet run

.NET 7.0 へようこそ!
---------------------
SDK バージョン: 7.0.100

テレメトリ
---------
.NET ツールは、エクスペリエンスの向上のために利用状況データを収集します。データは Microsoft によって収集され、コミュニティと共有されます。テレメトリをオプトアウトするには、好みのシェルを使用して、DOTNET_CLI_TELEMETRY_OPTOUT 環境変数を '1'  または 'true' に設定できます。

.NET CLI ツールのテレメトリの詳細をご覧ください: https://aka.ms/dotnet-cli-telemetry

----------------
ASP.NET Core の HTTPS 開発証明書をインストールしました。
証明書を信頼するには、'dotnet dev-certs https --trust' (Windows および macOS のみ) を実行します。
HTTPS の詳細については、https://aka.ms/dotnet-https を参照してください
----------------
最初のアプリを作成するには、https://aka.ms/dotnet-hello-world を参照してください
最新情報については、https://aka.ms/dotnet-whats-new を参照してください
ドキュメントを探索するには、https://aka.ms/dotnet-docs を参照してください
GitHub で問題の報告とソースの検索を行うには、https://github.com/dotnet/core を参照してください
'dotnet --help' を使用して使用可能なコマンドを確認するか、https://aka.ms/dotnet-cli にアクセスしてください
--------------------------------------------------------------------------------------
ビルドしています...
/home/iosif/aspnetcoretest/AspNetCoreSample/Program.cs(4,1): warning IL2026: Using member 'Microsoft.AspNetCore.Builder.EndpointRouteBuilderExtensions.MapGet(IEndpointRouteBuilder, String, Delegate)' which has 'RequiresUnreferencedCodeAttribute' can break functionality when trimming application code. This API may perform reflection on the supplied delegate and its parameters. These types may be trimmed if not directly referenced. [/home/iosif/aspnetcoretest/AspNetCoreSample/AspNetCoreSample.csproj]
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5165
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: /home/iosif/aspnetcoretest/AspNetCoreSample
      
$ curl http://localhost:5165
This platform is "Unix 5.15.74.2" %
```

Linux でビルド

```
$ dotnet build --configuration Release
MSBuild version 17.4.0+18d5aef85 for .NET
  復元対象のプロジェクトを決定しています...
  復元対象のすべてのプロジェクトは最新です。
/home/iosif/aspnetcoretest/AspNetCoreSample/Program.cs(4,1): warning IL2026: Using member 'Microsoft.AspNetCore.Builder.EndpointRouteBuilderExtensions.MapGet(IEndpointRouteBuilder, String, Delegate)' which has 'RequiresUnreferencedCodeAttribute' can break functionality when trimming application code. This API may perform reflection on the supplied delegate and its parameters. These types may be trimmed if not directly referenced. [/home/iosif/aspnetcoretest/AspNetCoreSample/AspNetCoreSample.csproj]
  AspNetCoreSample -> /home/iosif/aspnetcoretest/AspNetCoreSample/bin/Release/net7.0/linux-x64/AspNetCoreSample.dll

ビルドに成功しました。

/home/iosif/aspnetcoretest/AspNetCoreSample/Program.cs(4,1): warning IL2026: Using member 'Microsoft.AspNetCore.Builder.EndpointRouteBuilderExtensions.MapGet(IEndpointRouteBuilder, String, Delegate)' which has 'RequiresUnreferencedCodeAttribute' can break functionality when trimming application code. This API may perform reflection on the supplied delegate and its parameters. These types may be trimmed if not directly referenced. [/home/iosif/aspnetcoretest/AspNetCoreSample/AspNetCoreSample.csproj]
    1 個の警告
    0 エラー

経過時間 00:00:03.27
```

コンテナでデプロイ

```
$ dotnet publish --os linux --arch x64 -p:PublishProfile=DefaultContainer
MSBuild version 17.4.0+18d5aef85 for .NET
  復元対象のプロジェクトを決定しています...
  /home/iosif/aspnetcoretest/AspNetCoreSample/AspNetCoreSample.csproj を復元しました (165 ms)。
  AspNetCoreSample -> /home/iosif/aspnetcoretest/AspNetCoreSample/bin/Debug/net7.0/linux-x64/AspNetCoreSample.dll
  Generating native code
  ILC: Method '[AspNetCoreSample]Program.<Main>$(string[])' will always throw because: Failed to load assembly 'Microsoft.AspNetCore'
  AspNetCoreSample -> /home/iosif/aspnetcoretest/AspNetCoreSample/bin/Debug/net7.0/linux-x64/publish/
  'AspNetCoreSample' was not a valid container image name, it was normalized to aspnetcoresample
  Building image 'aspnetcoresample' with tags 1.0.0 on top of base image mcr.microsoft.com/dotnet/aspnet:7.0
  Pushed container 'aspnetcoresample:1.0.0' to Docker daemon

$ docker run -it --rm -p 5165:80 aspnetcoresample:1.0.0
/app/AspNetCoreSample: /lib/x86_64-linux-gnu/libc.so.6: version `GLIBC_2.34' not found (required by /app/AspNetCoreSample)
/app/AspNetCoreSample: /lib/x86_64-linux-gnu/libc.so.6: version `GLIBC_2.32' not found (required by /app/AspNetCoreSample)
```
