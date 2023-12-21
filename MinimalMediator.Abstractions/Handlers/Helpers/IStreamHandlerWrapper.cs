﻿
using System.Collections.Generic;
using System.Threading;
using MinimalMediator.Abstractions.Messages;
using MinimalMediator.Abstractions.Messages.Streams;

namespace MinimalMediator.Abstractions.Handlers.Helpers;

public interface IStreamHandlerWrapper<in TRequest, out TResponse> where TRequest : IStreamRequestBase<TResponse>
{
    IAsyncEnumerable<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
}

internal interface IStreamHandlerWrapper
{
    IAsyncEnumerable<object> Handle(IIdentifiableRequest request, CancellationToken cancellationToken);
}