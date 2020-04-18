using System;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace HelloNLog
{
    class Program
    {
        static void Main(string[] args)
        {
            //NLogMethod();
        }

        private static void NLogMethod()
        {
            ConsoleTarget consoleTarget = new ConsoleTarget
            {
                Name = "consoleTarget",
                Layout = "${message}"
            };

            LoggingConfiguration loggingConfiguration = new LoggingConfiguration();

            loggingConfiguration.AddRuleForAllLevels(consoleTarget);

            LogFactory logFactory = new LogFactory(loggingConfiguration);

            Logger logger = logFactory.GetLogger("PluralsightLogger");

            logger.Info("Teste");
        }
    }
}
