using System.Reflection;
using Microsoft.Extensions.Logging;

namespace Salvador.Logger
{
   public static class Log4NetExtensions
    {
        public static ILoggerFactory AddLog4Net(this ILoggerFactory loggerFactory, string configurationFile = "Log4Net.config")
        {
            if (!Path.IsPathFullyQualified(configurationFile))
            {
                var assembly = Assembly.GetEntryAssembly()
                               ?? throw new InvalidOperationException(
                                   "Не удалось определить сборку с точкой входа приложения");

                var dir = Path.GetDirectoryName(assembly.Location) ??
                          throw new InvalidOperationException("Не удалось определить каталог исполняемого файла");

                configurationFile = Path.Combine(dir, configurationFile);
            }

            loggerFactory.AddProvider(new Log4NetProvider(configurationFile));


            return loggerFactory;
        }
    }
}
