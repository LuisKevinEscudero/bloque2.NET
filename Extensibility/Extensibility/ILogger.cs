namespace Extensibility
{
    public interface ILogger
    {
        void logError(string message);
        void logInfo(string message);
    }
}