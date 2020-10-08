using Logger.Models.Enumerations;

namespace Logger.Models.Contracts
{
    public interface IAppender
    {
        ILayout Layout { get; }

        void Append(IError error);

        long MessagesAppended { get; }

        Level Level { get; }

    }
}
