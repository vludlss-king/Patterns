using Patterns.Strategy.Contracts;

namespace Patterns.Strategy
{
    internal class LoggerContext
    {
        private readonly ILogWriter _logWriter;

        public LoggerContext(ILogWriter logWriter)
        {
            _logWriter = logWriter;    
        }

        public void WriteLog(string message)
        {
            _logWriter.WriteLog(message);
        }
    }
}
