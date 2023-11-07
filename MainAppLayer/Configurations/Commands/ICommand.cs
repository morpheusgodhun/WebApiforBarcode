using MediatR;

namespace MainAppLayer.Configurations.Commands;
public interface ICommand : IRequest {

    string SessionId {
        get;
    }

    Guid RequestId {
        get;
    }

    DateTime OccurredOn {
        get;
    }

    public interface ICommand<TResult> : IRequest<TResult> {

        string SessionId {
            get;
        }

        Guid RequestId {
            get;
        }

        DateTime OccurredOn {
            get;
        }
    }
}