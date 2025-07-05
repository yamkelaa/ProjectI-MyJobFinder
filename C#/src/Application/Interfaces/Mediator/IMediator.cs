﻿using Application.Interfaces.Command;
using Application.Interfaces.Query;
namespace Application.Interfaces.Mediator;

public interface IMediator
{
    Task<TResult> SendCommandAsync<TCommand, TResult>(TCommand command, CancellationToken cancellationToken = default) where TCommand : ICommand<TResult>;
    Task<TResult> SendQueryAsync<TQuery, TResult>(TQuery query, CancellationToken cancellationToken = default) where TQuery : IQuery<TResult>;
}
