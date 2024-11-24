namespace ArtForAll.GenericsLinqCollections.reflection.Exercises
{
    public class Exercises
    {
        public void ExecuteCOdeHere()
        {
            //arguments class
            Type[] typeArgs = {typeof(Request), typeof(Response)};

            //type class
            Type pipelineType = typeof(Pipeline<,>).MakeGenericType(typeArgs);

            var element = Activator.CreateInstance(pipelineType);
            ((dynamic)element).Process(new Request());
        }

    }


    public interface IPipeline<TRequest, TResponse>
        where TRequest : BaseRequest
        where TResponse : IDisposable, new()
    {
        TResponse Process(TRequest request);
    }

    public abstract class BaseRequest{}

    public class Request : BaseRequest{}
    public class Response : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    public class Pipeline<TRequest, TResponse> : IPipeline<TRequest, TResponse>
        where TRequest : BaseRequest
        where TResponse : IDisposable, new()
    {
        public TResponse Process(TRequest request)
        {
            var response = new TResponse();
            Console.WriteLine($"request: {request}, response: {response}");
            return response;
        }
    }
}
