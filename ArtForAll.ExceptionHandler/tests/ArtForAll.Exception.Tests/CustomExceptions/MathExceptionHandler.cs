using ArtForAll.Shared.ExceptionHandler;

namespace CASPAR.Shared.ExceptionHandler.CustomExceptions
{
    public class MathExceptionHandler : ExceptionHandlerBase
    {
        public MathExceptionHandler()
        {
            this.Catch<DivideByZeroException>(ex =>
            {
                throw ex;
            });

            this.Catch<Exception>(ex =>
            {
                throw ex;
            });
        }
    }
}
