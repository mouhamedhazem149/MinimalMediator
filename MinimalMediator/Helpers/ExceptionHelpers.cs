﻿namespace MinimalMediator.Helpers;

internal static class ExceptionHelpers
{
    public static void ThrowIfNull(this object? value, string paramName)
    {
        if (value is null)
        {
            throw new ArgumentNullException(paramName);
        }
    }
}