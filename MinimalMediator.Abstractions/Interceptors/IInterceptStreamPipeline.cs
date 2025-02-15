﻿using System.Collections.Generic;
using System.Threading;
using MinimalMediator.Abstractions.Messages.Streams;

namespace MinimalMediator.Abstractions.Interceptors;

public interface IInterceptStreamPipeline<TRequest, TResponse>
    where TRequest : IStreamRequestBase<TResponse>
{
    IAsyncEnumerable<TResponse> Handle(TRequest request, HandlerForStreamDelegate<TRequest, TResponse> next,
        CancellationToken cancellationToken);
}

public delegate IAsyncEnumerable<TResponse> HandlerForStreamDelegate<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken);
