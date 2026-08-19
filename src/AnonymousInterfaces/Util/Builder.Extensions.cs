using System;
using System.Linq.Expressions;

namespace AnonymousInterfaces.Util;

public partial class Builder<TInterface>
{
    /// <summary>
    /// Adds an index getter implementation.
    /// </summary>
    /// <typeparam name="TIndex">The index parameter type.</typeparam>
    /// <typeparam name="TValue">The return type.</typeparam>
    /// <param name="implementation">The getter implementation.</param>
    public Builder<TInterface> IndexGet<TIndex, TValue>(Func<TIndex, TValue> implementation) =>
        Method("get_Item", implementation);

    /// <summary>
    /// Adds an index setter implementation.
    /// </summary>
    /// <typeparam name="TIndex">The index parameter type.</typeparam>
    /// <typeparam name="TValue">The value type being set.</typeparam>
    /// <param name="implementation">The setter implementation.</param>
    public Builder<TInterface> IndexSet<TIndex, TValue>(Action<TIndex, TValue> implementation) =>
        Method("set_Item", implementation);
}
