namespace CarStore.Application.Services.Primitives;

public interface ICommandHandler<TCommand> where TCommand : ICommand
{
    Task Handle(TCommand command, CancellationToken cancellationToken);
}

public interface ICommandHandler<TCommand, TResult> where TCommand : ICommand<TResult>
{
    Task<TResult> Handle(TCommand command, CancellationToken cancellationToken);
}