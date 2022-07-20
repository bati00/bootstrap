
## csharp-cli

Command line interface using C# 

* Prerequisite
  * Command Line Parser 
    * Package Manager Console
	
```
$ install-package CommandLineParser -version 2.9.1
```

* How to Build 

```
$ Nuget restore csharp-cli\csharp-cli.sln 

$ path %path%;C:\Program Files (x86)\MSBuild\14.0\Bin\;

$ MSBuild.exe /p:VisualStudioVersion=14.0 /consoleloggerparameters:Encoding=ASCII /t:Rebuild "/p:Configuration=Release;Platform=Any CPU" /maxcpucount  csharp-cli

```

* How to Use

```
$ ./csharp-cli.exe
help 
login -a 127.0.0.1 -u admin
Input password:*****

x
```