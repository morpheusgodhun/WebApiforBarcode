using static MainAppLayer.Configurations.Commands.ICommand;

namespace MainAppLayer.Configurations.Commands;
public abstract class Command : ICommand
{

    #region Constructors
    public Command(string sessionId)
    {
        RequestId = Guid.NewGuid();
        OccurredOn = DateTime.UtcNow;
        SessionId = sessionId;
    }
    #endregion

    #region Properties
    public Guid RequestId
    {
        get;
    }

    public DateTime OccurredOn
    {
        get;
    }

    public string SessionId
    {
        get;
    }


    #endregion

    #region Methods

    #endregion

}

public abstract class Command<TResult> : ICommand<TResult>
{

    #region Constructors
    public Command(string sessionId)
    {
        RequestId = Guid.NewGuid();
        OccurredOn = DateTime.UtcNow;
        SessionId = sessionId;
    }
    #endregion

    #region Properties
    public Guid RequestId
    {
        get;
    }

    public DateTime OccurredOn
    {
        get;
    }

    public string SessionId
    {
        get;
    }

    #endregion

}