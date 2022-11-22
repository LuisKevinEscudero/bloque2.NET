namespace Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string path;

        public FileLogger( string path)
        {
            this.path = path;
        }
        
        public void logError(string message)
        {
            Log(message, "ERROR");
        }

        public void logInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            using (var streamWritter = new StreamWriter(path, true))
            {
                streamWritter.WriteLine(message +": " + message);
                streamWritter.Dispose();
            }
        }
    }
}