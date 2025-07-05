namespace Application.Interfaces.Pipleline;

public interface IPipelineBehaviour<in TInput, TOutput>
{
    Task<TOutput> HandleAsync(TInput input, Func<Task<TOutput>> next, CancellationToken cancellationToken = default);
}
