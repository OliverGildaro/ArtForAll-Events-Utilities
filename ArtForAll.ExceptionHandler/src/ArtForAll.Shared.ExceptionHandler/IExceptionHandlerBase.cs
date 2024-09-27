namespace ArtForAll.Shared.ExceptionHandler
{
    public interface IExceptionHandlerBase
    {
        Task HandleAsync(Func<Task> action);

        Task<T> HandleAsync<T>(Func<Task<T>> action);

        void Catch<T>(Action<Exception> catchAction) where T : Exception;
    }
}
