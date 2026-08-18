using System;
using System.Linq.Expressions;

namespace AnonymousInterfaces.Util;

public partial class Builder<TInterface>
{
    /// <summary>
    /// Adds a void-returning method implementation.
    /// </summary>
    /// <param name="interfaceMethodSelector">An expression selecting the method from the interface. This may be a lambda expression.</param>
    /// <param name="implementation">The implementation of the method.</param>
    public Builder<TInterface> Void(
        Expression<Func<TInterface, Action>> interfaceMethodSelector,
        Action implementation) =>
            Method(interfaceMethodSelector, implementation);

    /// <summary>
    /// Adds a void-returning method implementation. The type argument should be specified explicitly.
    /// </summary>
    /// <typeparam name="TArg1">The type of the argument.</typeparam>
    /// <param name="interfaceMethodSelector">An expression selecting the method from the interface. This may be a lambda expression.</param>
    /// <param name="implementation">The implementation of the method.</param>
    public Builder<TInterface> Action<TArg1>(
        Expression<Func<TInterface, Action<TArg1>>> interfaceMethodSelector,
        Action<TArg1> implementation) =>
            Method(interfaceMethodSelector, implementation);

    /// <summary>
    /// Adds a value-returning method implementation. The type argument should be specified explicitly.
    /// </summary>
    /// <typeparam name="TReturn">The return type.</typeparam>
    /// <param name="interfaceMethodSelector">An expression selecting the method from the interface. This may be a lambda expression.</param>
    /// <param name="implementation">The implementation of the method.</param>
    public Builder<TInterface> Func<TReturn>(
        Expression<Func<TInterface, Func<TReturn>>> interfaceMethodSelector,
        Func<TReturn> implementation) =>
            Method(interfaceMethodSelector, implementation);

    /// <summary>
    /// Adds a void-returning method implementation. The type arguments should be specified explicitly.
    /// </summary>
    /// <typeparam name="TArg1">The type of the argument.</typeparam>
    /// <typeparam name="TArg2">The type of the argument.</typeparam>
    /// <param name="interfaceMethodSelector">An expression selecting the method from the interface. This may be a lambda expression.</param>
    /// <param name="implementation">The implementation of the method.</param>
    public Builder<TInterface> Action<TArg1, TArg2>(
        Expression<Func<TInterface, Action<TArg1, TArg2>>> interfaceMethodSelector,
        Action<TArg1, TArg2> implementation) =>
            Method(interfaceMethodSelector, implementation);

    /// <summary>
    /// Adds a value-returning method implementation. The type arguments should be specified explicitly.
    /// </summary>
    /// <typeparam name="TArg1">The type of the argument.</typeparam>
    /// <typeparam name="TReturn">The return type.</typeparam>
    /// <param name="interfaceMethodSelector">An expression selecting the method from the interface. This may be a lambda expression.</param>
    /// <param name="implementation">The implementation of the method.</param>
    public Builder<TInterface> Func<TArg1, TReturn>(
        Expression<Func<TInterface, Func<TArg1, TReturn>>> interfaceMethodSelector,
        Func<TArg1, TReturn> implementation) =>
            Method(interfaceMethodSelector, implementation);

    /// <summary>
    /// Adds a void-returning method implementation. The type arguments should be specified explicitly.
    /// </summary>
    /// <typeparam name="TArg1">The type of the argument.</typeparam>
    /// <typeparam name="TArg2">The type of the argument.</typeparam>
    /// <typeparam name="TArg3">The type of the argument.</typeparam>
    /// <param name="interfaceMethodSelector">An expression selecting the method from the interface. This may be a lambda expression.</param>
    /// <param name="implementation">The implementation of the method.</param>
    public Builder<TInterface> Action<TArg1, TArg2, TArg3>(
        Expression<Func<TInterface, Action<TArg1, TArg2, TArg3>>> interfaceMethodSelector,
        Action<TArg1, TArg2, TArg3> implementation) =>
            Method(interfaceMethodSelector, implementation);

    /// <summary>
    /// Adds a value-returning method implementation. The type arguments should be specified explicitly.
    /// </summary>
    /// <typeparam name="TArg1">The type of the argument.</typeparam>
    /// <typeparam name="TArg2">The type of the argument.</typeparam>
    /// <typeparam name="TReturn">The return type.</typeparam>
    /// <param name="interfaceMethodSelector">An expression selecting the method from the interface. This may be a lambda expression.</param>
    /// <param name="implementation">The implementation of the method.</param>
    public Builder<TInterface> Func<TArg1, TArg2, TReturn>(
        Expression<Func<TInterface, Func<TArg1, TArg2, TReturn>>> interfaceMethodSelector,
        Func<TArg1, TArg2, TReturn> implementation) =>
            Method(interfaceMethodSelector, implementation);

    /// <summary>
    /// Adds a void-returning method implementation. The type arguments should be specified explicitly.
    /// </summary>
    /// <typeparam name="TArg1">The type of the argument.</typeparam>
    /// <typeparam name="TArg2">The type of the argument.</typeparam>
    /// <typeparam name="TArg3">The type of the argument.</typeparam>
    /// <typeparam name="TArg4">The type of the argument.</typeparam>
    /// <param name="interfaceMethodSelector">An expression selecting the method from the interface. This may be a lambda expression.</param>
    /// <param name="implementation">The implementation of the method.</param>
    public Builder<TInterface> Action<TArg1, TArg2, TArg3, TArg4>(
        Expression<Func<TInterface, Action<TArg1, TArg2, TArg3, TArg4>>> interfaceMethodSelector,
        Action<TArg1, TArg2, TArg3, TArg4> implementation) =>
            Method(interfaceMethodSelector, implementation);

    /// <summary>
    /// Adds a value-returning method implementation. The type arguments should be specified explicitly.
    /// </summary>
    /// <typeparam name="TArg1">The type of the argument.</typeparam>
    /// <typeparam name="TArg2">The type of the argument.</typeparam>
    /// <typeparam name="TArg3">The type of the argument.</typeparam>
    /// <typeparam name="TReturn">The return type.</typeparam>
    /// <param name="interfaceMethodSelector">An expression selecting the method from the interface. This may be a lambda expression.</param>
    /// <param name="implementation">The implementation of the method.</param>
    public Builder<TInterface> Func<TArg1, TArg2, TArg3, TReturn>(
        Expression<Func<TInterface, Func<TArg1, TArg2, TArg3, TReturn>>> interfaceMethodSelector,
        Func<TArg1, TArg2, TArg3, TReturn> implementation) =>
            Method(interfaceMethodSelector, implementation);
}
