using System;
using Castle.DynamicProxy;

namespace AnonymousInterfaces;

/// <summary>
/// Provides access to a single, global <see cref="ProxyGenerator"/> instance that is used by default from all AnonymousInterface APIs.
/// </summary>
public static class SharedProxyGenerator
{
    /// <summary>
    /// The actual instance, or <c>null</c> if the instance has not yet been created.
    /// </summary>
    private static Lazy<ProxyGenerator> instance = new();

    /// <summary>
    /// Gets or sets the global <see cref="ProxyGenerator"/> instance, creating it if necessary.
    /// </summary>
    public static ProxyGenerator Instance => instance.Value;
}
