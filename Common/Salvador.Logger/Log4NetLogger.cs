using log4net;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Salvador.Logger
{
    public sealed class Log4NetLogger : ILogger
    {
        private readonly string _categoryName;
        private readonly XmlElement _configuration;

        private readonly ILog _log;

        public Log4NetLogger(string categoryName, XmlElement configuration)
        {
            _categoryName = categoryName;
            _configuration = configuration;

            var loggerRepository = LogManager.CreateRepository(
                Assembly.GetEntryAssembly()!,
                typeof(log4net.Repository.Hierarchy.Hierarchy));

            _log = LogManager.GetLogger(loggerRepository.Name, categoryName);

            log4net.Config.XmlConfigurator.Configure(loggerRepository, configuration);
        }


        public void Log<TState>(
            LogLevel level,
            EventId id,
            TState state,
            Exception? error,
            Func<TState, Exception, string> formatter)
        {
            if (formatter is null)
                throw new ArgumentNullException(nameof(formatter));

            if (!IsEnabled(level)) return;



            var logMessage = formatter(state, error!);

            if (string.IsNullOrEmpty(logMessage) && error is null) return;

            switch (level)
            {
                default: throw new ArgumentOutOfRangeException(nameof(level), level, null);

                case LogLevel.Trace:
                case LogLevel.Debug:
                    _log.Debug(logMessage);
                    break;

                case LogLevel.Information:
                    _log.Info(logMessage);
                    break;

                case LogLevel.Warning:
                    _log.Warn(logMessage);
                    break;

                case LogLevel.Error:
                    _log.Error(logMessage ?? error!.ToString());
                    break;

                case LogLevel.Critical:
                    _log.Fatal(logMessage ?? error!.ToString());
                    break;

                case LogLevel.None:
                    break;
            }
        }

        public bool IsEnabled(LogLevel level)
        {
            switch (level)
            {
                default: throw new ArgumentOutOfRangeException(nameof(level), level, null);

                case LogLevel.Trace:
                case LogLevel.Debug:
                    return _log.IsDebugEnabled;

                case LogLevel.Information:
                    return _log.IsInfoEnabled;

                case LogLevel.Warning:
                    return _log.IsWarnEnabled;

                case LogLevel.Error:
                    return _log.IsErrorEnabled;

                case LogLevel.Critical:
                    return _log.IsFatalEnabled;

                case LogLevel.None:
                    return false;
            }


        }

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;
    }
}
