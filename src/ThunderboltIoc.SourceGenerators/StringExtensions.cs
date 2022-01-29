﻿namespace ThunderboltIoc.SourceGenerators;

public static class StringExtensions
{
    public static bool IsNull(this string str) => str is null;

#pragma warning disable IDE0057 // Use range operator
    public static string RemovePrefix(this string str, string prefix)
    {
        if (string.IsNullOrEmpty(str) || !str.StartsWith(prefix))
            return str;
        return str.Substring(prefix.Length);
    }
#pragma warning restore IDE0057 // Use range operator

    public static string WithSuffix(this string str, string suffix)
    {
        if (str.IsNull() || str.EndsWith(suffix))
            return str;
        return $"{str}{suffix}";
    }
    public static string AddIndentation(this string str, ushort indentationLength)
    {
        if (str.IsNull() || indentationLength == 0)
            return str;
        string indentation = new('\t', indentationLength);
        return $"{indentation}{string.Join($"{Environment.NewLine}{indentation}", str.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None))}";
    }
}
