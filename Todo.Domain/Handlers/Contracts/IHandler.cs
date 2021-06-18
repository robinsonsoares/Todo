using Todo.Domain.Commands.Contracts;


namespace Todo.Domain.Handlers.Contracts
{
    public interface IHandler<T> where T : Icommand
    {
        ICommandResult Handle(T command);
    }
}