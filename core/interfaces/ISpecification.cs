﻿using System.Linq.Expressions;

namespace core.interfaces;

public interface ISpecification<T>
{
    Expression<Func<T, bool>> Criteria { get; }
    Expression<Func<T, object>>? OrderBy { get; }
    Expression<Func<T, object>>? OrderByDescending { get; }

    bool IsDistinct { get; }
}

public interface ISpecification<T, TResult> : ISpecification<T>
{
    Expression<Func<T, TResult>>? Select { get; }
}