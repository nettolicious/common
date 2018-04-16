# Common Utilities & Extensions

## Common, Common.Data & Common.Logging.NLog

Common and Common.Data target .NET Standard 2.0 and .NET Framework 4.6.2. Theoretically, you
can reference .NET Standard 2.0 projects from .NET Framework 4.6.2, but I found that there are
issues when doing this from web and web api/service projects.

> The .NET Standard 2.0 spec will ship later this year. .NET Framework 4.6.1 and later will
> support .NET Standard 2.0. At the point that .NET Standard 2.0 class library projects and
> NuGet packages start being created, you’ll be able to reference them from .NET Framework 
> 4.6.1 or later projects.

https://docs.microsoft.com/en-us/dotnet/standard/net-standard

## Common.Logging.NLog.Ninject

Common.Logging.NLog.Ninject targets .NET Framework 4.6.2 only. 

Moving forward we should use Autofac and prefer to not make shared assemblies dependent 
upon a particular DI. For example, create two libraries Shared and Shared.Autofac instead 
of just one assembly dependent upon Autofac.

## ConsoleApp & ValuesLib

ConsoleApp and ValuesLib are for simple testing of the above libraries. They are not for 
resuse.

## GenLoggerClass

GenLoggerClass is a simple console program for generating the Logger adapter class in
the Common.Logging.NLog project.

# NuGet

N.N.N refers to the first three numbers in the AssemblyFileVersion defined in CommonAssemblyInfo
in the Build folder.

1. Perform a Release build.

2. In the solution folder, run `.\CreatePackages.ps1 -Version N.N.N`