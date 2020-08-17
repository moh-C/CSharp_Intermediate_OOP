using System.IO;

namespace InterfacesExtensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;
        }
        public void InfoLogger(string message)
        {
            Log(message: message, messageType: "Info");
        }
        public void ErrorLogger(string message)
        {
            Log(message: message, messageType: "Error");
        }
        private void Log(string message, string messageType)
        {
            var streamwriter = new StreamWriter(_path, true);
            streamwriter.WriteLine(messageType + ": " + message);
            streamwriter.Dispose();
        }
    }
}