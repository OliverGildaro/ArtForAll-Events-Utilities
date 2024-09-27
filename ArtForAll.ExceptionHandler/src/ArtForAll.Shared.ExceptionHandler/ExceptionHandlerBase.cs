using ArtForAll.Shared.ExceptionHandler.Exceptions;

namespace ArtForAll.Shared.ExceptionHandler
{
    public class ExceptionHandlerBase : IExceptionHandlerBase
    {
        public Dictionary<Type, Action<Exception>> handlers;

        public ExceptionHandlerBase()
        {
            this.handlers = new Dictionary<Type, Action<Exception>>();
        }

        public async Task HandleAsync(Func<Task> action)
        {
            try
            {
                await action();
            }
            catch (Exception ex)
            {
                Type exceptionType = ex.GetType();
                if (this.handlers.ContainsKey(exceptionType))
                {
                    var firstHandler = this.handlers[exceptionType];
                    firstHandler(ex);
                }
                else
                {
                    UnHandlerException exceptionNoConfigured = new UnHandlerException($"No Exception is configured with this type: {exceptionType}");
                    throw exceptionNoConfigured;
                }
            }
        }

        public async Task<T> HandleAsync<T>(Func<Task<T>> func)
        {
            try
            {
                return await func();
            }
            catch (Exception ex)
            {
                Type exceptionType = ex.GetType();
                if (this.handlers.ContainsKey(exceptionType))
                {
                    var firstHandler = this.handlers[exceptionType];
                    firstHandler(ex);
                }
                else
                {
                    UnHandlerException exceptionNoConfigured = new UnHandlerException($"No Exception is configured with this type: {exceptionType}");
                    throw exceptionNoConfigured;
                }

                throw;
            }
        }

        public void Catch<T>(Action<Exception> catchAction) where T : Exception
        {
            Type exceptionType = typeof(T);

            var mainHandler = this.handlers.FirstOrDefault(ex => exceptionType.Equals(ex.Key));
            bool existException = mainHandler.Value != null;

            if (existException)
            {
                this.handlers[mainHandler.Key] = catchAction;
            }
            else
            {
                this.handlers.Add(exceptionType, catchAction);
            }
        }
    }
}
