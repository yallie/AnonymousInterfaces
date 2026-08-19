using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace AnonymousInterfaces.Generator;

/// <summary>
/// Implements boilerplate methods for all Action and Func delegates.
/// </summary>
[Generator]
public class BuilderExtensionsGenerator : ISourceGenerator
{
    public void Initialize(GeneratorInitializationContext context)
    {
    }

    public void Execute(GeneratorExecutionContext context)
    {
        // only our own Builder<TInterface> is supported
        var builderType = context.Compilation.GetTypeByMetadataName("AnonymousInterfaces.Util.Builder`1");
        if (builderType == null || context.Compilation.AssemblyName != "AnonymousInterfaces")
        {
            return;
        }

        var source = GenerateBuilderSource();
        context.AddSource("BuilderMethods.g.cs", SourceText.From(source, Encoding.UTF8));
    }

    private static string GenerateBuilderSource()
    {
        var sb = new StringBuilder();
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Linq.Expressions;");
        sb.AppendLine();
        sb.AppendLine("namespace AnonymousInterfaces.Util");
        sb.AppendLine("{");
        sb.AppendLine("    public partial class Builder<TInterface>");
        sb.AppendLine("    {");

        // generate for Action (0..16 arguments)
        for (int i = 0; i <= 16; i++)
        {
            var typeParams = i == 0 ? "" : $"<{string.Join(", ", Enumerable.Range(1, i).Select(n => $"TArg{n}"))}>";
            var args = i == 0 ? "" : $"({string.Join(", ", Enumerable.Range(1, i).Select(n => $"TArg{n} arg{n}"))})";
            var callArgs = i == 0 ? "" : $"({string.Join(", ", Enumerable.Range(1, i).Select(n => $"arg{n}"))})";

            sb.AppendLine();
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// Adds a void-returning method implementation with {i} argument{(i == 1 ? "" : "s")}.");
            sb.AppendLine($"        /// </summary>");
            for (int n = 1; n <= i; n++)
                sb.AppendLine($"        /// <typeparam name=\"TArg{n}\">The type of argument {n}.</typeparam>");
            sb.AppendLine($"        /// <param name=\"interfaceMethodSelector\">An expression selecting the method from the interface.</param>");
            sb.AppendLine($"        /// <param name=\"implementation\">The implementation of the method.</param>");
            sb.AppendLine($"        public Builder<TInterface> Action{typeParams}(");
            sb.AppendLine($"            Expression<Func<TInterface, Action{typeParams}>> interfaceMethodSelector,");
            sb.AppendLine($"            Action{typeParams} implementation) =>");
            sb.AppendLine($"                Method(interfaceMethodSelector, implementation);");
        }

        // generate for Func (0..16 arguments + return type)
        for (int i = 0; i <= 16; i++)
        {
            var typeParams = i == 0 ? "<TReturn>" : $"<{string.Join(", ", Enumerable.Range(1, i).Select(n => $"TArg{n}"))}, TReturn>";
            var args = i == 0 ? "" : $"({string.Join(", ", Enumerable.Range(1, i).Select(n => $"TArg{n} arg{n}"))})";
            var callArgs = i == 0 ? "" : $"({string.Join(", ", Enumerable.Range(1, i).Select(n => $"arg{n}"))})";

            sb.AppendLine();
            sb.AppendLine($"        /// <summary>");
            sb.AppendLine($"        /// Adds a value-returning method implementation with {i} argument{(i == 1 ? "" : "s")}.");
            sb.AppendLine($"        /// </summary>");
            for (int n = 1; n <= i; n++)
                sb.AppendLine($"        /// <typeparam name=\"TArg{n}\">The type of argument {n}.</typeparam>");
            sb.AppendLine($"        /// <typeparam name=\"TReturn\">The return type.</typeparam>");
            sb.AppendLine($"        /// <param name=\"interfaceMethodSelector\">An expression selecting the method from the interface.</param>");
            sb.AppendLine($"        /// <param name=\"implementation\">The implementation of the method.</param>");
            sb.AppendLine($"        public Builder<TInterface> Func{typeParams}(");
            sb.AppendLine($"            Expression<Func<TInterface, Func{typeParams}>> interfaceMethodSelector,");
            sb.AppendLine($"            Func{typeParams} implementation) =>");
            sb.AppendLine($"                Method(interfaceMethodSelector, implementation);");
        }

        sb.AppendLine("    }");
        sb.AppendLine("}");
        return sb.ToString();
    }
}
