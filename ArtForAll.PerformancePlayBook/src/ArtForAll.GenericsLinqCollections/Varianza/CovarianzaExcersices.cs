using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtForAll.GenericsLinqCollections.Varianza
{
    internal class CovarianzaExcersices
    {
        public void Execute()
        { 
        }
        public void ExecuteCovariance()
        {
            //COVARIANCE
            //Covariance applies to how instances of a generic type parameter are return from it methods 
            //Only interfaces and delagates supports the out keyword
            //covariance is readonly
            //You can not accept an out T parameter in a method, is only to return
            //c# 9 introduces support covariance return types on derived classes
            //methods returning Task<T> can not use covariant out T
            //There is a nuget MorseCode.ITask that suppports Task<T>

            //CONTRAVARIANCE
            //You can not return a in T parameter, you can only accept T as argument method
            //T can only be covariant or contravariant, if you aply both then will be invariance
        }
        public void ExecuteFailVariance()
        {
            var createHandler  = new CreateCommandHandler();
            var baseHandler  = new BaseCommandHandler();

            var createC = new CreateCommand();
            var baseC = new BaseCommand();

            //c# generic interfcaes are invariant by default
            //FailBaseHandle(createHandler);//canot assign an specific handler to a less specific
            //FailCreateHandle(baseHandler);

            //Close generic type parameters must match exactly
            var handlerBase = new Handler<BaseCommand>();
            var handlerSpecific = new Handler<CreateCommand>();

            //In this example c# interfaces are invariant by default
            //FailBaseHandle(handlerSpecific);//canot assign an specific handler to a less specific
            //FailCreateHandle(handlerBase);
        }

        private void FailCreateHandle(ICommandHandler<CreateCommand> commandHandler)
        {

        }
        private void FailBaseHandle(ICommandHandler<BaseCommand> commandHandler)
        {

        }
    }

    public class BaseCommand { }
    public class CreateCommand : BaseCommand { }
    public interface ICommandHandler<TCommand>
        where TCommand : class
    {
        void Handle(TCommand command);
    }

    public class Handler<TCommand> : ICommandHandler<TCommand>
        where TCommand : class
    {
        public void Handle(TCommand command)
        {
            throw new NotImplementedException();
        }
    }
    public class BaseCommandHandler : ICommandHandler<BaseCommand>
    {
        public void Handle(BaseCommand command)
        {
            throw new NotImplementedException();
        }
    }

    public class CreateCommandHandler : ICommandHandler<CreateCommand>
    {
        public void Handle(CreateCommand command)
        {
            throw new NotImplementedException();
        }
    }

    //VARIANCE
    //Assign an parent instance to an specific instance is not allowed
    //that is an example of variance
}
