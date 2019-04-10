using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CommandLine;

[assembly: AssemblyTitle("NUnitReporter")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("NUnitReporter")]
[assembly: AssemblyCopyright("Copyright © e-Techstar 2019")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: Guid("4c567c1d-1959-487d-b42e-f745b235ede1")]

[assembly: InternalsVisibleTo("NUnitReporterTests")]
[assembly: AssemblyVersion("5.7.0.0")]
[assembly: AssemblyFileVersion("5.7.0.0")]
[assembly: AssemblyUsage(
    "NUnitReporter.exe TestResult.xml --html",
    "NUnitReporter.exe TestResult.xml --html -o path/to/generated/report",
    "NUnitReporter.exe TestResult.xml --html -a path/to/screenshots -o path/to/generated/report"
    )]
