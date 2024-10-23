namespace CarStore.Application.Services.Primitives;

public interface IQueryHandler<TQuery, TResult> where TQuery : IQuery<TResult>
{
    Task<TResult> Handle(TQuery query, CancellationToken cancellationToken);
}
