// User code
Console.WriteLine("original");
Console.WriteLine("original");

// Generated code
namespace Examples.Interceptors
{
    public static class Interceptor
    {
        [System.Runtime.CompilerServices.InterceptsLocation(
            // Change to your own file path for this to work.
            filePath: @"Z:\GitHub\LunchLearning-dotnet7+8\src\Examples.Interceptors\Program.cs",
            line: 3,
            column: 9)]
        public static void InterceptWriteLine(string? message)
        {
            Console.WriteLine($"INTERCEPTED! Original message was '{message}'");
        }
    }
}

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    file sealed class InterceptsLocationAttribute(string filePath, int line, int column) : Attribute;
}

