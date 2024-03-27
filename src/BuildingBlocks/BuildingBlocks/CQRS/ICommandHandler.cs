using MediatR;

namespace BuildingBlocks.CQRS
{
    public interface ICommandHandler<in TCommant>
        : IRequestHandler<TCommant, Unit>
        where TCommant : ICommand
    {
    }

    public interface ICommandHandler<in TCommant, TResponse>
        : IRequestHandler<TCommant, TResponse>
        where TCommant : ICommand<TResponse>
        where TResponse : notnull
    {
    }
}
