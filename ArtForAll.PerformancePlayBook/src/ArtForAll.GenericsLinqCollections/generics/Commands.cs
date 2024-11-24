namespace Generic.Commands
{
    public class Executer
    {
        public void Execute()
        {
                        string[] inputs = { "Follow ", "Steve ", "on ", "Pluralsight.com ", "to ", "get ", "updates!" };
            ICommand<string> c = new ConcatCommand(inputs); // can replace with ICommand<string>
            string results = c.Execute();   // which eliminates the cast here
            Console.WriteLine(results);
        }
    }
    public interface ICommand
    {
        object Execute();
    }

    public interface ICommand<TResult> : ICommand
    {
        new TResult Execute();
    }











    // concrete Command class implements non-generic interface
    public class Command : ICommand
    {
        protected Func<ICommand, object> ExecFunc { get; }

        public object Execute()
        {
            return ExecFunc(this);
        }

        public Command(Func<ICommand, object> execFunc)
        {
            ExecFunc = execFunc;
        }
    }







    // generic class inherits from non-generic
    public class Command<TResult> : Command, ICommand<TResult> where TResult : class
    {
        new protected Func<ICommand<TResult>, TResult> ExecFunc => (ICommand<TResult> cmd) => (TResult)base.ExecFunc(cmd);

        TResult ICommand<TResult>.Execute()
        {
            return ExecFunc(this);
        }

        public Command(Func<ICommand<TResult>, TResult> execFunc) :
            base((ICommand c) => (object)execFunc((ICommand<TResult>)c))
        {
        }
    }







    public class ConcatCommand : Command<string>
    {
        public IEnumerable<String> Inputs { get; }

        public ConcatCommand(IEnumerable<String> inputs) :
            base((ICommand<string> c) => (string)String.Concat(((ConcatCommand)c).Inputs))
        {
            Inputs = inputs;
        }
    }











    public class CollectCommand : Command
    {
        public IEnumerable<object> Inputs { get; }
        public CollectCommand(IEnumerable<object> inputs) :
            base((ICommand c) => new List<object>(((CollectCommand)c).Inputs))
        {
            Inputs = inputs;
        }
    }
}
