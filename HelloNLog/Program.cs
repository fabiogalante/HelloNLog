using NLog;
using NLog.Config;
using NLog.Targets;
using System;

namespace HelloNLog
{
    class Program
    {
        
        static void Main(string[] args)
        {
            NLogMethod();
            CallFizzBuzz();
        }

        private static void CallFizzBuzz()
        {
            ConsoleTarget consoleTarget = new ConsoleTarget
            {
                Name = "consoleTarget",
                Layout = "${message}"
            };

            LoggingConfiguration loggingConfiguration = new LoggingConfiguration();

            loggingConfiguration.AddRuleForAllLevels(consoleTarget);

            LogFactory logFactory = new LogFactory(loggingConfiguration);


            var logger = logFactory.GetLogger("FizzBuzz");

            Calculus fizzBuzz = new Calculus();
            for (int i = 0; i < 50; i++)
            {
                var random = new Random();
                int number = random.Next(100);
                var resut = fizzBuzz.FizzBuzz(number);
                //Debug.WriteLine($"{number} : {resut}");
                logger.Info($"{number} : {resut}");
                Console.WriteLine(resut);

            }
        }

        private static void NLogMethod()
        {
           

            // _logger.Info("Teste");
        }
    }
}
