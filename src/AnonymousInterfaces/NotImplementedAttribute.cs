using System;

namespace AnonymousInterfaces;

/// <summary>
/// Marks a partial class for automatic generation of interface members
/// that throw <see cref="NotImplementedException"/>.
/// All unimplemented methods, properties, events, and indexers will be added
/// as explicit interface implementations.
/// </summary>
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class NotImplementedAttribute : Attribute
{
}
