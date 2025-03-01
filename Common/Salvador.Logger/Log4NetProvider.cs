using Microsoft.Extensions.Logging;
using System.Collections.Concurrent;
using System.Xml;

namespace Salvador.Logger
{
    public sealed class Log4NetProvider : ILoggerProvider
    {
        private readonly string _configurationFile;

        private readonly ConcurrentDictionary<string, Log4NetLogger> _loggers = new();

        public Log4NetProvider(string configurationFile) => _configurationFile = configurationFile;

        public ILogger CreateLogger(string categoryName)
        {
            return _loggers.GetOrAdd(categoryName, category =>
            {
                var xml = new XmlDocument();
                xml.Load(_configurationFile);
                return new Log4NetLogger(category, xml["log4net"]!);
            });
        }

        public void Dispose() => _loggers.Clear();
    }
}
